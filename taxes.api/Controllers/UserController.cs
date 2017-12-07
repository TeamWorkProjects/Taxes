using Microsoft.AspNetCore.Mvc;
using taxes.services.Context;

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

    }
}