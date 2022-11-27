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

        [TestCase( "Rick", "Rick is playing the banjo." )]
        [TestCase( "rick", "rick is playing the banjo." )]
        [TestCase( "Rob", "Rob is playing the banjo." )]
        [TestCase( "rob", "rob is playing the banjo." )]
        [TestCase( "Rice", "Rice is playing the banjo." )]
        [TestCase( "rice", "rice is playing the banjo." )]
        public void GivenNameStartingWithR_IsPersonPlayingBanjo_ReturnsCorrectString( string name, string expected ) {
            Assert.That( Program.IsPersonPlayingBanjo( name ), Is.EqualTo( expected ) );
        }
    }
}