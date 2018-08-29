using MarcStore.Models;
using MarcStore.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace MarcStore.Controllers
{

    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]

        public IActionResult Register(bool ItIframe = false)
        {
            if (User.Identity.IsAuthenticated)
            {
                return NotFound();
            }
            ViewBag.ItIframe = (bool)ItIframe;
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Register(RegisterModel model, bool ItIframe = false)
        {
            if (User.Identity.IsAuthenticated)
            {
                return NotFound();
            }
            ViewBag.ItIframe = (bool)ItIframe;
            if (ModelState.IsValid)
            {
                User user = new User { Email = model.Email, UserName = model.Email, Year = model.Year };
                // добавляем пользователя
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    // установка куки
                    await _signInManager.SignInAsync(user, false);
                    if (ItIframe)
                        return RedirectToAction("Successfully");
                    return RedirectToAction("List", "Product");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Login(string returnUrl = null, bool ItIframe = false)
        {
            ViewBag.ItIframe = (bool)ItIframe;
            return View(new LoginModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model, bool ItIframe = false)
        {
            if (ModelState.IsValid)
            {
                var result =
                    await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    // проверяем, принадлежит ли URL приложению
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        if (ItIframe)
                            return RedirectToAction("Successfully", "Account");
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        if (ItIframe)
                            return RedirectToAction("Successfully", "Account");
                        return RedirectToAction("List", "Product");

                    }

                }
                else
                {
                    ModelState.AddModelError("", "Incorrect login and / or password");
                }
            }
            ViewBag.ItIframe = (bool)ItIframe;
            return View(model);
        }
        [HttpGet]
        public ViewResult Successfully() => View();
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOff()
        {
            // удаляем аутентификационные куки
            await _signInManager.SignOutAsync();

            return RedirectToAction("List", "Product");
        }
    }
}
