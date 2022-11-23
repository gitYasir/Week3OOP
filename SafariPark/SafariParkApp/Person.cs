namespace SafariParkApp {
    public class Person {
        private string _firstName = "";
        private string _lastName = "";
        private int _age;

        public Person( string firstName ) {
            _firstName = firstName;
        }
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

        public Person( string firstName, string lastName, int age ) {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
        }


        public string FullName => $"{_firstName} {_lastName}";
    }
}
