namespace xUnitTest
{
    public class UnitTest1
    {
        //Attribute
        //Factぃ盿把计代刚よ猭
        //Theory盿把计代刚よ猭

        //Assertㄧボ睲虫EqualTrueNullSame

        /// <summary>
        /// ゑ耕﹃
        /// </summary>
        [Fact]
        public void EqualTest()
        {
            // Arrange
            int a = 2, b = 3;

            // Act
            int result = a + b;

            // Assert
            Assert.Equal(5, result);
        }

        /// <summary>
        /// ゑ耕计
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <param name="expectNum"></param>
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(1, 1, 2)]
        [InlineData(-1, 1, 0)]
        public void PlusCompare(int n1,int n2,int expectNum)
        {
            int result = n1 + n2;

            Assert.Equal(expectNum, result);
        }

        /// <summary>
        /// ゑ耕ガ狶
        /// </summary>
        [Fact]
        public void BooleanTest()
        {
            // Arrange
            int a = 2, b = 3;

            // Act
            int result = a + b;

            // Assert
            Assert.True(result == 5);

            // Assert
            //Assert.False(result != 5);
        }

        /// <summary>
        /// 耞ンNull Reference
        /// </summary>
        [Fact]
        public void ObjectNullTest()
        {
            // Arrange
            object obj = new { };

            // Assert
            Assert.NotNull(obj);

            // Assert
            //Assert.Null(obj);
        }

        /// <summary>
        /// 耞ン琌妓
        /// </summary>
        [Fact]
        public void SameTest()
        {
            // Arrange
            var obj1 = new object();
            var obj2 = new object();

            // Assert
            Assert.Same(obj1, obj2);

            // Assert
            //Assert.NotSame(obj1, obj2);
        }

        /// <summary>
        /// 耞计琌絛瞅ず
        /// </summary>
        [Fact]
        public void NumberTest()
        {
            // Arrange
            int n = 3;
            int numRange1 = 1,numRange2 = 10;

            // Assert
            Assert.InRange(n, numRange1, numRange2);

            // Assert
            //Assert.NotInRange(obj1, obj2);
        }
    }
}