using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Student_WebApi.Models;

namespace Student_WebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppSettings _settings;
        public HomeController(IOptions<AppSettings> settings)
        {
            _settings = settings.Value;
        }
        public IActionResult Index()
        {
            return Content(
                $"Name of the Application : {_settings.ApplicationName} \n" + 
                $"Support : {_settings.SupportEmail}");
        }
    }
}
