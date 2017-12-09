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
            if( entity != null)
            {
                dbContext.Users.Add(entity);
                return entity;
            }
            return null;
        }
    }
}