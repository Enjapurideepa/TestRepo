using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3q2
{
    public class Bird
    {
        public static void Main(string[] args)
        {
            Bird b = new Bird("Eagle", double.Parse("200"));
            b.fly();
            b.fly("300");
            Console.ReadLine();
        }
        public string Name;
        public double Maxheight;
        public Bird()
        {
            this.Name = "Mountain Eagle";
            this.Maxheight = 500;
        }
        public Bird(string birdname, double max_ht)
        {
            this.Name = "Another Bird";
            this.Maxheight = 600;
        }
        public void fly()
        {
            Console.WriteLine(this.Name, "is flying at altitude", this.Maxheight);
        }
        public void fly(string AtHeight)
        {
            if (Convert.ToInt32(AtHeight) == this.Maxheight)
                    Console.WriteLine(this.Name + "flying at " + AtHeight.ToString());
            else
            {
                Console.WriteLine(this.Name, "cannot fly at this height");
            }
        }
    }
}
