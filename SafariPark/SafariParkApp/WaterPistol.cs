namespace SafariParkApp {
    internal class WaterPistol : Weapon {
        public WaterPistol( string brand ) : base( brand ) {
        }

        public override string Shoot() {
            return $"Zing!! {base.Shoot()}";
        }

    }
}
