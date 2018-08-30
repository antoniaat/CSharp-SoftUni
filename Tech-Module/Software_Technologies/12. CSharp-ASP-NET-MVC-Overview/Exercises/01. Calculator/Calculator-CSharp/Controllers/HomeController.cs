namespace Calculator_CSharp.Controllers
{
    using System.Web.Mvc;
    using Calculator_CSharp.Models;

    public class HomeController : Controller
    {
        public ActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }

        private decimal CalculateResult(Calculator calculator)
        {
            var result = 0m;

            switch (calculator.Operator)
            {
                case "+":
                    result = calculator.LeftOperand + calculator.RightOperand;
                    break;
                case "-":
                    result = calculator.LeftOperand - calculator.RightOperand;
                    break;
                case "*":
                    result = calculator.LeftOperand * calculator.RightOperand;
                    break;
                case "/":
                    result = calculator.LeftOperand / calculator.RightOperand;
                    break;
            }
            return result;
        }

        [HttpPost]
        public ActionResult Calculate(Calculator calculator)
        {
            calculator.Result = CalculateResult(calculator);
            return RedirectToAction("Index", calculator);
        }
    }
}