using WebApi.Persistence;

namespace WebApi
{
    public class LoginService
    {
        private readonly IUserRepoitory _userRepository;
        private readonly Dictionary<string, int> _failedAttempts;

        public LoginService(IUserRepoitory userRepository)
        {
            _userRepository = userRepository;
            _failedAttempts = new Dictionary<string, int>();
        }

        public bool Login(string username, string password)
        {
            if (_failedAttempts.ContainsKey(username) && _failedAttempts[username] >= 3)
                return false;

            User user = _userRepository.GetUser(username);

            if (InvalidPassword(password, user))
            {

                if (!_failedAttempts.ContainsKey(username))
                {
                    _failedAttempts.Add(username, 1);
                    return false;
                }

                _failedAttempts[username]++;
                return false;
            }

            _failedAttempts.Remove(username);
            return true;
        }

        public bool IsLocked(string username)
        {
            return _failedAttempts.ContainsKey(username) && _failedAttempts[username] >= 3;
        }   
        private static bool InvalidPassword(string password, User user)
        {
            return user == null || !user.Password.Equals(password);
        }
    }
}