namespace SafariParkApp {
    internal class Hunter : Person {

        private string _camera;

        public Hunter( string fName, string lName, string camera = "" ) : base( fName, lName ) {
            _camera = camera;
        }

        public string Shoot() {
            return $"{GetFullName()} has taken a photo with their {_camera}";
        }

    }
}
