namespace YearPercet.Web.Controllers
{
    using System.Web.Mvc;

    using YearPercent.Business.Interfaces;

    using YearPercet.Web.Models;

    public class HomeController : Controller
    {
        private readonly IPercentCalculator _percentCalculator;

        public HomeController(IPercentCalculator percentCalculator)
        {
            _percentCalculator = percentCalculator;
        }

        public ActionResult Index()
        {
            var viewModel = new YearPercentViewModel { YearPercent = _percentCalculator.PercentOfCurrentYearRightNow() };

            return View(viewModel);
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