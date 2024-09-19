using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TravelWebSite.Models;

namespace TravelWebSite.Controllers
{
	public class LogInController : Controller
	{
		private readonly Context c;

		// Context'i Dependency Injection ile alıyoruz
		public LogInController(Context context)
		{
			c = context;
		}
		public IActionResult Index()
		{
			return View();
		}
		public ActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Login(Admin ad)
		{
			// Veritabanından kullanıcıyı kontrol et
			var inf = c.Admins.FirstOrDefault(x => x.User == ad.User && x.Password == ad.Password);
			if (inf != null)
			{
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name, inf.User)
				};

				var claimsIdentity = new ClaimsIdentity(claims, "CookieAuth");

				var authProperties = new AuthenticationProperties
				{
					IsPersistent = true // Oturumun kalıcı olup olmadığını belirler (persistent cookie)
				};

				await HttpContext.SignInAsync("CookieAuth", new ClaimsPrincipal(claimsIdentity), authProperties);

				return RedirectToAction("Index", "Admin");
			}
			else
			{
				ModelState.AddModelError("", "Geçersiz kullanıcı adı veya şifre");
				return View();
			}
		}
		public async Task<IActionResult> Logout()
		{
			await HttpContext.SignOutAsync("CookieAuth");
			return RedirectToAction("Login", "LogIn");
		}

	}
}

