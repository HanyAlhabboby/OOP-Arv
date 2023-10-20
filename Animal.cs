using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal abstract class Animal //skapar bas klass
    {

        
        public string _name { get; set; } //skapar olika fält
        public string _color { get; set; }
        public string _gender { get; set; }
        public string _sound { get; set; }
        public int _age { get; set; }

        

        public Animal( string name="unknown", string color="unknown", string gender="unknown", string sound="unknown", int age=0)
            // skapar konstruktor med default värden
        {
            _name = name;
            _color = color;
            _gender = gender;
            _sound = sound;
            _age = age;
        }

        public void Drink() //skapar genemsamma metoder ska anropas via olika klasser
        {
            Console.WriteLine($"{_name} is drinking water");
        }

        public void Eat ()
        {
            Console.WriteLine($"{_name} is eating food");
        }

        public virtual void makeSound()
        {
            Console.WriteLine($"{_name} is making {_sound}");
        }


    }
}
