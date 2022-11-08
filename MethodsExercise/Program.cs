namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //Caling Coversation into Main()
           Conversation();

            //Sum
            Console.WriteLine("1. Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. Give me a number to add to the first");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The Sum is {sum}");
            
            //Multiply
            Console.WriteLine("1. Give a number to Multiply");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("2. Give a number to Multiply with the first");
            int y = int.Parse(Console.ReadLine());

            int mult = Multiply(x, y);
            Console.WriteLine($"the answer is {mult}");
            
            //Subtract
            Console.WriteLine("1. Give a number to subtract");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. Give a number to subtract from the first number");
            int num4 = int.Parse(Console.ReadLine());

            int sub = Subtract(num3, num4);
            Console.WriteLine($"The answer is {sub}");

            //Divide
            Console.WriteLine("1. Give a number to Divide");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("2. Give a number to Divide by");
            int b=int.Parse(Console.ReadLine());

            int div = Divide(a, b);
            Console.WriteLine($"The answer is {div}");

            //Modulus 
            Console.WriteLine("1. give a number");
            int num5 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. Give another number");
            int num6 = int.Parse(Console.ReadLine());

            int mod = Modulus(a, b);
            Console.WriteLine($"The answer is {mod}");



        }

        //Arithmatic Methods
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int x, int y)
        {
            return (x * y);
        }

        public static int Subtract(int num3, int num4)
        {
            return num3 - num4;
        }

        public static int Divide(int a, int b)
        {
            return (a / b);
        }

        public static int Modulus(int num5, int num6)
        {
            return (num5 % num6);
        }

        // Conversation Method
        public static void Conversation()
        {

            Console.WriteLine("Hello, Let's get to know eachother! What is your name?");



            string name = Console.ReadLine();



            Console.WriteLine($"Nice to meet you {name}! What is your favorite color?");



            string color = Console.ReadLine();



            Console.WriteLine($"I love the color {color} too! What about your favorite animals?");



            string animal = Console.ReadLine();



            Console.WriteLine($"{animal} are the best!  Last question, what is your favorite band?");



            string band = Console.ReadLine();



            Console.WriteLine($"Wow {name}, Thanks for talking with me! Today I learned your favorite color is {color}. Your favorite Animal is a {animal}. Last but not least your favorite band is {band}.");

        }

    }
}
