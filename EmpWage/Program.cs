namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME=1;
            int EMP_RATE_PER_HOUR = 20;
            int empHr;
            int empWage;
            Random random   = new Random(); 
            int ispresent = random.Next(2);
            if(ispresent == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                empHr = 8;
            }
            else
            {
                Console.WriteLine("Employee is not present");
                empHr = 0;
            }
            empWage=EMP_RATE_PER_HOUR * empHr;
            Console.WriteLine($"Wage of the employee is :- {empWage}");
        }
    }
}