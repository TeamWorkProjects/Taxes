using taxes.services.Context;
using Microsoft.AspNetCore.Mvc;
using taxes.services.Models;
using taxes.services.Repository;
using taxes.api.Models.ViewModels;
using taxes.services.Security;


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
        public User AddUser(UserViewModel newUSer)
        {
            if(ModelState.IsValid)
            {
                PasswordHasher hasher = new PasswordHasher();
                User entity = new User{ Email = newUSer.Email,
                                        Password = hasher.GenerateHash(newUSer.Password),
                                        Salt=hasher.Salt};
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

        [HttpPost]
        public ActionResult RemoveUSer(object id)
        {
            unitOfWork.UserRepository.Delete(id);
            return View();
        }
    }


}