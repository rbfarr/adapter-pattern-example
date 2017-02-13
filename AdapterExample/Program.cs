using System;
using AdapterExample.Shapes;

namespace AdapterExample
{
    class Program
    {
        static void Main()
        {
            var myRectangle = new Rectangle(0, 0, 10, 4);
            myRectangle.CalculateArea();

            Console.ReadLine();
        }
    }
}
