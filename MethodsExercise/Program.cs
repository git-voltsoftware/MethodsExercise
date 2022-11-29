namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            string? name;
            string? color;
            string? animal;
            string? band;

            //part one
            
            Console.WriteLine("What is your name? ");
            name = Console.ReadLine();

            Console.WriteLine("What is your favorite color? ");
            color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal? ");
            animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band? ");
            band = "Stone Temple Pilots";

            Console.WriteLine($"Your name is {name} and your favorite color is {color}. Also, your favorite animal is an {animal}. and your favorite band is {band}.");

            //part two

            Add(2,2);
            Subtract(40,20);
            Multiply(50,2);
            Divide(100,2);
            Modulus(9,3);

        }

        static int Add(int x, int y){
           return x + y;
        }

        static int Subtract(int x, int y){
            return x - y;
        }

        static int Multiply(int x, int y){
            return x * y;
        }

        static int Divide(int x, int y){
            return x / y;
        }

        static int Modulus(int x, int y){
            return x % y;
        }

    }
}