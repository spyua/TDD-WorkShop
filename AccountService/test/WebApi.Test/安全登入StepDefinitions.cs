using System;
using TechTalk.SpecFlow;

namespace WebApi.Test
{
    [Binding]
    public class 安全登入StepDefinitions
    {
        [Given(@"一個有效的帳號和密碼")]
        public void Given一個有效的帳號和密碼()
        {
            throw new PendingStepException();
        }

        [When(@"用戶嘗試登入")]
        public void When用戶嘗試登入()
        {
            throw new PendingStepException();
        }

        [Then(@"登入應成功")]
        public void Then登入應成功()
        {
            throw new PendingStepException();
        }

        [Given(@"一個無效的帳號或密碼")]
        public void Given一個無效的帳號或密碼()
        {
            throw new PendingStepException();
        }

        [Then(@"登入應失敗")]
        public void Then登入應失敗()
        {
            throw new PendingStepException();
        }

        [Given(@"用戶已經嘗試登入兩次並失敗")]
        public void Given用戶已經嘗試登入兩次並失敗()
        {
            throw new PendingStepException();
        }

        [When(@"用戶再次嘗試登入並失敗")]
        public void When用戶再次嘗試登入並失敗()
        {
            throw new PendingStepException();
        }

        [Then(@"帳戶應被鎖定")]
        public void Then帳戶應被鎖定()
        {
            throw new PendingStepException();
        }
    }
}
