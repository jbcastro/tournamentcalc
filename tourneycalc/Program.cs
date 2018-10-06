using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcaRect
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompting the user to enter the length
            Console.WriteLine("What is the level 1 BB");
            double level1 = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the level 2 BB");
            double level2 = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the level 3 BB");
            double level3 = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the level 4 BB");
            double level4 = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the level 5 BB");
            double level5 = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the level 6 BB");
            double level6 = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the level 7 BB");
            double level7 = double.Parse(Console.ReadLine());

            //prompting the user to enter width
            Console.WriteLine("What is the starting stack");
            double stack = double.Parse(Console.ReadLine());

            

            //math for area
            double blinds = Calculateblinds((level1+ level2+ level3 +level4 + level5+ level6 + level7)*1.5);
            //math for perimeter
            double per = CalculaterPer(stack - blinds);

            //giving the user reults
            Console.WriteLine("The remaining chips you will have left is " + per );
            
            Console.Read();
        }
        //static for area
        public static double Calculateblinds(double length)
        {
            //I'm not sure why entering just length does the math right. I understand working up "calculatearea" 
            //is width*length but I'm not sure why I can just enter length and it comes out
            double result = length;
            return result;
        }




        //static for perimeter
        public static double CalculaterPer(double width)



        {
            double result = width;
            return result;


        }


    }
}
