using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Diagnostics;
using Stocks.Models;

namespace Stocks.Controllers
{
    public class HomeController : Controller
    {
       [Route("Error")]
       public IActionResult Error()
       {
           IExceptionHandlerPathFeature? exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            if(exceptionHandlerPathFeature!=null && exceptionHandlerPathFeature!=null)
            {
                Error error = new Error() { ErrorMessage = exceptionHandlerPathFeature.Error.Message };
                return View(error);
            }
            else
            {
                Error error = new Error() { ErrorMessage = "Something went wrong" };
                return View(error);
            }
       } 
    }
}
