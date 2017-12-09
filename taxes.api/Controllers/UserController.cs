using taxes.services.Context;
using Microsoft.AspNetCore.Mvc;
using taxes.services.Models;

namespace taxes.api.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public UserController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("Add")]
        public User AddUser(User entity)
        {
            if(ModelState.IsValid)
            {
                dbContext.Users.Add(entity);
                return entity;
            }
            return null;
        }

        public User DeleteUser(User entity)
        {
            if(ModelState.IsValid)
            {
                dbContext.Users.Remove(entity);
                return entity;
            }
            return null;
        }
    }
}