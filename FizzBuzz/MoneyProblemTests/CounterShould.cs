using MoneyProblem;
namespace MoneyProblemTests {
    public class CounterShould {

        [TestCase( 0.00, "0 £20 0 £10 0 £5 0 £2 0 £1 0 50p 0 20p 0 10p 0 5p 0 2p 0 1p" )]
        [TestCase( 0.10, "0 £20 0 £10 0 £5 0 £2 0 £1 0 50p 0 20p 1 10p 0 5p 0 2p 0 1p" )]
        [TestCase( 5.47, "0 £20 0 £10 1 £5 0 £2 0 £1 0 50p 2 20p 0 10p 1 5p 1 2p 0 1p" )]

        public void GivenZero_Counter_ReturnsStringOfZero( double amount, string expected ) {
            Assert.That( Program.Counter( amount ), Is.EqualTo( expected ) );
        }
    }
}