namespace MoneyProblem {
    public class Program {
        static void Main( string[] args ) {
            Console.WriteLine( Counter( 1.33 ) );
        }

        public static string Counter( double amount ) {
            int overOne = ( int ) amount;
            int underOne = ( int ) ( ( amount * 100 ) - ( overOne * 100 ) );
            int twentyPounds = overOne / 20;
            overOne = overOne % 20;
            int tenPounds = overOne / 10;
            overOne = overOne % 10;
            int fivePounds = overOne / 5;
            overOne = overOne % 5;
            int twoPounds = overOne / 2;
            overOne = overOne % 2;
            int onePounds = overOne / 1;

            int fiftyPennies = underOne / 50;
            underOne = underOne % 50;
            int twentyPennies = underOne / 20;
            underOne = underOne % 20;
            int tenPennies = underOne / 10;
            underOne = underOne % 10;
            int fivePennies = underOne / 5;
            underOne = underOne % 5;
            int twoPennies = underOne / 2;
            underOne = underOne % 2;
            int onePennies = underOne / 1;

            return $"{twentyPounds} £20 {tenPounds} £10 {fivePounds} £5 {twoPounds} £2 {onePounds} £1 {fiftyPennies} 50p {twentyPennies} 20p {tenPennies} 10p {fivePennies} 5p {twoPennies} 2p {onePennies} 1p";
        }
    }
}