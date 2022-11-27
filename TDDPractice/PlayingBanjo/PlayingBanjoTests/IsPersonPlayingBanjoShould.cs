using PlayingBanjoApp;

namespace PlayingBanjoTests {
    public class IsPersonPlayingBanjoShould {

        [TestCase( "Martin", "Martin is not playing the banjo." )]
        [TestCase( "Steve", "Steve is not playing the banjo." )]
        [TestCase( "Harry", "Harry is not playing the banjo." )]
        [TestCase( "Nick", "Nick is not playing the banjo." )]
        public void GivenNameNOTStartingWithR_IsPersonPlayingBanjo_ReturnsCorrectString( string name, string expected ) {
            Assert.That( Program.IsPersonPlayingBanjo( name ), Is.EqualTo( expected ) );
        }

        [TestCase( "Rick", "Martin is playing the banjo." )]
        [TestCase( "Rob", "Martin is playing the banjo." )]
        [TestCase( "Rice", "Martin is playing the banjo." )]
        public void GivenNameStartingWithR_IsPersonPlayingBanjo_ReturnsCorrectString( string name, string expected ) {
            Assert.That( Program.IsPersonPlayingBanjo( name ), Is.EqualTo( expected ) );
        }
    }
}