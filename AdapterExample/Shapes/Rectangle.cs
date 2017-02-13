using System;

namespace AdapterExample.Shapes
{
    class Rectangle : IShape
    {
        private readonly LegacyRectangle _legacyRectangle;

        /* Now, we create Rectangles in terms of two sets of (x,y) coordinates because reasons. */

        public Rectangle(int x1, int y1, int x2, int y2)
        {
            var width = Math.Abs(x2-x1);
            var height = Math.Abs(y2-y1);

            _legacyRectangle = new LegacyRectangle(width, height);
        }

        public void CalculateArea()
        {
            _legacyRectangle.GetArea();
        }
    }
}
