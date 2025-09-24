namespace xUnitTest
{
    public class UnitTest1
    {
        //Attribute
        //Fact�G�N���a�Ѽƪ����դ�k
        //Theory�G�N��a�Ѽƪ����դ�k

        //Assert��ܲM��GEqual�BTrue�BNull�BSame�B�B�B�B�B

        /// <summary>
        /// ����r��
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
        /// ����ƭ�
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
        /// ������L
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
        /// �P�_����Null Reference
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
        /// �P�_����O�_�@��
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
        /// �P�_�ƭȬO�_�b�d��
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