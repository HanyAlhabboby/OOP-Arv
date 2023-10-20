using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Bulldog : Dog //bulldog ärver från dog klassen som är i sin tur ärver från animal
    {
        public int _height { get; set; }
        public Bulldog(string name="unknown", string color="unknown", string gender="unknown",
            string sound="unknown", int age =0, string eyesColor="unknown", int height=0)
            : base(name, color, gender, sound, age, eyesColor) 
        {
            _height = height;

            
        }

        public void bodyGuard() //skapar egna metoder
        {
            Console.WriteLine($"{_name} is guarding");
        }

        public override void makeSound()
        {
            Console.WriteLine($"{_name} is making {_sound}");
        }


    }
}
