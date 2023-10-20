namespace OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog ("Lucy", "black", "female", "hoofhoof", 7, "brown"); //skapar objekt 
            dog.Drink(); //anropar olika metoder
            dog.Eat();
            dog.Sitting();
            dog.makeSound();
            Console.WriteLine("------------------------------------------------------");

            Cat cat = new Cat("Boris", "white", "male", "meeewmeeew", 5, "long");
            cat.Drink();
            cat.Eat();
            cat.Climbing();
            cat.makeSound();
            Console.WriteLine("------------------------------------------------------------------------");


            Bird bird = new Bird("santos", "brown", "male", "coocooo", 2, 20);
            bird.Drink();
            bird.Eat();
            bird.Flying();
            bird.makeSound();
            Console.WriteLine("------------------------------------------------------------------------");


            Bulldog bulldog = new Bulldog("rocky", "grey", "male", "HOOOFHOOF", 4, "black", 30);
            bulldog.Drink();
            bulldog.Eat();
            bulldog.bodyGuard();
            bulldog.makeSound();
            Console.WriteLine("-------------------------------------------------------------------------");


            Chihuahua chihuahua = new Chihuahua("sandra", "brown", "female", "hooooooof", 1, "green", 30);
            chihuahua.Drink();
            chihuahua.Eat();
            chihuahua.searching();
            chihuahua.makeSound();
            Console.WriteLine("--------------------------------------------------------------------------");



        }
    }
}