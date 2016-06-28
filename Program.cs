using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        static Dictionary<char, ConsoleColor> s_Map = new Dictionary<char, ConsoleColor>()
        {
            {' ', ConsoleColor.White},
            {'x', ConsoleColor.Black},
            {'*', ConsoleColor.Red},
        };

        const string c_HelloString = "Hello to...";
        const string c_GoodbyeString = "...from .NET Core!";

        public static void Main(string[] args)
        {
           Console.Clear();
           Console.WriteLine(c_HelloString);
           PrintImage(Shadowman);
           Console.Write(new string(' ', Shadowman[0].Length - c_GoodbyeString.Length));
           Console.WriteLine(c_GoodbyeString);
        }

        static void PrintImage(string[] lines)
        {
            foreach (string line in lines)
            {
                foreach (char c in line)
                {
                    Console.ForegroundColor = s_Map[c];
                    Console.BackgroundColor = s_Map[c];
                    Console.Write(' ');
                }

                Console.ResetColor();
                Console.WriteLine();
            }
        }

        public static readonly string[] Shadowman = new[]
        {
            "                                             xxxxxxxxxxxxxx                                             ",
            "                                    xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx                                    ",
            "                               xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx                               ",
            "                           xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx                           ",
            "                        xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx                        ",
            "                     xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx                     ",
            "                   xxxxxxxxxxxxxxxx********************************xxxxxxxxxxxxxxxxxx                   ",
            "                xxxxxxxxxxxxxxxxx*************************xxxxxxxx***xxxxxxxxxxxxxxxxxx                 ",
            "              xxxxxxxxxxxxxxxxxx****************************xxxxxx*****xxxxxxxxxxxxxxxxxx               ",
            "             xxxxxxxxxxxxxxxxxxx****************************************xxxxxxxxxxxxxxxxxxx             ",
            "           xxxxxxxxxxxxxxxxxxxx****xxxx**********************************xxxxxxxxxxxxxxxxxxxx           ",
            "          xxxxxxxxxxxxxxxxxxxxx****xxxxxxxxxxxxxxxx***********************xxxxxxxxxxxxxxxxxxxx          ",
            "        xxxxxxxxxxxxxxxxxxxxxxx******xxxxxxxxx****************************xxxxxxxxxxxxxxxxxxxxx         ",
            "       xxxxxxxxxxxxxxxxxxxxxxx********xx***********************************xxxxxxxxxxxxxxxxxxxxxx       ",
            "      xxxxxxxxxxxxxxxxxxxxxxxx**********************************************xxxxxxxxxxxxxxxxxxxxxx      ",
            "     xxxxxxxxxxxxxxxxxxxxxxxxxx**********************************************xxxxxxxxxxxxxxxxxxxxxx     ",
            "     xxxxxxxxxx*************xxxxxx*******************************************xxxxxxxxxxxxxxxxxxxxxx     ",
            "    xxxxxxxx****************xxxxxxxxxxx***************************************xxxxxxxxxxxxxxxxxxxxxx    ",
            "   xxxxxxxxx*****************xxxxxxxxxxxxxxxxxx*******************************xxxxxxxxxxxxxxxxxxxxxxx   ",
            "   xxxxxxxxx******************xxxxxxxxxxxxxxxxxxxxxx**************************xx****xxxxxxxxxxxxxxxxx   ",
            "  xxxxxxxxxxx********************xxxxxxxxxxxxxxxxxxxxx***********************xx*********xxxxxxxxxxxxxx  ",
            "  xxxxxxxxxxxx***********************xxxxxxxxxxxxxxxxx**********************x**************xxxxxxxxxxx  ",
            "  xxxxxxxxxxxxxx**************************xxxxxxxxxxxxx*************************************xxxxxxxxxx  ",
            " xxxxxxxxxxxxxxxxx*******************************xxxxxxxx************************************xxxxxxxxxx ",
            " xxxxxxxxxxxxxxxxxxxx************************************************************************xxxxxxxxxx ",
            " xxxxxxxxxxxxxxxxxxxxxxx*********************************************************************xxxxxxxxxx ",
            " xxxxxxxxxxxxxxxxxxxxxxxxxx*****************************************************************xxxxxxxxxxx ",
            " xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx************************************************************xxxxxxxxxxxx ",
            " xxxxxxxxxxxxxxxxxxxxxxx      xxxxx*******************************************************xxxxxxxxxxxx  ",
            "  xxxxxxxxxxxxxxxxxxxxx         xxxxxxxx***********************************************xxxxxxxxxxxxxxx  ",
            "  xxxxxxxxxxxxxxxxxxxxx          xxxxxxxxxxxxx**************************************xxxxxxxxxxxxxxxxxx  ",
            "  xxxxxxxxxxxxxxxxxxxxxx               xxxxxxxxxxxxxx**************************xxxxxxxxxxxxxxxxxxxxxx   ",
            "   xxxxxxxxxxxxxxxxxxxxxx                xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx   ",
            "    xxxxxxxx          xxxxx                xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx    ",
            "                       xxxxxx                   xxx                        xxxxxxxxxxxxxxxxxxxxxxxxx    ",
            "                                                                          xxxxxxxxxxxxxxxxxxxxxxxxx     ",
            "                                                                          xxxxxxxxxxxxxxxxxxxxxxxx      ",
            "                                                       xxx    x           xxxxxxxxxxxxxxxxxxxxxxx       ",
            "                                                       xxxxxxxx          xxxxxxxxxxxxxxxxxxxxxxx        ",
            "                                                                        xxxxxxxxxx                      ",
            "                                                                       xxxxxxxx                         ",
            "                                                                     xxxxxxxx                           ",
            "                                                                    xxxxx                               ",
            "                                                                   xxxx                                 ",
            "                                                                 xxxx                                   ",
        };
    }
}
