Feature: 安全登入

Scenario: 正確的帳號和密碼
    Given 一個有效的帳號和密碼
    When 用戶嘗試登入
    Then 登入應成功

Scenario: 錯誤的帳號或密碼
    Given 一個無效的帳號或密碼
    When 用戶嘗試登入
    Then 登入應失敗

Scenario: 兩次登入失敗
    Given 用戶已經嘗試登入兩次並失敗
    When 用戶再次嘗試登入並失敗
    Then 帳戶應被鎖定
