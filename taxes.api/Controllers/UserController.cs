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
        public ViewResult AddUser(UserViewModel newUSer)
        {
            if(ModelState.IsValid)
            {
                PasswordHasher hasher = new PasswordHasher();
                User entity = new User{ Email = newUSer.Email,
                                        Password = hasher.GenerateHash(newUSer.Password),
                                        Salt=hasher.Salt};
                unitOfWork.UserRepository.Create(entity);
                return View(viewName: "AddUserSuccess");
            }
            return View();
        }

        [HttpGet]
        public ActionResult RemoveUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RemoveUser(object id)
        {
            unitOfWork.UserRepository.Delete(id);
            return View();
        }
    }


}