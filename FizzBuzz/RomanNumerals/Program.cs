namespace RomanNumerals {
    public class Program {
        static void Main( string[] args ) {
            Console.WriteLine( "Hello, World!" );
        }

        public static string GetRomanNumerals( int number ) {
            string numeral = "";
            int numToWorkwith = number;
            do {

                if ( numToWorkwith - 100 >= 0 ) {
                    numeral += "C";
                    numToWorkwith -= 100;
                }
                else if ( numToWorkwith - 90 >= 0 ) {
                    numeral += "XC";
                    numToWorkwith -= 90;
                }
                else if ( numToWorkwith - 80 >= 0 ) {
                    numeral += "LXXX";
                    numToWorkwith -= 80;
                }
                else if ( numToWorkwith - 70 >= 0 ) {
                    numeral += "LXX";
                    numToWorkwith -= 70;
                }
                else if ( numToWorkwith - 60 >= 0 ) {
                    numeral += "LX";
                    numToWorkwith -= 60;
                }
                else if ( numToWorkwith - 50 >= 0 ) {
                    numeral += "L";
                    numToWorkwith -= 50;
                }
                else if ( numToWorkwith - 40 >= 0 ) {
                    numeral += "XL";
                    numToWorkwith -= 40;
                }
                else if ( numToWorkwith - 30 >= 0 ) {
                    numeral += "XXX";
                    numToWorkwith -= 30;
                }
                else if ( numToWorkwith - 20 >= 0 ) {
                    numeral += "XX";
                    numToWorkwith -= 20;
                }
                else if ( numToWorkwith - 10 >= 0 ) {
                    numeral += "X";
                    numToWorkwith -= 10;
                }
                else if ( numToWorkwith - 9 >= 0 ) {
                    numeral += "IX";
                    numToWorkwith -= 9;
                }
                else if ( numToWorkwith - 8 >= 0 ) {
                    numeral += "VIII";
                    numToWorkwith -= 8;
                }
                else if ( numToWorkwith - 7 >= 0 ) {
                    numeral += "VII";
                    numToWorkwith -= 7;
                }
                else if ( numToWorkwith - 6 >= 0 ) {
                    numeral += "VI";
                    numToWorkwith -= 6;
                }
                else if ( numToWorkwith - 5 >= 0 ) {
                    numeral += "V";
                    numToWorkwith -= 5;
                }
                else if ( numToWorkwith - 4 >= 0 ) {
                    numeral += "IV";
                    numToWorkwith -= 4;
                }
                else if ( numToWorkwith - 3 >= 0 ) {
                    numeral += "III";
                    numToWorkwith -= 3;
                }
                else if ( numToWorkwith - 2 >= 0 ) {
                    numeral += "II";
                    numToWorkwith -= 2;
                }
                else if ( numToWorkwith == 1 ) {
                    numeral += "I";
                    numToWorkwith -= 1;
                }
            } while ( numToWorkwith > 0 );

            return numeral;
        }

    }
}