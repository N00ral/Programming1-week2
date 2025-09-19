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

        {
            switch (dayNumber)
            {
                case 1:
                   return("Monday");
                   
                case 2:
                   return("Tuesday");
                    
                case 3:
                   return("Wednesday");
                    
                case 4:
                   return("Thursday");
                    
                case 5:
                    return("Friday");
                    
                case 6:
                    return("Saturday");
                    
                case 7:
                    return("Sunday");
                    
                default:
                   return("Invalid day number! Please enter a number between 1 and 7.");
                    
            }
        }

    }


         
}
     

