using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cow = new Animal("소", "Mewww");

            cow.MakeSound();


            Animal pig = new Animal("돼지", "Quiq");
            

            pig.MakeSound();


            Animal fox = new Animal();
            fox.name = "여우";
            fox.sound = "woof";
            Console.WriteLine("[F] name : {0}, sound : {1}", fox.name, fox.sound);

            fox.MakeSound();

            Console.ReadLine();
        }
        
        void practiceRectangle()
        {
            Rectangle rect1;
            rect1.width = 100;
            rect1.length = 30;

            rect1.print();

            // Console.WriteLine("[L] width{0}, length:{1}, Area{2}", rect1.width, rect1.length, rect1.Area());

            Rectangle rect2 = new Rectangle(200, 50);

            rect2.print();

            //Console.WriteLine("[L] width{0},, length:{1}, Area{2}", rect2.width, rect2.length, rect2.Area());
        }

        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l, double w)
            {
                length = l;
                width = w;
            }

            public void print()
            {
                Console.WriteLine("[L] width{0}, length:{1}, Area{2}", width, length, Area());
            }

            public double Area()
            {
                return length * width;
            }
        }
    }
}
