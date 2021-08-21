using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Weixight.CExchange.Entity.Model;
using Weixight.CExchange.Infrastructure.Implemetation;
using Weixight.CExchange.Service.Implementation;
using Weixight.CExchange.Service.Interface;
using Weixight.CExchange.Web.Models;

namespace Weixight.CExchange.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IEmail _emailService = null;
        public HomeController(ILogger<HomeController> logger, IEmail emailService)
        {
            _logger = logger;
            _emailService = emailService;
        }
        //ok
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("SendEmailWithAttachment")]
        [HttpPost]
        public bool SendEmailWithAttachment([FromForm] EmailDataWithAttachment emailData)
        {
            return _emailService.SendEmailWithAttachment(emailData);
        }
        [Route("SendUserWelcomeEmail")]
        [HttpPost]
        public bool SendUserWelcomeEmail([FromForm] UserData userData)
        {
            return _emailService.SendUserEmailTemplate(userData);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
