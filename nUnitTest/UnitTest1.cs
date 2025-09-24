namespace nUnitTest
{
    public class Tests
    {
        //NUnit Attributes
        /*
        [TestFixture]�G�аO���O�����ե�
        [Test]�G�аO��k���椸����
        [SetUp]�G�C�Ӵ��իe����
        [TearDown]�G�C�Ӵ��ի����
        [OneTimeSetUp]�G�������O����e����@��
        [OneTimeTearDown]�G�������O���������@��
        [TestCase(x, y)]�G���ѰѼƤƴ���
        [Ignore]�G����������
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