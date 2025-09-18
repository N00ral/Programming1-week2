namespace Assignment6
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

            Console.WriteLine("Enter your score: ");
            int score = int.Parse(Console.ReadLine());

            // method call
            string grade = GetGrade(score);
            Console.WriteLine("Your letter grade is: " + grade);
        }

       public string GetGrade(int score)
        {
            if (score >= 90)
                return "A";
            else if (score >= 80)
                return "B";
            else if (score >= 70)
                return "C";
            else if (score >= 60)
                return "D";
            else
                return "F";
        }
    }
    
}
