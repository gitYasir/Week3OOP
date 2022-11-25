﻿namespace SafariParkApp {
    internal class Program {
        static void Main( string[] args ) {
            #region inheritance

            /*            Person yasir = new Person( "Yasir", "Ibrahim", 29 );
                        Console.WriteLine( yasir.FullName );

                        Person laura = new Person( "Laura" );
                        Console.WriteLine( laura );

                        yasir.Age = 30;
                        Console.WriteLine( $"Yasir is actually {yasir.Age}." );

                        var steve = new Person( "Steve" ) { Age = 30 };

                        var list = new ShoppingList() { Bread = 2, Potato = 3, Milk = 4 };
                        Console.WriteLine( list.Bread );

                        var harry = new Person() { FirstName = "Harry", LastName = "Steve", Age = 22 };*/

            //Point3D p = new Point3D( 3, 6, 2 );
            //var p2 = new Point3D();

            //Point3D p3;
            //p3.x = 3;
            //p3.y = 6;
            //p3.z = 2;

            //Point3D p4 = new Point3D( 1, 7 );

            //static void DemoMethod( Point3D pt, Person p ) {
            //    pt.y = 1000;
            //    p.Age = 92;
            //}

            //Person john = new Person( "John", "Jones" ) { Age = 20 };
            //Point3D pt3D = new Point3D( 5, 8, 2 );
            //DemoMethod( pt3D, john );

            //Hunter yasir = new Hunter( "Yasir", "Ibrahim", "Nikon" ) { Age = 29 };
            //Console.WriteLine( yasir.Age );
            //Console.WriteLine( yasir.Shoot() );

            //var david = new Hunter( "David", "Williams", "Cannon" ) { Age = 18 };
            ////Console.WriteLine( $"yasir Equals david? {yasir.Equals( david )}" );
            ////Console.WriteLine( $"yasir HashCode? {yasir.GetHashCode()}" );
            ////Console.WriteLine( $"david Type? {david.GetType()}" );
            //Console.WriteLine( $"david ToString? {david.ToString()}" ); // ToString() returns <namespace>.<class>

            //Console.WriteLine( $"david ToString? {david}" );

            //var p = new Person( "A", "B", 22 );
            //Console.WriteLine( p.ToString() );

            //var prac = new Airplane( 200, 100, "JetsRUs" ) { NumPassengers = 150 };
            //prac.Ascend( 500 );
            //Console.WriteLine( prac.Move( 3 ) );
            //Console.WriteLine( prac );
            //prac.Descend( 200 );
            //Console.WriteLine( prac.Move() );
            //prac.Move();
            //Console.WriteLine( prac );

            #endregion

            #region collections 

            var helen = new Person { FirstName = "Helen", LastName = "Troy", Age = 22 };
            var will = new Hunter { FirstName = "William", LastName = "Shakespeare", Age = 457 };
            //Console.WriteLine( "List of people" );
            //List<Person> thePeople = new List<Person> { helen, will };


            //foreach ( var person in thePeople ) {
            //    Console.WriteLine( person );
            //}
            //Console.WriteLine();

            //List<int> list = new List<int> { 5, 4, 3, 9, 0 };
            //list.Add( 8 );
            //list.Sort();
            //list.RemoveRange( 1, 2 );
            //list.Insert( 2, 1 );
            //list.Reverse();
            //list.Remove( 9 );

            //foreach ( var item in list ) {
            //    Console.Write( item + " " );
            //}
            //Console.WriteLine();

            Console.WriteLine( "LinkedList of people" );
            LinkedList<Person> thePeopleLinked = new LinkedList<Person>();
            thePeopleLinked.AddFirst( helen );
            thePeopleLinked.AddLast( will );
            thePeopleLinked.AddLast( new Person { FirstName = "Linda", LastName = "Smith", Age = 45 } );

            foreach ( var person in thePeopleLinked ) {
                Console.WriteLine( person );
            }

            #endregion
        }
    }
}
