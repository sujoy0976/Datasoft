using ColorWebsite.Data.Services;
using System;
using System.Web.Mvc;
using System.Configuration;

namespace ColorWebsite.Controllers
{
    public class HomeController : Controller
    {
        private ColorService _colorService;

        public HomeController()
        {
            _colorService = new ColorService();
        }

        public ActionResult Index()
        {
            var model =_colorService.GetAllColors();

            var computername = ConfigurationManager.AppSettings;

            model[0].computername = computername["COMPUTERNAME"];
            return View(model);
        }
    }
}