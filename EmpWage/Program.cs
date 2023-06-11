namespace EmpWage
{
    internal class CompanyEmpWage
    {
        public string Company;
        public int EmpWagePerHour, WorkingDaysPerMonth, TotalWorkingHours, totalEmpWage;

        public CompanyEmpWage(string Company, int EmpWagePerHour, int WorkingDaysPerMonth, int TotalWorkingHours)
        {
            this.Company = Company;
            this.EmpWagePerHour = EmpWagePerHour;
            this.WorkingDaysPerMonth = WorkingDaysPerMonth;
            this.TotalWorkingHours = TotalWorkingHours;
        }

        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string ToString()
        {
            return "Total Employee Wage in " + this.Company + " Company is: " + this.totalEmpWage;
        }
    }
    internal class EmployeeWageBuilder
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private int numberOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmployeeWageBuilder()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void AddCompanyEmpWage(string Company, int EmpWagePerHour, int WorkingDaysPerMonth, int TotalWorkingHours)
        {
            companyEmpWageArray[this.numberOfCompany] = new CompanyEmpWage(Company, EmpWagePerHour, WorkingDaysPerMonth, TotalWorkingHours);
            numberOfCompany++;
        }

        public void ComputeEmpWage()
        {
            for (int i = 0; i < numberOfCompany; i++)
            {
                companyEmpWageArray[i].SetTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].ToString());
            }
        }

        public int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalWorkingDays = 0, totalEmpHours = 0;
            while (totalEmpHours <= companyEmpWage.TotalWorkingHours && totalWorkingDays < companyEmpWage.WorkingDaysPerMonth)
            {
                totalWorkingDays++;
                Random random = new Random();
                double empCheck = random.Next(3);
                switch ((int)empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHours += empHrs;
                Console.WriteLine("Day " + totalWorkingDays + "- Employee Hours: " + empHrs);
            }
            return totalEmpHours * companyEmpWage.EmpWagePerHour;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageBuilder employeeWageBuilder = new EmployeeWageBuilder();
            employeeWageBuilder.AddCompanyEmpWage("DMart", 20, 2, 10);
            employeeWageBuilder.AddCompanyEmpWage("Reliance", 10, 4, 20);
            employeeWageBuilder.ComputeEmpWage();
        }
    }
}