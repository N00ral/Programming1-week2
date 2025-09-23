namespace Assignment4
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
            Console.WriteLine("Enter first number: ");
           int num1 = Convert.ToInt32(Console.ReadLine());  

            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Enter an operator (+, -, *, /): ");
            string op = Console.ReadLine();

            // Call the calculation method
            double result = Calculate(num1, num2, op);
            Console.WriteLine($"Result: {result}");
        }

        public double Calculate(double num1, double num2, string operation)
        {

            switch (operation)
            {
                case "+":
                    return Add(num1, num2);


                case "-":
                    return Subtract(num1, num2);

                case "*":
                    return Multiply(num1, num2);

                case "/":
                    return Divide(num1, num2);

                default:
                    Console.WriteLine("Invalid operator!");
                    return 0;
            }
        }
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            
            return a / b;
        }

    }
}  