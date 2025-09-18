namespace Assignment3
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
            Console.WriteLine(" Enter a number: ");

            int number = int.Parse(Console.ReadLine()); 

            // method call

            CheckNumber(number);
        }

        public void CheckNumber(int number)
        {
            if 
                (number > 0)
            { Console.WriteLine(" The number is positive."); } 

            else if
                (number < 0)
            { Console.WriteLine(" The number is negative."); } 

            else 
            { Console.WriteLine(" The number is zero."); }
        }


    }
}
