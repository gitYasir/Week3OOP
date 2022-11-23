using RomanNumerals;
namespace RomanNumeralsTests {
    public class GetRomanNumeralsShould {

        [TestCase( 1, "I" )]
        [TestCase( 4, "IV" )]
        [TestCase( 10, "X" )]
        [TestCase( 148, "CXLVIII" )]
        public void GivenNumber_GetRomanNumeral_ReturnsRomanNumeral( int number, string expected ) {
            Assert.That( Program.GetRomanNumerals( number ), Is.EqualTo( expected ) );
        }
    }
}