using ELearning.DomainModels.User;
using ELearning.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ELearning.Web.Controllers
{
    public class AccountController : Controller
    {
        //userManager will hold the UserManager instance
        private readonly UserManager<ApplicationUser> _userManager;
        //signInManager will hold the SignInManager instance
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<AccountController> _logger;
        //Both UserManager and SignInManager services are injected into the AccountController
        //using constructor injection
        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<AccountController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                //return RedirectToAction("Index", "Home", new { area = "Student" });
                var user = await _userManager.FindByEmailAsync(model.Email);
                await _userManager.UpdateSecurityStampAsync(user);
                if (user != null)
                {

                    var roles = await _userManager.GetRolesAsync(user);

                    if (model.IsInstructor == false && roles.Contains("Student"))
                    {
                        var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, false, lockoutOnFailure: true);
                        if (result.Succeeded)
                        {

                            return RedirectToAction("Index", "Home", new { area = "Student" });

                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
                        }
                    }
                    if (model.IsInstructor == true && roles.Contains("Instructor"))
                    {
                        var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, false, lockoutOnFailure: true);
                        if (result.Succeeded)
                        {

                            return RedirectToAction("Index", "Home", new { area = "Instructor" });
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password");
                }
            }



            return View();
            
        }

        [HttpGet]
        public async Task<IActionResult> AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdminLogin(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                await _userManager.UpdateSecurityStampAsync(user);
                if (user != null)
                {

                    var roles = await _userManager.GetRolesAsync(user);

                    if (roles.Contains("Admin"))
                    {
                        var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, false, lockoutOnFailure: true);
                        if (result.Succeeded)
                        {

                            return RedirectToAction("Index", "Home", new { area = "Admin" });

                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
                        }
                    } else
                    {
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password");
                }
            }



            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Copy data from RegisterViewModel to IdentityUser
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    FullName = model.FullName,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    BirthDate = DateTime.Now,
                    Gender = Gender.Male
                };
                // Store user data in AspNetUsers database table
                var result = await _userManager.CreateAsync(user, model.Password);
                // If user is successfully created, sign-in the user using
                // SignInManager and redirect to index action of HomeController
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }
                // If there are any errors, add them to the ModelState object
                // which will be displayed by the validation summary tag helper
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }
    }
}
