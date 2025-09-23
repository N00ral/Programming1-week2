namespace Assignment5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Console.WriteLine("Enter the 1st number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the 3rd number: ");
            int num3 = int.Parse(Console.ReadLine());

            // method call
            int max = FindMax(num1, num2, num3);

            Console.WriteLine($"The maximum number is: {max} ");
        }

          public int FindMax(int num1, int num2, int num3)

         {
            int max = num1;

            if (num2 > max)
                max = num2;

            if (num3 > max)
                max = num3;

            return max;
          }
    }
}
