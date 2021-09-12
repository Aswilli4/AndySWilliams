using AndySWilliams.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AndySWilliams.ViewModels;
using AndySWilliams.Services;
using AndySWilliams.Data;

namespace AndySWilliams.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITestMailService _testMailService;
        private readonly IASWRepository _repository;

        public HomeController(ILogger<HomeController> logger ,ITestMailService testMailService, IASWRepository repository)
        {
            _logger = logger;
            _testMailService = testMailService;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost("contact")]
        public IActionResult Contact (ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                _testMailService.SendEmailMessage("asw101684@gmail.com", model.Subject, $"From: {model.FirstName + model.LastName} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Successfully Sent!";
                ModelState.Clear();
            }
            return View();
        }

        public IActionResult Family()
        {
            var results = _repository.GetAllFamilyMembers();
                          
            return View(results);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
