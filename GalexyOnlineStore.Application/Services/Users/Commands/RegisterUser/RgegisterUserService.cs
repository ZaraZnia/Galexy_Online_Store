using GalexyOnlineStore.Application.Interface.Contexts;
using GalexyOnlineStore.Common.Dto;
using GalexyOnlineStore.Domain.Entities.Users;
using System.Collections.Generic;

namespace GalexyOnlineStore.Application.Services.Users.Commands.RegisterUser
{
    public class RgegisterUserService : IRegisterUserService
    {
        private readonly IDatabaseContext _context;

        public RgegisterUserService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultRegisterUserDto> Execute(RequestRegisterUserDto request)
        {
            User user = new User()
            {
                Email = request.Email,
                Name = request.FullName,
                Password = request.Password
            };
            List<UserInRole> userInRoles = new List<UserInRole>();

            foreach (var item in request.roles)
            {
                var roles = _context.Roles.Find(item.Id);
                userInRoles.Add(new UserInRole
                {
                    Role = roles,
                    RoleId = roles.Id,
                    User = user,
                    UserId = user.Id,
                });
            }
            user.UserInRoles = userInRoles;

            _context.Users.Add(user);
            _context.SaveChanges();

            return new ResultDto<ResultRegisterUserDto>()
            {
                Data = new ResultRegisterUserDto()
                {
                    UserId = user.Id,

                },
                IsSuccess = true,
                Message = "Successful Registration.",
            };
        }
    }
}
