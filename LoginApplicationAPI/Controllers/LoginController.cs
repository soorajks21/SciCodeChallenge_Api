using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginApplicationAPI.Model;
using LoginApplicationAPI.Store;

namespace LoginApplicationAPI.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public bool Post(User user)
        {
            UserStore userStore = new UserStore();
            return userStore.login(user.UserName, user.Password);
        }
    }
}