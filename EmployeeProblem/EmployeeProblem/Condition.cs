using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem
{
    public class Condition
    {
        public const int isFulltime = 1;
        public const int isParttime = 2;
        public const int Hourwage = 20;
        public const int workmonth = 20;
        public const int max_workdays = 2;
        public void Wage()
        {

            int emphrs = 0, totalemphrs = 0, totalworkingdays = 0;
            while (totalemphrs <= max_workdays && totalworkingdays < workmonth)
            {
                totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case isFulltime:
                        Console.WriteLine("Full time employee");
                        emphrs = 8;
                        break;
                    case isParttime:
                        Console.WriteLine("part time employee");
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
                totalemphrs += emphrs;
                Console.WriteLine("Days:" + totalworkingdays + "Employee hrs : " + emphrs);
            }
            int totalempwage = totalemphrs * Hourwage;
            Console.WriteLine("Total employee wage is: " + totalempwage);

        }
    }
}
