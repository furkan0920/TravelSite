using Microsoft.AspNetCore.Mvc;
using TravelWebSite.Models;

namespace TravelWebSite.Controllers
{
	public class AboutController : Controller
	{
		private readonly Context _context;

		// Context'i Dependency Injection ile alıyoruz
		public AboutController(Context context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var values=_context.Abouts.ToList();
			return View(values);
		}
	}
}
