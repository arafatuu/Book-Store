using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle_BookStore.Models;
using WebGentle_BookStore.Repository;

namespace WebGentle_BookStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accrepo;
        public AccountController(IAccountRepository accrepo)
        { _accrepo = accrepo;
        }
        [Route("Signup")]

        public IActionResult Signup()
        {
            return View();
        }


        [Route("Signup")]
        [HttpPost]

        public async Task<IActionResult> Signup(SignupUserModel model)
        {
            if(ModelState.IsValid)
            {
                var result = await _accrepo.CreateUserAsync(model);
                if(!result.Succeeded)
                {
                    foreach(var errormessage in result.Errors)
                    {
                        ModelState.AddModelError("", errormessage.Description);
                    }
                    return View();
                }

                ModelState.Clear();
            }
            return View();
        }
    }
}
