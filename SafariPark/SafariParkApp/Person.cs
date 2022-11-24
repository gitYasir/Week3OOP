namespace SafariParkApp {
    public class Person {
        //public readonly string _firstName = "";
        //private string _lastName = "";
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

        public string FirstName {
            get; init;
        } = "";
        public string LastName {
            get; init;
        } = "";

        public Person( string firstName ) {
            FirstName = firstName;
        }

        public Person() {
        }

        public Person( string firstName, string lastName, int age ) {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FullName => $"{FirstName} {LastName}";
    }
}
