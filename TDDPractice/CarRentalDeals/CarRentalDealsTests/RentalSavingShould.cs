using CarRentalDealsApp;

namespace CarRentalDealsTests {
    public class RentalSavingShould {

        [TestCase( 1, "For 1 day, you make no saving." )]
        [TestCase( 2, "For 2 days, you make no saving." )]
        [TestCase( 3, "Original price is £120. Final price is £100. You save £20." )]
        [TestCase( 6, "Original price is £240. Final price is £220. You save £20." )]
        [TestCase( 7, "Original price is £280. Final price is £230. You save £50." )]
        [TestCase( 10, "Original price is £400. Final price is £350. You save £50." )]
        public void GivenANumberOfDays_RentalSaving_ReturnsCorrectString( int days, string expected ) {
            Assert.That( Program.RentalSaving( days ), Is.EqualTo( expected ) );
        }
    }
}