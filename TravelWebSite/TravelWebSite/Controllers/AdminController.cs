using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelWebSite.Models;

namespace TravelWebSite.Controllers
{
	public class AdminController : Controller
	{
		private readonly Context c;

		// Context'i Dependency Injection ile alıyoruz
		public AdminController(Context context)
		{
			c = context;
		}
		[Authorize]
		public IActionResult Index()
		{
			var values=c.Blogs.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult NewBlog()
		{
			return View();
		}
		[HttpPost]
		public IActionResult NewBlog(Blog p)
		{
			c.Blogs.Add(p);
			c.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult BlogDelete(int id)
		{
			var b=c.Blogs.Find(id);
			c.Blogs.Remove(b);
			c.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult BlogGet(int id)
		{
			var bl = c.Blogs.Find(id);
			return View("BlogGet",bl);
		}
		public ActionResult BlogUpdate(Blog b)
		{
			var blg=c.Blogs.Find(b.ID);
			blg.Description= b.Description;
			blg.Title= b.Title;
			blg.BlogImage= b.BlogImage;
			blg.DateT= b.DateT;
			c.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult CommentList()
		{
			var Comments=c.Commentss.ToList();
			return View(Comments);
		}
		public ActionResult CommentDelete(int id)
		{
			var b=c.Commentss.Find(id);
			c.Commentss.Remove(b);
			c.SaveChanges();
			return RedirectToAction("CommentList");
		}
		public ActionResult CommentGet(int id)
		{
			var b = c.Commentss.Find(id);
			return View("CommentGet", b);
		}
		public ActionResult CommentUpdate(Comments y)
		{
			var cmn=c.Commentss.Find(y.ID);
			cmn.UserName=y.UserName;
			cmn.Mail=y.Mail;
			cmn.Comment=y.Comment;
			c.SaveChanges();
			return RedirectToAction("CommentList");
		}
	}
}
