namespace WebApi
{
    public class LoginService
    {
        private int _failedLoginAttempts = 0;
        private bool _isAccountLocked = false;

        public bool IsAccountLocked(string v)
        {
            return _isAccountLocked; // 返回帳戶是否被鎖定
        }

        public bool TryLogin(string username, string password)
        {
            if (_isAccountLocked)
            {
                return false; // 帳戶被鎖定
            }

            if (username == "validUser" && password == "validPassword")
            {
                _failedLoginAttempts = 0; // 重置失敗登入計數
                return true; // 登入成功
            }
            else
            {
                _failedLoginAttempts++;

                if (_failedLoginAttempts >= 3)
                {
                    _isAccountLocked = true; // 鎖定帳戶
                }

                return false; // 登入失敗
            }
        }
    }
}