namespace SafariParkApp {
    public class Airplane : Vehicle {
        private string _airline;
        public int Altitude { get; private set; }

        public Airplane( int capacity ) : base( capacity ) {

        }

        public Airplane( int capacity, int speed, string airline ) : base( capacity, speed ) {
            _airline = airline;
        }

        public void Ascend( int distance ) {
            Altitude += distance;
        }

        public void Descend( int distance ) {
            Altitude -= distance;
        }

        public string Move() {
            Position += Speed;
            return $"Moving along at an altitude of {Altitude} metres.";
        }
        public string Move( int times ) {
            Position += Speed * times;
            return $"Moving along {times} times at an altitude of {Altitude} metres.";
        }

        public override string ToString() {
            return $"Thank you for flying JetsRUs: {base.ToString()} capacity: {_capacity} passengers: {NumPassengers} speed: {Speed} position: {Position} altitude: {Altitude}.";
        }

    }
}
