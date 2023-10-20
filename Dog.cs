using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Arv
{
    internal class Dog : Animal //Dog klass ärver från animal
    {
        public string _eyesColor { get; set; } //lägger till egenskap till klassen
        public Dog (string name ="unknown", string color="unknown", string gender="unknown",
            string sound="unknown", int age=0, string eyesColor="unknown") 
            : base (name, color, gender, sound, age) //ärver egenskaper från basen
        {
            _eyesColor = eyesColor;
            Console.WriteLine($"Name: {_name}, Color: {_color}, Gender: {_gender}, Sound: {_sound}, Age: {_age}, eyes color: { _eyesColor}");
        }// utskrift på egenskaperna

        public void Sitting () //skapar metoder som är särskilda till denna klass
        {
            Console.WriteLine($"{_name} is sitting");
        }

        public virtual void makeSound()
        {
            Console.WriteLine($"{_name} is making {_sound}");
        }
    }
}
