using System;
using System.Collections.Generic;

namespace Collections_Lib {
    public class CollectionsExercises {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue( int num, Queue<string> queue ) {
            var list = new List<string>();
            if ( num > queue.Count ) {
                num = queue.Count;
            }
            for ( int i = 0; i < num; i++ ) {
                //content += $"{queue.Dequeue()}";
                list.Add( queue.Dequeue() );
            }
            return string.Join( ", ", list );
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse( int[] original ) {
            Stack<int> stack = new Stack<int>();
            foreach ( int num in original ) {
                stack.Push( num );
            }
            return stack.ToArray();
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits( string input ) {
            var dict = new Dictionary<int, int>();
            foreach ( var num in input ) {
                if ( Char.GetNumericValue( num ) != -1.0 ) {
                    int res = ( int ) Char.GetNumericValue( num );
                    if ( dict.ContainsKey( res ) ) {
                        dict[ res ]++;
                    }
                    else {
                        dict.Add( res, 1 );
                    }
                }
            }
            string ans = "";
            foreach ( var entry in dict ) {
                ans += entry.ToString();
            }
            return ans;
        }
    }
}

