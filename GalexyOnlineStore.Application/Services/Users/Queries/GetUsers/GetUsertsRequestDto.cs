namespace GalexyOnlineStore.Application.Services.Users.Queries.GetUsers
{
    public class GetUsertsRequestDto
    {
        public string SearchKey { get; set; }

        public int Page { get; set; } = 1;
    }
}
