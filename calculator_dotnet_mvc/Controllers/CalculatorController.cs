using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace calculator_dotnet_mvc.Controllers
{
    public class CalculatorController : Controller
    {
        public ActionResult CalculatorView()
        {
            return View ();
        }

        [HttpPost]
        public ActionResult total(int value1, int value2, String calci)
        {
            int total = 0; 

            switch (calci)
            {
                case "+":
                    total = value1 + value2; 
                    break;
                case "-":
                    total = value1 - value2;
                    break;
                case "*":
                    total = value1 * value2;
                    break;
                case "/":
                    total = value1 / value2;
                    break;
                default:
                    total = 0; 
                    break;
            }
            return Content("Result: " + total); 
        }
    }
}
