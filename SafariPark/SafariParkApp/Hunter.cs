namespace SafariParkApp {
    internal class Hunter : Person, IShootable {

        //private string _camera;

        public Hunter() { }

        public IShootable Shooter { get; set; }

        public Hunter( string fName, string lName, IShootable shooter ) : base( fName, lName ) {
            Shooter = shooter;
        }

        public string Shoot() {
            //return $"{GetFullName()} has taken a photo with their {Shooter}";
            return Shooter.Shoot();
        }

        public override string ToString() {
            return $"{base.ToString()} Camera: {Shooter}";
        }

    }
}
