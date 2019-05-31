using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    class Animal
    {
        public string name;
        public string sound;

        public Animal()
        {
            name = "No name";
            sound = "No sound";

        }

        public Animal(string n, string s)
        {
            name = n;
            sound = s;
        }

        public void MakeSound()
        {
            Console.WriteLine("[F] name : {0}, sound : {1}", name, sound);
        }
    }
}
