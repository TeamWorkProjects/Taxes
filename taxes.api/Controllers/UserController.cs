using taxes.services.Context;
using Microsoft.AspNetCore.Mvc;
using taxes.services.Models;
using taxes.services.Repository;

namespace taxes.api.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly UnitOfWork unitOfWork = new UnitOfWork();

        [HttpGet]
        public ActionResult AddUSer()
        {
            return View();
        }

        [HttpPost]
        public User AddUser(User entity)
        {
            if( entity != null)
            {
                unitOfWork.UserRepository.Create(entity);
                return entity;
            }
            return null;
        }

        [HttpGet]
        public ActionResult RemoveUSer()
        {
            return View();
        }
    }
}