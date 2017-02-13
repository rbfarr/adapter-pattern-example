using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample.Shapes
{
    class Rectangle : IShape
    {
        private readonly LegacyRectangle _legacyRectangle;

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
