namespace SafariParkApp {
    internal class Rectangle : Shape {

        private int width;
        private int height;

        public override int CalculateArea() {
            return width * height;
        }
    }
}
