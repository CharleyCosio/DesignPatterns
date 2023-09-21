using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesingPatternsAsp.Controllers
{
    public class ProductoDetailController : Controller
    {

        private EarnFactory _localEarnFactory;

        public ProductoDetailController(LocalEarnFactory localEarnFactory)
        {
            _localEarnFactory = localEarnFactory;
        }

        public IActionResult Index(decimal total)
        {
            //FACTORIES
            ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.30m,20);

            //PRODUCTO
            var localEarn = _localEarnFactory.GetEarn();
            var foreignEarn = foreignEarnFactory.GetEarn();

            //TOTAL
            ViewBag.totalLocal=total+localEarn.Earn(total);
            ViewBag.totalForeign=total+foreignEarn.Earn(total);


            return View();
        }
    }
}
