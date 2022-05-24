using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tablet_blazor.Models;

namespace tablet_blazor.Services
{
    interface IUserLogin
    {
        public Task<LoginResult> Login(User user);
        public Task<IEnumerable<string>> GetUsers();
    }
}
