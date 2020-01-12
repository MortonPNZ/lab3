using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Point
    {
        public int x;
        public int y;
        public string line1, line2, line3, line4;


        public void SetX(int x)
        {
            if (x >= 0)
                this.x = x;
            else
                throw new Exception("Значение не может быть отрицательным");

        }
        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                throw new Exception("Значение не может быть отрицательным");
        }
        public void SetSym(String ine1, String ine2, String ine3, String ine4)
        {
            line1 = ine1;
            line2 = ine1;
            line3 = ine3;
            line4 = ine4;

        }
        public void Draw()
        {
           
            Console.SetCursorPosition(x, y);
            Console.Write(line1);
            y = y + 1;
            Console.SetCursorPosition(x, y);
            Console.Write(line2);
            y = y + 1;
            Console.SetCursorPosition(x, y);
            Console.Write(line3);
            y = y + 1;
            Console.SetCursorPosition(x, y);
            Console.Write(line4);
            y = y + 1;
        }
    }
}
