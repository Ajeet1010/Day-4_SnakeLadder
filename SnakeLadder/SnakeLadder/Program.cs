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
                Console.WriteLine("Choose the option to perform the operation:-  1) Start \n 2) \n 3) \n4)  \n 5)  \n" +
                        " 6)  \n 7)  \n " +
                        "Enter the no to operate: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Start start = new Start();
                        start.Dice();
                        break;


                }
            }
        }

    }
}