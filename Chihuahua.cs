using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Chihuahua : Dog //chihuahua ärver från dog klassen som är i sin tur ärver från animal
    {
        public int _length { get; set; }

        public Chihuahua (string name ="unknown", string color="unknown", string gender="unknown", string sound="unknown",
            int age=0, string eyesColor="unknown", int length=0)
            : base(name, color, gender, sound, age, eyesColor)
        {
            _length = length;

            

        }

        public void searching () //skapar egna metoder
        {
            Console.WriteLine($"{_name} is searching for a place to sleep");
        }

        public override void makeSound()
        {
            Console.WriteLine($"{_name } is making {_sound}");
        }
    }
}
