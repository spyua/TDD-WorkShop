using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace WebApi.Test
{
    [Binding]
    public class 安全登入StepDefinitions
    {
        private LoginService _loginService; // 假設有一個登入服務
        private string _username;
        private string _password;
        private bool _loginResult;

        public 安全登入StepDefinitions()
        {
            _loginService = new LoginService(); // 初始化登入服務
        }

        [Given(@"一個有效的帳號和密碼")]
        public void Given一個有效的帳號和密碼()
        {
            _username = "validUser";
            _password = "validPassword";
        }

        [When(@"用戶嘗試登入")]
        public void When用戶嘗試登入()
        {
            _loginResult = _loginService.TryLogin(_username, _password);
        }

        [Then(@"登入應成功")]
        public void Then登入應成功()
        {
            _loginResult.Should().BeTrue();
        }

        [Given(@"一個無效的帳號或密碼")]
        public void Given一個無效的帳號或密碼()
        {
            _username = "invalidUser";
            _password = "invalidPassword";
        }

        [Then(@"登入應失敗")]
        public void Then登入應失敗()
        {
            _loginResult.Should().BeFalse();
        }

        [Given(@"用戶已經嘗試登入兩次並失敗")]
        public void Given用戶已經嘗試登入兩次並失敗()
        {
            _loginService.TryLogin("user", "wrongPassword");
            _loginService.TryLogin("user", "wrongPassword");
        }

        [When(@"用戶再次嘗試登入並失敗")]
        public void When用戶再次嘗試登入並失敗()
        {
            _loginResult = _loginService.TryLogin("user", "wrongPassword");
        }

        [Then(@"帳戶應被鎖定")]
        public void Then帳戶應被鎖定()
        {
            _loginService.IsAccountLocked("user").Should().BeTrue();
        }
    }
}
