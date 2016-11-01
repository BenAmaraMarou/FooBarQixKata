using NUnit.Framework;

namespace FooBarQixKata
{
    public class FooBarQixTests
    {
        [Test]
        public void Should_Return_Itself_When_Number_Is_Not_Multiple_Of_3_Or_5_Or_7()
        {
            //Arrange
            var fooBarQix = new FooBarQix();
            var input = 1;
            var expected = "1";

            //Act
            var actual = fooBarQix.Process(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_FooFoo_When_Number_Is_Multiple_Of_3_And_Contains_3()
        {
            //Arrange
            var fooBarQix = new FooBarQix();
            var input = 3;
            var expected = "FooFoo";

            //Act
            var actual = fooBarQix.Process(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_BarBar_When_Number_Is_Multiple_Of_5_And_Contains_5()
        {
            //Arrange
            var fooBarQix = new FooBarQix();
            var input = 5;
            var expected = "BarBar";

            //Act
            var actual = fooBarQix.Process(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_QixQix_When_Number_Is_Multiple_Of_7_And_Contains_7()
        {
            //Arrange
            var fooBarQix = new FooBarQix();
            var input = 7;
            var expected = "QixQix";

            //Act
            var actual = fooBarQix.Process(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_FooBarBar_When_Number_Is_Multiple_Of_3_And_5_And_Contains_5()
        {
            //Arrange
            var fooBarQix = new FooBarQix();
            var input = 15;
            var expected = "FooBarBar";

            //Act
            var actual = fooBarQix.Process(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
