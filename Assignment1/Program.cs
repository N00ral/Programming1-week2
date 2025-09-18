namespace Assignment1
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
            Console.WriteLine(" Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            // method call
            bool result = IsAdult(age);
            if (result)
            {
                Console.WriteLine(" You are an adult.");
            }
            else
            {
                Console.WriteLine(" You are not an adult.");
            }
        }

        public bool IsAdult(int age)
        {
            return age >= 18;
        }
    }
}
