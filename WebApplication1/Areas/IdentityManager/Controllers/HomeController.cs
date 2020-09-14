using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityManagerUI.Areas.IdentityManager.Controllers;
using IdentityManagerUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Areas.IdentityManager.Controllers
{
	[Area("IdentityManager")]
	public class HomeController : HomeController<ApplicationUser>
	{
		public HomeController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, ILogger<HomeController> logger) : base(userManager, roleManager, logger) { }
	}
}
