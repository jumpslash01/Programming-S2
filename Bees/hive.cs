namespace Bees {
    public class hive {

        public Bees bee1, bee2, bee3, bee4, bee5, bee6, bee7;

        public int maxbees = 4; 

        public void FillHive1 (Bees newbee1, Bees newbee2, Bees newbee3, Bees newbee4) {
            bee1 = newbee1;
            bee2 = newbee2;
            bee3 = newbee3;
            bee4 = newbee4;
        }
        public void FillHive2 (Bees newbee1, Bees newbee2, Bees newbee3) {
            bee5 = newbee1;
            bee6 = newbee2;
            bee7 = newbee3;
        }

        public void FlyMyPrettys (float day) {
            System.Console.WriteLine ((bee1.size + bee2.size + bee3.size + bee4.size) * (0.2f) * day);
        }
        public void FlyMyPrettys2 (float day) {
            System.Console.WriteLine ((bee5.size + bee6.size + bee7.size) * (0.2f) * day);

        }
    }
}