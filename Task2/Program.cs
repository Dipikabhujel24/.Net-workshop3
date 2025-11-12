namespace Task2
{
    internal class Program
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("sum:" + (a + b));
        }
        public void Substract(int a, int b)
        {
            Console.WriteLine("difference:" + (a - b));
        }
        public void Multiply(int a, int b)
        {
            Console.WriteLine("product:" + (a * b));
        }
        public void Divide(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine("Division: " + (a / b));
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        public void OddEvenFinder(int number)
        {
            string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine(result);
        }

    }
}
