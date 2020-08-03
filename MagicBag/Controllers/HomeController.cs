using System.Web.Mvc;
using MagicBag.Data.Services;

namespace MagicBag.Controllers
{
    public class HomeController : Controller
    {
        private IBagData db;

        public HomeController()
        {
            db = new InMemoryBagData();
        }

        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

    }
}