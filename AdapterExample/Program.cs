using System;
using AdapterExample.Shapes;

namespace AdapterExample
{
    class Program
    {
        /* Main() is the "client" that knows how to interact with our IShape interface. */

        static void Main()
        {
            IShape myRectangle = new Rectangle(0, 0, 10, 4);
            myRectangle.CalculateArea();

            Console.ReadLine();
        }
    }
}
