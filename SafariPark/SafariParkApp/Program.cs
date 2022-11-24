namespace SafariParkApp {
    internal class Program {
        static void Main( string[] args ) {
            Person yasir = new Person( "Yasir", "Ibrahim", 29 );
            Console.WriteLine( yasir.FullName );

            Person laura = new Person( "Laura" );
            Console.WriteLine( laura );

            yasir.Age = 30;
            Console.WriteLine( $"Yasir is actually {yasir.Age}." );

            var steve = new Person( "Steve" ) { Age = 30 };

            var list = new ShoppingList() { Bread = 2, Potato = 3, Milk = 4 };
            Console.WriteLine( list[ 0 ] );
        }
    }
}
