namespace SafariParkApp {
    public class Vehicle {
        protected int _capacity;
        private int _numPassengers;

        public int NumPassengers {
            get => _numPassengers;
            set {
                if ( value >= 0 && value <= _capacity ) {
                    _numPassengers = value;
                }
            }
        }
        public int Position { get; protected set; }
        public int Speed { get; init; }

        public Vehicle( int capacity, int speed = 10 ) {
            _capacity = capacity;
            Speed = speed;
        }
        public Vehicle() : this( 0 ) {
        }

        public virtual string Move() {
            Position += Speed;
            return "Moving along";
        }

        public virtual string Move( int times ) {
            Position += Speed * times;
            return $"Moving along {times} times";
        }

    }
}
