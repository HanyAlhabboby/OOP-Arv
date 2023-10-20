using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Cat : Animal
    {
        public string _tail { get; set; }
        
        public Cat (string name ="unkown", string color ="unkown", string gender="unkown", 
            string sound="unkown", int age=0, string tail="unknown")
            : base(name, color, gender, sound, age)
        {
            _tail = tail;
            Console.WriteLine($"Name: {_name}, Color: {_color}, Gender: {_gender}, Sound: {_sound}, Age: {_age}, Tail:{ _tail}");
        }

        public void Climbing() //skapar egna metoder
        {
            Console.WriteLine($"{_name} is climbing");
        }

        public override void makeSound()
        {
            Console.WriteLine($"{_name} is making {_sound}");
        }
    }
}

