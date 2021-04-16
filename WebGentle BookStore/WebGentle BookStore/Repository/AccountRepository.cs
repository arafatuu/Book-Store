using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle_BookStore.Models;

namespace WebGentle_BookStore.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<IdentityUser> _usermanager;
        public AccountRepository(UserManager<IdentityUser> usermanager)
        {
            _usermanager = usermanager;
        }

        public async Task<IdentityResult> CreateUserAsync(SignupUserModel model)
        {
            var user = new IdentityUser()
            {
                Email = model.Email,
                UserName = model.Email
            };

            var result = await _usermanager.CreateAsync(user, model.Password);
            return result;
        }
    }
}
