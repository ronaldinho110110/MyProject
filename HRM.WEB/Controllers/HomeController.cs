using HRM.DAL;
using System.Web.Mvc;
using HRM.Web.ViewModel;
using AutoMapper;
using HRM.DAL.Models;

namespace HRM.Web.Controllers
{
    public partial class HomeController : Controller
    {
        // GET: Home
        private readonly IUserRepository _userRepository;
        public HomeController(
             IUserRepository userRepository)
        {
           this._userRepository = userRepository;
            
        }      
        [HttpGet]
        [Authorize(Roles = Roles.User)]
        public ActionResult ChangeProfile()
        {
            UserVM userVM = Mapper.Map<UserVM>(_userRepository.GetByEmail(User.Identity.Name));
            userVM.Password = "";
            return View(userVM);
        }
        [HttpPost]
        public ActionResult ChangeProfile(UserVM userVM)
        {
            User userBase = _userRepository.GetByEmail(userVM.Email);
            if (!ValidateChangeData(userVM, userBase))
            {
                userVM.Message = "Something wrong, Your changes were not saved!";
                return View(userVM);
            }

            userBase.FullName = userVM.FullName;
            userBase.Email = userVM.Email;
            if ((userVM.Password == userBase.Password) && (userVM.NewPassword == userVM.ConfirmNewPassword))
            {
                userBase.Password = userVM.NewPassword;
            }
            _userRepository.UnitOfWork.SaveChanges();
            userVM.Message = "Your changes were successfully saved!";
            return View(userVM);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contacts()
        {
            return View();
        }
    }
}