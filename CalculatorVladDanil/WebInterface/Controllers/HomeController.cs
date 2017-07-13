using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using CalculatorVladDanil.TwoArguments;

namespace WebInterface.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operations = new List<SelectListItem>()
            {
                new SelectListItem {Text = "+", Value = "buttonPlus"},
                new SelectListItem {Text = "-", Value = "buttonMinus"},
                new SelectListItem {Text = "*", Value = "buttonMulti"},
                new SelectListItem {Text = "/", Value = "buttonDivisiom"}
            };
            return View();
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

        public ActionResult Calculate(double firstValue, double secondValue, string operation)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(operation);
            double result = calculator.ExecuteOperation(firstValue, secondValue);
            return View(result);
        }
    }
}