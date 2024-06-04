using ELearning.DomainModels.User;
using ELearning.Web.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Data;
using ELearning.Web.AppCodes;

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
                var user = await _userManager.FindByEmailAsync(model.Email);
                await _userManager.UpdateSecurityStampAsync(user);
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Invalid email or password");
                }

                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    _logger.LogInformation($"roles : {roles[0].ToString()}");
                    if (roles.Contains("Admin"))
                    {
                        List<Claim> claims = new List<Claim>()
                        {
                            new Claim(nameof(user.Id), user.Id.ToString() ?? ""),
                            new Claim(nameof(user.UserName), user.UserName ?? ""),
                            new Claim(nameof(user.FullName), user.FullName ?? ""),
                            new Claim(nameof(user.Email), user.Email ?? ""),
                            new Claim(nameof(user.ProfilePicture), user.ProfilePicture ?? ""),
                            new Claim(ClaimTypes.Role, "Admin")
                        };

                        var identity = new ClaimsIdentity(claims, "StudentInstructorLogin");
                        var principal = new ClaimsPrincipal(identity);
                        await HttpContext.SignInAsync("StudentInstructorLogin", principal);

                        return RedirectToAction("Index", "Home", new { area = "Admin" });
                    }
                    else
                    {
                        List<Claim> claims = new List<Claim>()
                        {
                            new Claim(nameof(user.Id), user.Id.ToString() ?? ""),
                            new Claim(nameof(user.UserName), user.UserName ?? ""),
                            new Claim(nameof(user.FullName), user.FullName ?? ""),
                            new Claim(nameof(user.Email), user.Email ?? ""),
                            new Claim(nameof(user.ProfilePicture), user.ProfilePicture ?? ""),
                            new Claim(ClaimTypes.Role, model.IsInstructor==true && roles.Contains("Instructor") ? "Instructor" : "Student")
                        };


                        var identity = new ClaimsIdentity(claims, "StudentInstructorLogin");
                        var principal = new ClaimsPrincipal(identity);

                        await HttpContext.SignInAsync("StudentInstructorLogin", principal);

                        // Redirect based on the user's role
                        if (model.IsInstructor == true && roles.Contains("Instructor"))
                        {
                            return RedirectToAction("Index", "Home", new { area = "Instructor" });
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                       
                    
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
                await HttpContext.SignOutAsync("StudentInstructorLogin");
                var user = await _userManager.FindByEmailAsync(model.Email);
                await _userManager.UpdateSecurityStampAsync(user);
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Invalid email or password");
                }


                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    
                    _logger.LogInformation($"roles : {roles[0].ToString()}");
                    if (roles.Contains("Admin"))
                    {
                        List<Claim> claims = new List<Claim>()
                        {
                            new Claim(nameof(user.Id), user.Id.ToString() ?? ""),
                            new Claim(nameof(user.UserName), user.UserName ?? ""),
                            new Claim(nameof(user.FullName), user.FullName ?? ""),
                            new Claim(nameof(user.Email), user.Email ?? ""),
                            new Claim(nameof(user.ProfilePicture), user.ProfilePicture ?? ""),
                            new Claim(ClaimTypes.Role, "Admin")
                        };

                        var identity = new ClaimsIdentity(claims, "StudentInstructorLogin");
                        var principal = new ClaimsPrincipal(identity);
                        await HttpContext.SignInAsync("StudentInstructorLogin", principal);
                        
                        return RedirectToAction("Index", "Home", new { area = "Admin" });
                    }
                }
            }

            return View("AdminLogin");
        }




        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();
            if (HttpContext.User.HasClaim(ClaimTypes.Role, "Admin"))
            {
                await HttpContext.SignOutAsync("AdminLogin");
            }
            else
            {
                await HttpContext.SignOutAsync("StudentInstructorLogin");
            }

            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
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
                    Email = model.Email,
                    FullName = model.FullName,
                };

                

                // Store user data in AspNetUsers database table
                var result = await _userManager.CreateAsync(user, model.Password);
                
                // If user is successfully created, sign-in the user using
                // SignInManager and redirect to index action of HomeController
                if (result.Succeeded)
                {
                    if (model.IsInstructor == true)
                    {
                        await _userManager.AddToRoleAsync(user, "Instructor");
                    }
                    else
                    {
                        await _userManager.AddToRoleAsync(user, "Student");
                    }
                    return RedirectToAction("Login", "Account");
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
