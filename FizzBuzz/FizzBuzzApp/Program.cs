namespace FizzBuzzApp {
    public class Program {
        static void Main( string[] args ) {
            int max = 30;
            for ( int i = 1; i <= max; i++ ) {
                Console.WriteLine( $"{FizzBuzz( i )}" );
            }
        }

        public static string FizzBuzz( int i ) {
            if ( i <= 0 ) {
                throw new ArgumentOutOfRangeException( "Number must be between 1 and 30 inclusive" );
            }
            if ( i % 3 == 0 && i % 5 == 0 ) {
                return "FizzBuzz";
            }
            if ( i % 3 == 0 ) {
                return "Fizz";
            }
            if ( i % 5 == 0 ) {
                return "Buzz";
            }
            return i.ToString();
        }
    }
}