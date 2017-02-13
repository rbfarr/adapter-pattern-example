using System;

namespace AdapterExample.Shapes
{
    class LegacyRectangle
    {
        private readonly int _width;
        private readonly int _height;

        /* LegacyRectangle is created in terms of width and height */

        public LegacyRectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public void GetArea()
        {
            Console.WriteLine("Area is {0}", _width * _height);
        }
    }
}
