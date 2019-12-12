using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab3
{
    class Program
    {

        static void Main()
        {
            Point p = new Point();
            p.line1 = ("|++");
            p.line2 = ("|  +");
            p.line3 = ("|++");
            p.line4 = ("|");
            Console.WriteLine("Выполнил Васильев и Дружинина. 18СН1с.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(" Введите где расположить рисунок. Бип-бип!");
            Console.WriteLine(" Координата Х = ");
            p.x = int.Parse(Console.ReadLine());
            Console.WriteLine(" Координата Y = ");
            p.y = int.Parse(Console.ReadLine());
            Console.Clear();
            p.Draw();
            Console.ReadKey();
        }

    }
}
