namespace Assignment2
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

            bool result = IsEven(number);
            if (result)
            {
                Console.WriteLine(" The number is even.");
            }
            else
            {
                Console.WriteLine(" The number is odd.");
            }

        }


          public bool IsEven(int number)
          {
            return number % 2 == 0;
          }


    }

}

