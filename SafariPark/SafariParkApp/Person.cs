namespace SafariParkApp {
    public class Person {
        private int _age;

        public int Age {
            get {
                return _age;
            }
            set {
                if ( Age < 0 ) {
                    throw new ArgumentException();
                }
                _age = value;
            }
        }

        private string _firstName;
        private string _lastName;

        public Person( string firstName ) {
            _firstName = firstName;
        }
        public Person() {
        }

        public Person( string firstName, string lastName, int age = 0 ) {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
        }

        public string GetFullName() => $"{_firstName} {_lastName}";
    }

    public class Vehicle {
        private int _capacity;
        private int _numPassengers;

        public int NumPassengers {
            get => _numPassengers;
            set {
                if ( value >= 0 && value <= _capacity ) {
                    _numPassengers = value;
                }
            }
        }
        public int Position { get; private set; }
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
