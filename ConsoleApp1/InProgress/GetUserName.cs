using System;
using System.Collections.Generic;
using System.Text;
using Console = Colorful.Console;

namespace ConsoleApp1
{
    class GetUserName
    {
        public static string getName()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
    }
}
