using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class Snake
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose the option to perform the operation:-  1) Start \n 2) Outcome after roll \n 3) Checks for options \n" +
                    "4)  \n 5)  \n" +
                        " 6)  \n 7)  \n " +
                        "Enter the no to operate: ");
                int options = Convert.ToInt32(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        Start start = new Start();
                        start.Dice();
                        break;
                    case 2:
                        Roll roll= new Roll();
                        roll.Outcome();
                        break;
                    case 3:
                        Option option = new Option();
                        option.Check();
                        break;



                }
            }
        }

    }
}