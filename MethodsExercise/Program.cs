using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            string username = Console.ReadLine();

            Console.WriteLine("what is your favorite color");
            string color = Console.ReadLine();

            Console.WriteLine("what is your favorite animal");
            string animal = Console.ReadLine();

            Console.WriteLine("what is your favorite band");
            string band = Console.ReadLine();

            Console.WriteLine($"there was a man named {username},his favorite color is {color}");
            Console.WriteLine($"the mans favorite animal is a {animal},which explains why his favorite band is {band}");
            Console.WriteLine($"these were {username} favorite {color},{animal},{band}");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is:{sum}");

            Console.WriteLine("Give me a number to Muliply");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            int num4 = int.Parse(Console.ReadLine());

            int product = Multiply(num3, num4);
            Console.WriteLine($"The Product is:{product}");

            Console.WriteLine("Give me a number to Divide");
            int num5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to Divide to the first one");
            int num6 = int.Parse(Console.ReadLine());

            int quotient = Divide(num5, num6);
            Console.WriteLine($"The quotient is:{quotient}");


            Console.WriteLine("Give me a number to Subtract");
            int num7 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to Subtract to the first one");
            int num8 = int.Parse(Console.ReadLine());

            int Diffrence = Subtract(num7, num8);
            Console.WriteLine($"The Diffrence is:{Diffrence}");

        }

        public static int Sum(int num1, int num2)
        {


            int sum = num1 + num2;

            return sum;


        }
        public static int Multiply(int num3, int num4)
        {

            return num3 * num4;
        }

        public static int Subtract(int num5, int num6)
        {
            return num5 - num6;


        }
        public static int Divide(int num7, int num8)
        {




            return num7 / num8;

        }
    }
}
        




        
