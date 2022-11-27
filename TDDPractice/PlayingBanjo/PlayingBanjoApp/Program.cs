namespace PlayingBanjoApp {
    public class Program {
        static void Main( string[] args ) {
            Console.WriteLine( "Hello, World!" );
        }

        public static string IsPersonPlayingBanjo( string name ) {
            if ( name.StartsWith( "R" ) || name.StartsWith( "r" ) ) {
                return $"{name} is playing the banjo.";
            }
            else {
                return $"{name} is not playing the banjo.";

            }
        }

    }
}