using System.Collections.Generic;

namespace GalexyOnlineStore.Application.Services.Users.Queries.GetUsers
{
    public class GetUsersResultDto
    {
        public IEnumerable<GetUsersDto> Users { get; set; }

        public int UsersRowCount { get; set; }
    }
}
