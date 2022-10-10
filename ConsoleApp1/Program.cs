using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rect = new Rectangle(10, 20);
            Circle cir = new Circle(10);
            //Console.WriteLine($"사각형의 넓이 : {rect.Area()}");
            //Console.WriteLine($"원의넓이 : {cir.Area()}");

            PrintArea(rect);
            PrintArea(cir);

        }

        static void PrintArea(IFigure obj)
        {
            Console.WriteLine($"{obj.GetType().FullName}의 면적은 : {obj.Area()}");
        }
    }
}
