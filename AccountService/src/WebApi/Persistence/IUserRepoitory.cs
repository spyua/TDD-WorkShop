namespace WebApi.Persistence
{
    public interface IUserRepoitory
    {
        User GetUser(string username);
    }
}