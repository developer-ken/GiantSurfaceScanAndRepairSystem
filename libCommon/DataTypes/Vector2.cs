using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommon.DataTypes
{
    public class Vector2
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Vector2(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
