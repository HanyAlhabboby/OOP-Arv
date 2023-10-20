using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Bird : Animal
    {
        public int _weight { get; set; }
        public Bird(string name ="unkown", string color="unkown", string gender="unknown" ,
            string sound="unknown", int age=0, int weight=0)
            : base (name, color, gender,sound , age)
        {
            _weight = weight;
            Console.WriteLine($"Name: {_name}, Color: {_color}, Gender: {_gender}, Sound: {_sound}, Age: {_age}, Weight {_weight } g");
        }

        public void Flying () //skapar egna metoder
        {
            Console.WriteLine($"{_name} is flying");
        }

        public override void makeSound()
        {
            Console.WriteLine($"{_name} is making {_sound}");
        }

    }
}
