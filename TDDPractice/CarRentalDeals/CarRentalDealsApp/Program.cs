namespace CarRentalDealsApp {
    public class Program {
        static void Main( string[] args ) {
            Console.WriteLine( "Hello, World!" );
        }

        public static string RentalSaving( int numOfDays ) {
            var rentPerDay = 40;
            var dicountThreeToSixDays = 20;
            var dicountSevenDaysPlus = 50;
            if ( numOfDays > 0 && numOfDays <= 2 ) {
                return "For 2 days or less, you make no saving.";
            }
            else if ( numOfDays >= 3 && numOfDays <= 6 ) {
                var orginal = numOfDays * rentPerDay;
                var newPrice = orginal - dicountThreeToSixDays;
                return $"Original price is £{orginal}. Final price is £{newPrice}. You save £20.";
            }
            else if ( numOfDays >= 7 ) {
                var orginal = numOfDays * rentPerDay;
                var newPrice = orginal - dicountSevenDaysPlus;
                return $"Original price is £{orginal}. Final price is £{newPrice}. You save £50.";
            }
            else {
                return "Number of days must be 1 or more.";
            }
        }

    }
}