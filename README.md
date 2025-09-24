# 單元測試 UnitTest

## 3A 原則：

#### Arrange：安排／準備

在這一步你準備所有測試要用到的東西。包括被測試物件 (SUT, System Under Test)、依賴（例如模擬物件 mock、stub）、輸入參數、預期結果，設定測試環境或上下文等等。

#### Act：執行／行動

在這一步調用你的程式碼中要測試的方法或函式，做實際的操作。就是把輸入傳進去，讓它執行。

#### Assert：斷言／驗證

最後檢查操作結果是否如你預期的那樣。把實際結果和預期結果比較，有沒有錯誤。這部份可以用測試框架提供的 assert 函數或方法。

# Unit Test Framework

社群用量比較xUnit > NUnit > MSTest，其中xUnit具備高靈活性與現代特性，更易與持續整合（CI/CD）工具整合。

## xUnit

#### 字串比較

Assert.Equal (Assert.NotEqual)：比較是否(不)相符
Assert.Contains (Assert.NotContains)：比較字串1是否(不)存在在字串2

#### 布林比較

Assert.True：比較結果是否為true
Assert.False：比較結果是否為false

#### Null Reference 比較

Assert.Null (Assert.NotNull)：比較物件是否(不)為null

#### 物件比較

Assert.Same (Assert.NotSame)：比較兩物件是否(不)相同

#### 數值比較

Assert.InRange (Assert.NotInRange：比較數值是否(不)在範圍中