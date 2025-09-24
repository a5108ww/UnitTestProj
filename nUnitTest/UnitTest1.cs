namespace nUnitTest
{
    public class Tests
    {
        //NUnit Attributes
        /*
        [TestFixture]：標記類別為測試用
        [Test]：標記方法為單元測試
        [SetUp]：每個測試前執行
        [TearDown]：每個測試後執行
        [OneTimeSetUp]：測試類別執行前執行一次
        [OneTimeTearDown]：測試類別結束後執行一次
        [TestCase(x, y)]：提供參數化測試
        [Ignore]：忽略此測試
         */

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("hel", "lo", "hello")]
        public void EqualTest(string s1, string s2, string expect)
        {
            Assert.AreEqual(expect, s1 + s2);
            //Assert.Pass();
        }

        [Test]
        [TestCase(2, 3, 5)]
        public void BooleanTest(int n1,int n2,int expect)
        {
            int n = n1 + n2;

            Assert.IsTrue(n == expect);
            //Assert.IsFalse();
        }

        [Test]
        public void NullTest()
        {
            object obj = new { };
            Assert.IsNull(obj);
        }

        [Test]
        [TestCase(2, 3, 5)]
        public void ThatTest1(int n1, int n2, int expect)
        {
            int n = n1 + n2;
            Assert.That(expect, Is.EqualTo(n));
        }

        [Test]
        [TestCase(2, 3, 5)]
        public void ThatTest2(int n1, int n2, int expect)
        {
            int n = n1 + n2;
            Assert.That("hello", Does.StartWith("he"));
        }

        [Test]
        [TestCase("")]
        public void ThatTest3(string s1)
        {
            Assert.That(() => SomeFunction(s1), Throws.TypeOf<Exception>());
        }

        private int SomeFunction(string s1)
        {
            int n = Convert.ToInt32(s1);
            return n;
        }

        [Test]
        public void ThrowsTest()
        {
            Assert.Throws<Exception>(() => Convert.ToInt32(""));
        }
    }
}