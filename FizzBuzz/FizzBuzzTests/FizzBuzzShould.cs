using FizzBuzzApp;

namespace FizzBuzzTests {
    public class FizzBuzzShould {

        [Test]
        public void GivenOne_FizzBuzzReturns_StringOfOne() {
            Assert.That( Program.FizzBuzz( 1 ), Is.EqualTo( "1" ) );
        }

        [TestCase( 1, "1" )]
        [TestCase( 2, "2" )]
        [TestCase( 44, "44" )]
        public void GivenNumber_FizzBuzz_ReturnsItsString( int inputNum, string expected ) {
            Assert.That( Program.FizzBuzz( inputNum ), Is.EqualTo( expected ) );
        }

        [TestCase( 3, "Fizz" )]
        public void GivenNumberThree_FizzBuzz_ReturnsFizz( int inputNum, string expected ) {
            Assert.That( Program.FizzBuzz( inputNum ), Is.EqualTo( expected ) );
        }

        [TestCase( 5, "Buzz" )]
        public void GivenNumberFive_FizzBuzz_ReturnsBuzz( int inputNum, string expected ) {
            Assert.That( Program.FizzBuzz( inputNum ), Is.EqualTo( expected ) );
        }

        [TestCase( 15, "FizzBuzz" )]
        public void GivenNumberFifteen_FizzBuzz_ReturnsFizzBuzz( int inputNum, string expected ) {
            Assert.That( Program.FizzBuzz( inputNum ), Is.EqualTo( expected ) );
        }

        [TestCase( -15, "Number must be between 1 and 30 inclusive" )]
        public void GivenNumberMinusFifteen_FizzBuzz_ReturnsException( int inputNum, string expected ) {
            Assert.That( () => {
                return Program.FizzBuzz( inputNum );
            }, Throws.TypeOf<ArgumentOutOfRangeException>()
           .With.Message.Contain( expected ) );
        }
    }
}