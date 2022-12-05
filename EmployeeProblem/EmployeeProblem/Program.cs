using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem
{
    public class EmployeeProblem
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose the option to perform the operation:-  1) Attendance \n 2) Employee Wage \n 3)Power of 2 \n4) Harmonic \n 5) Factors \n" +
                    " 6) QueRem \n 7) Swapping \n 8) EvenOdd \n 9) Alphabet \n 10)Largest no\n" +
                    "Enter the no to operate: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Attendance attendance = new Attendance();
                        attendance.Preabs();
                        break;

                }
            }
        }
    }
}