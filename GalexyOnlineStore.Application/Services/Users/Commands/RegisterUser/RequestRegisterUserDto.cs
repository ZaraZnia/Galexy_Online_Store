using System.Collections.Generic;

namespace GalexyOnlineStore.Application.Services.Users.Commands.RegisterUser
{
    public class RequestRegisterUserDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public List<RolesInRgegisterUserDto> roles { get; set; }
    }
}
