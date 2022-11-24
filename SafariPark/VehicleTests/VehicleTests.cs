using SafariParkApp;

namespace VehicleTests {
    public class Tests {
        [Test] public void WhenADefaultVehicleMovesTwiceItsPositionIs20() { Vehicle v = new Vehicle(); var result = v.Move( 2 ); Assert.AreEqual( 20, v.Position ); Assert.AreEqual( "Moving along 2 times", result ); }

        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40() {
            Vehicle v = new Vehicle( 5, 40 ); var result = v.Move(); Assert.AreEqual( 40, v.Position ); Assert.AreEqual( "Moving along", result );
        }

        [Test]
        public void GivenOnlyCapacity_Speed_ShoulBe10() {
            Vehicle v = new Vehicle( 5 ); var result = v.Speed; Assert.That( 10, Is.EqualTo( result ) );
        }

        [Test]
        public void Given() {
            Vehicle v = new Vehicle( 5, 12 ); var result = v.Position; Assert.That( 12, Is.EqualTo( result ) );
        }

    }
}