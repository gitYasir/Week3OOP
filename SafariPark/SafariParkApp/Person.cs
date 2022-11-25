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

        public string GetFullName() => $"{FirstName} {LastName}";

        public override string ToString() {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";

        }
    }
}
