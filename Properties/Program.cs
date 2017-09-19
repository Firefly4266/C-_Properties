using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Color tree = new Color(123, 233, 10, 35);
            Console.WriteLine($"\n alpha value: {tree.GetAlpha()}\n");
            Console.WriteLine($"\n Grayscale value: {tree.GrayScale()}\n");
            Ball ball = new Ball(12, 155);
            ball.Throw();
            ball.Throw();
            ball.Throw();
            ball.TimesThrown();
            ball.Pop();
            ball.Throw();
            Console.WriteLine($"\n The ball size is now {ball.GetSize()}\n");
        }
    }
}
