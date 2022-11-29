namespace SafariParkApp {
    public class Person : IMovable, IEquatable<Person?>, IComparable<Person> {
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

        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }

        private string _firstName;
        private string _lastName;

        public Person( string firstName ) {
            FirstName = firstName;
        }
        public Person() {
        }

        public Person( string firstName, string lastName, int age = 0 ) {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
        }

        public string GetFullName() => $"{_firstName} {_lastName}";

        public virtual string Move() {
            return "Moving along";
        }

        public virtual string Move( int times ) {
            return $"Moving along {times} times";
        }

        public override string ToString() {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";

        }

        public override bool Equals( object? obj ) {
            return Equals( obj as Person );
        }

        public bool Equals( Person? other ) {
            return other is not null &&
                     Age == other.Age &&
                     FirstName == other.FirstName &&
                     LastName == other.LastName;
        }

        public override int GetHashCode() {
            return HashCode.Combine( Age, FirstName, LastName );
        }

        public int CompareTo( Person? other ) {
            if ( other == null )
                return 1;
            if ( LastName != other.LastName ) {
                return this.LastName.CompareTo( other.LastName );
            }
            else if ( FirstName != other.FirstName ) {
                return FirstName.CompareTo( other.FirstName );
            }
            else { return Age.CompareTo( other.Age ); };
        }

        public static bool operator ==( Person? left, Person? right ) {
            return EqualityComparer<Person>.Default.Equals( left, right );
        }

        public static bool operator !=( Person? left, Person? right ) {
            return !( left == right );
        }
    }
}
