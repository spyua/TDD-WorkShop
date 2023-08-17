namespace WebApi
{
    public interface IUserRepoitory
    {
        User GetUser(string username);
    }
}