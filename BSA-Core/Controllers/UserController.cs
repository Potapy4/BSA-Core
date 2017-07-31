using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BSACore.Models.Context;
using BSACore.Models.RandomUser;
using BSACore.Services.Interfaces;
using BSACore.Services.Concrete;

namespace BSA_Core.Controllers
{    
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private IRandomUserProvider provider;
        private DBService db;

        public UserController(LogContext context, IRandomUserProvider provider)
        {           
            db = new DBService(context); // DI
            this.provider = provider;
        }

        // GET api/user
        [HttpGet]
        public async Task<UserData> Get()
        {            
            await db.LogInDB(new Log()
            {
                LogTime = DateTime.Now,
                CalledAction = ControllerContext.ActionDescriptor.ActionName
            });
            
            return await provider.GetRandomUser();
        }
    }
}
