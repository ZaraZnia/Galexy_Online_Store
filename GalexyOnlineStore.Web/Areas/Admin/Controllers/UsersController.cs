using GalexyOnlineStore.Application.Services.Users.Queries.GetRoles;
using GalexyOnlineStore.Application.Services.Users.Queries.GetUsers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalexyOnlineStore.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly IGetUsersService _GetUsersService;
        private readonly IGetRolesService _getRolesService;

        public UsersController(IGetUsersService getUsersService, IGetRolesService getRolesService)
        {
            _GetUsersService = getUsersService;
            _getRolesService = getRolesService;
        }

        public IActionResult Index(string searchKey, int page)
        {
            var usersResultDto = _GetUsersService.Execute(
                new GetUsertsRequestDto
                {
                    Page = page,
                    SearchKey = searchKey
                });

            return View(usersResultDto);
        }

        [HttpGet]
        public IActionResult Create() {

            ViewBag.Roles = new SelectList(_getRolesService.Execute().Data, "Id", "Name");
            return View();
        }
    }
}
