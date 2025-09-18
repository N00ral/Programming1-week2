namespace Assignment8
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
            Console.WriteLine("Enter a number (1-7) to get the day of the week: ");

            int dayNumber = int.Parse(Console.ReadLine());

            // method call

            string day = GetDayOfWeek(dayNumber);

            Console.WriteLine("The day of the week is: " + day);
        }
        string GetDayOfWeek(int dayNumber)

        { return dayNumber switch

        {   
            1 => "Monday",
            2 => "Tuesday", 
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "Invalid input! Please enter a number between 1 and 7." }; 
        }
    }

}

