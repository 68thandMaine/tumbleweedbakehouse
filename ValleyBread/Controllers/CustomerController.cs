using Microsoft.AspNetCore.Mvc;

namespace ValleyBread.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet("/yourclass")]
        public ActionResult Index()
        {
          return View();
        }

    }
}