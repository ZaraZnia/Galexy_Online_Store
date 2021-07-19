using GalexyOnlineStore.Application.Interface.Contexts;
using GalexyOnlineStore.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GalexyOnlineStore.Application.Services.Users.Queries.GetUsers
{
    public class GetUsersService : IGetUsersService
    {
        private readonly IDatabaseContext context;

        public GetUsersService(IDatabaseContext databaseContext)
        {
            context = databaseContext;
        }

        public GetUsersResultDto Execute(GetUsertsRequestDto request)
        {
            var users = context.Users.AsQueryable();

            if (!string.IsNullOrEmpty(request.SearchKey) && !string.IsNullOrWhiteSpace(request.SearchKey))
            {
                users = users.Where(u => u.Name.Contains(request.SearchKey));
            }

            int rowCnt = 0;
            var getUsers = users.ToPaged(request.Page, 10, out rowCnt).Select(u => new GetUsersDto
            {
                Id = u.Id,
                Name = u.Name,
                Email = u.Email
            });

            GetUsersResultDto usersResultDto = new GetUsersResultDto { Users = getUsers, UsersRowCount = getUsers.Count() };
            
            return usersResultDto;
        }
    }
}
