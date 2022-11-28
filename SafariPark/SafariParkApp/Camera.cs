namespace SafariParkApp {
    internal class Camera : IShootable {
        private string _brand;

        public Camera( string brand ) {
            _brand = brand;
        }
        public virtual string Shoot() {
            return $"{_brand}";
        }

        public override string ToString() {
            return base.ToString();
        }
    }
}
