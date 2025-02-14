namespace _122251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
      int n = int.Parse(Console.ReadLine());
            Console.WriteLine("the sum of its digits is equal to "+DigitSum(n));

        }
        public int DigitSum(int n)
        { if (n < 10) { return n; }
            else { return (n % 10 + DigitSum(n / 10)); } }
    }
}
