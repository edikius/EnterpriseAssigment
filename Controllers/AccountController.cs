using ItemStoreProject.Models;
using ItemStoreProject.Persistence;
using ItemStoreProject.Persistence.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ItemStoreProject.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly AppDbContext _dbContext;
        private readonly ILogger<HomeController> _logger;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, AppDbContext dbContext, ILogger<HomeController> logger)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            _dbContext = dbContext;
            _logger = logger;
        }

        [HttpGet("accessDenied")]
        public IActionResult accessDenied()
        {
            return View();
        }

        [Authorize]
        [HttpPost("addItemOffers")]
        public async Task<IActionResult> addItemOffers(Offer model)
        {
            if (!ModelState.IsValid)
            {
                var errorList = string.Join(" | ", ModelState.Values
                     .SelectMany(v => v.Errors)
                     .Select(e => e.ErrorMessage));
                return Redirect("/account/ItemOffers/error/" + errorList);
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = _dbContext.Offers.SingleOrDefault(x => (x.OwnerId == userId && x.Quantity == model.Quantity && x.Price == model.Price));
            if (result != null)
            {
                result.Quantity += model.Quantity;
                _dbContext.SaveChanges();
            }
            else
            {
                model.OwnerId = userId;
                _dbContext.Offers.Add(model);
                _dbContext.SaveChanges();
            }
            return Redirect("/account/ItemOffers");
        }

        [Authorize]
        [HttpGet("ItemOffers")]
        [HttpGet("ItemOffers/error/{errorMessage?}")]
        public IActionResult ItemOffers(string errorMessage)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ItemOffersModel model = new ItemOffersModel();
            model.ItemTypeList = _dbContext.ItemType.ToList();
            model.ItemOffers = _dbContext.Offers.Where(x => x.OwnerId == userId).ToList();
            if (errorMessage == null) { 
                return View(model);
            } else  {
                model.errorMessage = errorMessage;
                return View(model);
            }
        }

        [Authorize]
        [HttpGet("ItemType")]
        [HttpGet("ItemOffers/error/{errorMessage?}")]
        public IActionResult itemtype(string errorMessage)
        {

            ItemTypesModel ItemTypes = new ItemTypesModel();
            ItemTypes.ItemTypes = _dbContext.ItemType.ToList();
            ItemTypes.CategoryList = _dbContext.Categories.OrderBy(o => o.CategoryName).ToList();
            if (errorMessage == null)
            {
                return View(ItemTypes);
            }
            else
            {
                ItemTypes.errorMessage = errorMessage;
                return View(ItemTypes);
            }
        }
        [Authorize]
        [HttpPost("addItemType")]
        public async Task<IActionResult> addItemType(ItemType model)
        {
            if (!ModelState.IsValid)
            {
                var errorList = string.Join(" | ", ModelState.Values
                     .SelectMany(v => v.Errors)
                     .Select(e => e.ErrorMessage));
                return Redirect("/account/itemtype/error/" + errorList);
            }

            _dbContext.ItemType.Add(model);
            _dbContext.SaveChanges();
            return Redirect("/account/itemtype");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("category")]
        [HttpGet("category/error/{errorMessage?}")]
        public IActionResult Categories(string errorMessage)
        {
            List<Categories> Items = new List<Categories>();
            Items = _dbContext.Categories.OrderBy(o => o.CategoryName).ToList();
            var model = new CategoriesViewModel();
                model.Categories = Items;
            if (errorMessage == null)
            {
                return View(model);
            }
            else
            {
                model.ErrorMessage = errorMessage;
                return View(model);
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("updateCategoryName")]
        public async Task<IActionResult> updateCategoryName(Categories model)
        {
            if (!ModelState.IsValid)
            {
                var errorList = string.Join(" | ", ModelState.Values
                     .SelectMany(v => v.Errors)
                     .Select(e => e.ErrorMessage));
                return Redirect("/account/category/error/" + errorList);
            }

            model.CategoryName = model.CategoryName.Trim();
            _dbContext.Categories.Update(model);
            _dbContext.SaveChanges();
            return Redirect("/account/category");
        }
        [Authorize(Roles = "Admin")]
        [HttpPost("addCategoryName")]
        public async Task<IActionResult> addCategoryName(Categories model)
        {
            if (!ModelState.IsValid)
            {
                var errorList = string.Join(" | ", ModelState.Values
                     .SelectMany(v => v.Errors)
                     .Select(e => e.ErrorMessage));
                return Redirect("/account/category/error/" + errorList);
            }
            _dbContext.Categories.Add(model);
            _dbContext.SaveChanges();
            return Redirect("/account/category");
        }
        [Authorize(Roles = "Admin")]
        [HttpPost("removeCategoryName")]
        public async Task<IActionResult> removeCategoryName(Categories model)
        {
            if (!ModelState.IsValid)
            {
                var errorList = string.Join(" | ", ModelState.Values
                     .SelectMany(v => v.Errors)
                     .Select(e => e.ErrorMessage));
                return Redirect("/account/category/error/" + errorList);
            }
            _dbContext.Categories.Remove(model);
            _dbContext.SaveChanges();
            return Redirect("/account/category");

        }

        [HttpGet("register")]
        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAction(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User()
                {
                    Email = model.Email,
                    UserName = model.Username
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                var getResult = await _userManager.FindByNameAsync(model.Username);

                //await _userManager.AddToRoleAsync(user, "User");

                if (result.Succeeded)
                {
                    return View("Index", new HomeViewModel()
                    {
                        Title = "Success",
                        whatever = getResult,
                    });
                }
                else
                {
                    return View("Index", new HomeViewModel()
                    {
                        Title = "Failure",
                        whatever = result.Errors,
                    });
                }
            }
            else
            {
                return View("Index", new HomeViewModel()
                {
                    Title = "Invalid model",
                    whatever = ModelState.Values
                });
            }
        }

        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAction(LoginViewModel model, [FromQuery] string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var getUserResult = await _userManager.FindByEmailAsync(model.Email);
                if(getUserResult == null)
                {
                    return View("Index", new HomeViewModel
                    {
                        Title = "User not found",
                        whatever = ModelState.Values
                    });
                }
                //Console.(getUserResult.Discriminator);
                var signInResult = await _signInManager.PasswordSignInAsync(getUserResult.UserName, model.Password, false, false);
                if (signInResult.Succeeded)
                {
                    if (string.IsNullOrWhiteSpace(returnUrl))
                    {
                        return View("Index");
                    }
                    else
                    {
                        return Redirect(returnUrl);
                    }
                }
                else
                {
                    return View("Login", new LoginViewModel()
                    {
                        Email = model.Email
                    });
                }
            }
            else
            {
                return View("Error", new HomeViewModel
                {
                    Title = "Invalid login or password",
                    whatever = ModelState.Values
                });
            }
        }

        public async Task<IActionResult> Logout()
        {
            try
            {
                await _signInManager.SignOutAsync();
                return View("Index", new HomeViewModel
                {
                    Title = "Successfully logged out!"
                });

            }
            catch (Exception e)
            {
                return View("Index", new HomeViewModel
                {
                    Title = "An unexpected error occured while trying to logout!",
                    whatever = e
                });
            }

        }
    }
}