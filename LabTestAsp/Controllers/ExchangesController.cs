using Microsoft.AspNetCore.Mvc;
namespace WseiLabs.Controllers
{
    public class ExchangesController : Controller
    {
        // GET
        public IActionResult Index(string date, string entryName)
        {
            return View();
        }
    }
}