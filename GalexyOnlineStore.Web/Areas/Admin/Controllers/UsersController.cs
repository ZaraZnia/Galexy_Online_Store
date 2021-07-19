using GalexyOnlineStore.Application.Services.Users.Queries.GetUsers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalexyOnlineStore.Web.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        private readonly IGetUsersService _GetUsersService;

        public UsersController(IGetUsersService getUsersService)
        {
            _GetUsersService = getUsersService;
        }

        [Area("Admin")]
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
    }
}
