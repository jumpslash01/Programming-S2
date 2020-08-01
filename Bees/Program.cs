using System;

namespace Bees {
    class Program {

        static void Main (string[] args) {

            //CREATE BEES
            Bees Bee1 = new Bees ("John", 3.2f);
            Bees Bee2 = new Bees ("Paul", 2.7f);
            Bees Bee3 = new Bees ("George", 1.1f);
            Bees Bee4 = new Bees ("Ringo", 2.0f);
            Bees Bee5 = new Bees ("Kurt", 2.3f);
            Bees Bee6 = new Bees ("Dave", 7.4f);
            Bees Bee7 = new Bees ("Krist", 1.5f);

            //CREATE HIVES
            hive hive1 = new hive ();
            hive hive2 = new hive ();
            
            //CALL METHOD TO FILL HIVES
            hive1.FillHive1 (Bee1, Bee2, Bee3, Bee4);
            hive2.FillHive2 (Bee5, Bee6, Bee7);

            //USER INPUTS AMOUNT OF DAYS TO COLLECT HONEY
            System.Console.WriteLine ("Enter the amount of days hive 1 will gather for");
            float days1 = float.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Enter the amount of days hive 2 will gather for");
            float days2 = float.Parse (Console.ReadLine ());

            //CALL METHOD TO COLLECT HONEY
            hive1.FlyMyPrettys (days1);
            hive2.FlyMyPrettys2 (days2);

        }
    }
}