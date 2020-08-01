namespace Bees {
    public class hive {

        public Bees bee1, bee2, bee3, bee4, bee5, bee6, bee7;

        public int maxbees = 4; //This does nothing lol

        public void FillHive1 (Bees newbee1, Bees newbee2, Bees newbee3, Bees newbee4) {    //method to fill hive 1 with bees
            bee1 = newbee1;
            bee2 = newbee2;
            bee3 = newbee3;
            bee4 = newbee4;
        }
        public void FillHive2 (Bees newbee1, Bees newbee2, Bees newbee3) {  //fill hiv e2 with bees 
            bee5 = newbee1;
            bee6 = newbee2;
            bee7 = newbee3;
        }

        public void FlyMyPrettys (float day) {  //sends all hive 1 bees out collect honey based on user input days
            System.Console.WriteLine ((bee1.size + bee2.size + bee3.size + bee4.size) * (0.2f) * day);
        }
        public void FlyMyPrettys2 (float day) { //sends all hive 2 bees out collect honey based on user input days
            System.Console.WriteLine ((bee5.size + bee6.size + bee7.size) * (0.2f) * day);

        }
    }
}