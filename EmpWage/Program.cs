namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random   = new Random(); 
            int ispresent = random.Next(2);
            if(ispresent == 0)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is not present");
            }
        }
    }
}