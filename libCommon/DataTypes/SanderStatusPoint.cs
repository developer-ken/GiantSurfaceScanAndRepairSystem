using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace libCommon.DataTypes
{
    public class SanderStatusPoint
    {
        public Vector3 Position;
        public Vector2 Rotation;
        public double Force;
        public bool SanderEnabled;
    }
}
