using DOANMAYBAY2023.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace DOANMAYBAY2023.Controllers
{
    [Route("api/paypal")]
    public class PayPalController : Controller
    {
        private VeService veService;
        IWebHostEnvironment webHostEnvironment;
        private IConfiguration configuration;
        public PayPalController(VeService _veService, IWebHostEnvironment _webHostEnvironment, IConfiguration _configuration)
        {
            veService = _veService;
            webHostEnvironment = _webHostEnvironment;
            this.configuration = configuration;
        }
        [Produces("application/json")]
        [HttpGet("index")]
        public IActionResult Index()
        {
            ViewBag.ves = veService.find("CB0001");
            ViewBag.postUrl = configuration["PayPal:PostUrl"];
            ViewBag.returnUrl = configuration["PayPal:ReturnUrl"];
            ViewBag.business = configuration["Paypal:Business"];
            return View();
            
        }
    }
}
