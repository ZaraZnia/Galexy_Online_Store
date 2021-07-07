using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GalexyOnlineStore.Application.Services.Users.Queries.GetUsers
{
    public interface IGetUsersService
    {
        List<GetUsersDto> Execute(GetUsertsRequestDto request);
        
    }
}
