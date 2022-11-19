
using DogalGaz.Domain.EntityFramework;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DogalGaz.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        //[AllowAnonymous]
        //public async Task<IActionResult> Login([FromBody] LoginViewModel model, string returnUrl = null)
        //{
        //    await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

        //    ViewData["ReturnUrl"] = returnUrl;
        //    if (ModelState.IsValid)
        //    {
        //        var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, false);
        //        if (result.Succeeded)
        //        {
        //            _logger.LogInformation("User logged in.");
        //            return Ok(true);
        //        }
        //    }

        //    return Ok(false);
        //}

        //------------------------------------------------------------------
        //DogalGazDbContext _db;

        //public AccountController(DogalGazDbContext db)
        //{
        //    _db = db;
        //}

        //[HttpGet]
        //public IActionResult Login()
        //{
        //    return null;
        //}
        //[HttpPost]
        //public async Task<IActionResult> Login(Person person)
        //{
        //    Person loginPerson = _db.Persons.FirstOrDefault(x => x.FirstName == person.FirstName && x.LastName == person.LastName);

        //    if (loginPerson != null)
        //    {
        //        List<Claim> claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name,loginPerson.PersonID.ToString())
        //        };

        //        ClaimsIdentity identity = new ClaimsIdentity(claims, "login");
        //        ClaimsPrincipal principal = new ClaimsPrincipal(identity);
        //        await HttpContext.SignInAsync(principal);

        //        return RedirectToAction("x");
        //    }

        //    ModelState.AddModelError("", "Kullanici adi veya sifre yanlistir");

        //    //return View();
        //}

        //[HttpGet]
        //public async Task<IActionResult> Logout()
        //{
        //    await HttpContext.SignOutAsync();

        //    return ("Login");
        //}



        //[HttpGet]
        //public async Task<IActionResult> Logout()
        //{
        //    await HttpContext.SignOutAsync();

        //    return ("Login");
        //}
    }
}
