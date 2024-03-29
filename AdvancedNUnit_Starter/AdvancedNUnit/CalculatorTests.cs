using NUnit.Framework;

namespace AdvancedNUnit {
    public class CalculatorTests {
        [SetUp]
        public void Setup() {
        }

        [TestCaseSource( nameof( AddCases ) )]
        [Category( "Error Path" )]
        public void Add_Always_ReturnsExpectedResult( int x, int y, int res ) {
            // Arrange
            var subject = new Calculator { Num1 = x, Num2 = y };
            // Act
            var result = subject.Add();
            // Assert
            Assert.That( result, Is.EqualTo( res ), "optional failure message" );
            //Assert.AreEqual( expectedResult, result, "Optional failure message" );
        }
        private static object[] AddCases =   {
                new int[] {2, 4, 6},
                new int[] {-2, 3, 1}
         };
        [Test]
        [Category( "Happy Path" )]
        public void DivisibleBy3_GivenInputOf6_ReturnsTrue() {
            // Arrange
            var subject = new Calculator { Num1 = 6 };

            // Act
            var result = subject.DivisibleBy3();

            // Assert
            Assert.That( result, Is.True );
        }

        [Test]
        public void DivisibleBy3_GivenInputOf7_ReturnsTrue() {
            // Arrange
            var subject = new Calculator { Num1 = 7 };

            // Act
            var result = subject.DivisibleBy3();

            // Assert
            Assert.That( result, Is.False );
        }

        [Test]
        [Category( "Happy Path" )]
        public void ToString_ContainsTheStringCalculator() {
            // Arrange
            Calculator subject = new Calculator();

            // Act
            var result = subject.ToString();

            // Assert
            Assert.That( result, Does.Contain( "Calculator" ) );
            Assert.That( result, Is.EqualTo( "AdvancedNUnit.Calculator" ) );
            Assert.That( result, Is.EqualTo( "advancednunit.calculator" ).IgnoreCase );
            Assert.That( result, Does.Not.Contain( "Potato" ) );
            Assert.That( result, Does.StartWith( "A" ) );
            Assert.That( result, Has.Length.EqualTo( 24 ) );
            Assert.That( result, Is.Not.Empty );
        }

        [Test]
        public void CollectionContraintsExercise() {
            var trainers = new string[] { "Laura", "Joe", "Phil", "Neil", "Martin", "Cathy" };

            Assert.That( trainers, Has.Length.EqualTo( 6 ) );
            Assert.That( trainers, Has.Exactly( 2 ).Items.EndsWith( "l" ) );
            Assert.That( trainers, Has.Some.EqualTo( "cathy" ).IgnoreCase );
            Assert.That( trainers, Has.Exactly( 3 ).Items.Contains( "i" ) );
        }

        [Test]
        public void RangeContraintsExercise() {
            var nums = new int[] { 4, 2, 6, 7, 1, 9 };

            Assert.That( 8, Is.InRange( 1, 10 ) );
            Assert.That( nums, Is.All.InRange( 1, 10 ) );
            Assert.That( nums, Has.Exactly( 3 ).InRange( 1, 5 ) );
        }
    }

}