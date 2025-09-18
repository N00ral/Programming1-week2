namespace Assignment7
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
            Console.WriteLine("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            // method call
            bool result = IsLeapYear(year);

            if (result)
                Console.WriteLine("The year is a leap year.");
            else
                Console.WriteLine("The year is not a leap year.");
        }
         public bool IsLeapYear(int year)

        {
            if (year % 4 != 0)

                return false;           // not divisible by 4

            else if (year % 100 != 0)

                return true;            // divisible by 4 but not 100

            else if (year % 400 == 0)

                return true;            // divisible by 400

            else

                return false;           // divisible by 100 but not 400
        }
    }
    
}
