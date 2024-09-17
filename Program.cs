using System.Globalization;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Xml;

namespace CsharpFundamental_Basic2
{
    internal class Program
    {
        public enum Color 
        {
            Red,
            Green,
            Blue,
            White,
            Yellow, 
            black

        
        }

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Please select an Option ?");

                Console.WriteLine("[1] Change BackGround Color \t\t [2] Change Foreground Color ");
                string Selected_Option = Console.ReadLine();

                foreach (var color in Enum.GetNames(typeof(ConsoleColor)))
                    Console.WriteLine($"{color}");

                Console.Write("Please Enter Color Name : ");
                string Colorname = Console.ReadLine();

                ConsoleColor Selectedcolor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Colorname, true);

                if (Selected_Option == "1")
                    Console.BackgroundColor = Selectedcolor;
                else if (Selected_Option == "2")
                    Console.ForegroundColor = Selectedcolor;
                else
                    Console.WriteLine("invalid option ");
            }
        }

        //string colorname = "red";
        //Color color = (Color)Enum.Parse(typeof(Color), colorname,true);
        //Console.WriteLine($"{color}={(int)color}");

        //==============================================


        //foreach(var color in Enum.GetNames(typeof(Color)))
        //    {
        //      Console.WriteLine($"{color}={(int) Enum.Parse(typeof(Color), color)}");
        //    }



    }
}
