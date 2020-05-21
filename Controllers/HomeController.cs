using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ItemStoreProject.Models;
using ItemStoreProject.Persistence;
using ItemStoreProject.Persistence.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace ItemStoreProject.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly AppDbContext _dbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(UserManager<User> userManager, SignInManager<User> signInManager, AppDbContext dbContext, ILogger<HomeController> logger)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            _dbContext = dbContext;
            _logger = logger;
        }

        [HttpGet]
        [HttpGet("Home")]
        [HttpGet("Index")]
        [HttpGet("Index/{id?}")]
        public IActionResult Index([FromQuery] string title)
        {
            HomeViewModel data;
            if (User.Identity.IsAuthenticated)
            {
                data = new HomeViewModel
                {
                    Title = "Logged as: " + User.Identity.Name
                };

                return View("index", data);
            } else {
                data = new HomeViewModel
                {
                    Title = "Anonymous user"
                };
                return View("index", data);
            }
        }

        [HttpGet("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}