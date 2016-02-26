using EF6ForPostgreSQL.Models;
using System.Web.Mvc;

namespace EF6ForPostgreSQL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategories()
        {
            SampleDbContext dbContext = new SampleDbContext();

            var result = dbContext.Categories;

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}