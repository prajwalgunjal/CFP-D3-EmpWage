namespace EmpWage
{
    internal class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int IS_PART_TIME = 0;
        public const int NO_OF_WORKING_DAYS = 2;
        static void Main(string[] args)
        {

            int empHr;
            int empWage;
            int TotalEmpWage=0;
            for (int i = 0; i < NO_OF_WORKING_DAYS; i++)
            {
                Random random = new Random();
                int ispresent = random.Next(3);

                switch (ispresent)
                {
                    case IS_FULL_TIME:
                        {
                            Console.WriteLine("Employee is present");
                            Console.WriteLine("FullTime");
                            empHr = 8;
                            break;
                        }

                    case IS_PART_TIME:
                        {
                            Console.WriteLine("Employee is present");
                            Console.WriteLine("parttime");
                            empHr = 4;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Emoployee is not present : ");
                            empHr = 0;
                            break;
                        }
                }
                empWage = EMP_RATE_PER_HOUR * empHr;
                TotalEmpWage += empWage;
                Console.WriteLine($"Wage of the employee is :- {empWage}");
            }
        }
    }
}