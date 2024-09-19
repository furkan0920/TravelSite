using Microsoft.AspNetCore.Mvc;
using TravelWebSite.Models;
namespace TravelWebSite.Controllers
{
    public class BlogController : Controller
    {
        private readonly Context c;

        // Context'i Dependency Injection ile alıyoruz
        public BlogController(Context context)
        {
            c = context;
        }


        BlogComments bc = new BlogComments();
        public IActionResult Index()
        {
            //var blogs=c.Blogs.ToList();
            bc.Value1 = c.Blogs.ToList();
            bc.Value3 = c.Blogs.Take(2).ToList();
            return View(bc);
        }

        public IActionResult BlogDetails(int id)
        {
            //var blogsearch=c.Blogs.Where(x=>x.ID==id).ToList();
            bc.Value1 = c.Blogs.Where(x => x.ID == id).ToList();
            bc.Value2 = c.Commentss.Where(x => x.Blogid == id).ToList();
            return View(bc);
        }
        [HttpGet]
        public PartialViewResult MakeComment(int id)
        {
            ViewBag.value = id;
            return PartialView();
        }
      
        [HttpPost]
        public PartialViewResult MakeComment(Comments cm)
        {
            c.Commentss.Add(cm);
            c.SaveChanges();
            return PartialView();

        }

    }
}
