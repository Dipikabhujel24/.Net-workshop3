namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Operators class
            Operators op = new Operators();

            // Call all methods
            op.Add(10, 5);
            op.Subtract(10, 5);
            op.Multiply(10, 5);
            op.Divide(10, 5);
            op.Divide(10, 0); // To test division by zero
            op.OddEvenFinder(7);
            op.OddEvenFinder(8);
        }
    }
}
