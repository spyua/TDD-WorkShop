namespace WebApi
{
    public class LoginService
    {
        private IUserRepoitory _userRepoitory;

        public LoginService(IUserRepoitory userRepoitory)
        {
            _userRepoitory = userRepoitory;
        }

        public bool Login(string username, string password)
        {
            User user = _userRepoitory.GetUser(username);

            if (InvalidPassword(password, user))
            {
                return false;
            }

            return true;
        }

        private static bool InvalidPassword(string password, User user)
        {
            return user == null || !user.Password.Equals(password);
        }
    }
}