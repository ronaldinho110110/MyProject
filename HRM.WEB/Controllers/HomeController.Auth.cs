using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Security.Claims;
using System.Web.Mvc;
using AutoMapper;
using HRM.Web;
using HRM.DAL.Models;
using HRM.Web.Manager;
using HRM.Web.ViewModel;
using HRM.DAL;

namespace HRM.Web.Controllers
{
	public partial class HomeController
	{
		public ActionResult Index()
		{
			if (User.Identity.IsAuthenticated)
				if (User.IsInRole(Roles.User))
					return RedirectToAction(MVCManager.Controller.Main.Albums, MVCManager.Controller.Main.Name);
				else 
					return View("NotActivated");
			return View();

		}

		[HttpPost]
		public ActionResult Index(UserCredentialsVM userCredentialsVM)
		{
			if (!ValidateCredentials(userCredentialsVM))
				return View();
			User user = _userRepository.GetByCredentials(userCredentialsVM.Email, userCredentialsVM.Password);
			if (user == null)
			{
				ModelState.AddModelError("credentials", "Invalid username or password");
				return View();
			}
			SessionManager.CurentUserContext = Mapper.Map<User, UserContext>(user);
			List<Claim> claims = new List<Claim>();
			claims.Add(new Claim(ClaimTypes.Name, user.Email));
			if (SessionManager.CurentUserContext.Role == 2)
				claims.Add(new Claim(ClaimTypes.Role, Roles.TeamLead));
			if (SessionManager.CurentUserContext.Role == 1)
				claims.Add(new Claim(ClaimTypes.Role, Roles.User));
			if (SessionManager.CurentUserContext.Role == 3)
				claims.Add(new Claim(ClaimTypes.Role, Roles.HR));
			var identity = new ClaimsIdentity(claims.ToArray<Claim>(), DefaultAuthenticationTypes.ApplicationCookie);
			HttpContext.GetOwinContext().Authentication.SignIn(new AuthenticationProperties { IsPersistent = userCredentialsVM.RememberMe }, identity);
			return RedirectToAction(MVCManager.Controller.Home.Index);
		}
		[Authorize]
		public ActionResult Logout()
		{
			HttpContext.GetOwinContext().Authentication.SignOut();
			return RedirectToAction(MVCManager.Controller.Home.Index);
		}
	}
}