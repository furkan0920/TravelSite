using Microsoft.AspNetCore.Mvc;
using TravelWebSite.Models;

namespace TravelWebSite.Controllers
{
	public class DefaultController : Controller
	{
		private readonly Context c;

		// Context'i Dependency Injection ile alıyoruz
		public DefaultController(Context context)
		{
			c = context;
		}
		public IActionResult Index()
		{
			var values = c.Blogs.Take(10).ToList();
			return View(values);
		}
		public IActionResult About()
		{
			return View();
		}
		public PartialViewResult Partial1()
		{
			var values = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
			return PartialView(values);

		}
		public PartialViewResult Partial2()
		{
			var value = c.Blogs.Where(x => x.ID == 1).Take(1).ToList();
			return PartialView(value);
		}
		public PartialViewResult Partial3()
		{
			var value = c.Blogs.Take(3).ToList();
			return PartialView(value);
		}
		public PartialViewResult Partial4()
		{
			var value = c.Blogs.Take(3).ToList();
			return PartialView(value);
		}
		public PartialViewResult Partial5()
		{
			var value = c.Blogs.Take(3).OrderByDescending(x=>x.ID).ToList();
			return PartialView(value);
		}
	}
}
