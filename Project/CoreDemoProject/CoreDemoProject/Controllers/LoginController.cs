using CoreDemoProject.Models;
using DataAccessLayer.Contexts;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemoProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "DashBoard");
                }
                else
                    return RedirectToAction("Index", "Login");
            }

            return View(p);
        }



        //      [HttpPost]
        //public async Task<IActionResult> Index(Writer writer)
        //{
        //          MyAppDbContext context = new MyAppDbContext();
        //          var datavalue = context.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);

        //          if(datavalue != null)
        //          {
        //              var claims = new List<Claim>
        //              {
        //			new Claim(ClaimTypes.Name, writer.WriterMail)
        //		};
        //              var userIdentity = new ClaimsIdentity(claims, "a");
        //              ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
        //              await HttpContext.SignInAsync(principal);
        //              return RedirectToAction("Index", "DashBoard");
        //          }
        //          else
        //          {
        //              return View();
        //          }



        //}
    }
}


/*
   MyAppDbContext context = new MyAppDbContext();
            var writerUserInfo = context.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);

            if(writerUserInfo != null)
            {
				HttpContext.Session.SetString("username", writer.WriterMail);
				return RedirectToAction("Index", "Writer");
			}
			


			return View();
 
 
 */
