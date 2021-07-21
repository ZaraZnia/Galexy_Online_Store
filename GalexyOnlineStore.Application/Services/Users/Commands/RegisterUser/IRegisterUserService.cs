using GalexyOnlineStore.Common.Dto;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalexyOnlineStore.Application.Services.Users.Commands.RegisterUser
{
    public interface IRegisterUserService
    {
        ResultDto<ResultRegisterUserDto> Execute(RequestRegisterUserDto request);
    }

    public class RolesInRgegisterUserDto
    {
        public long Id { get; set; }
    }

    public class ResultRegisterUserDto : ResultDto
    {
        public long UserId { get; set; }

    }
}
