using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using OpenCvSharp;

namespace libCommon.DataTypes
{
    public class PointCloud
    {
        public Mat DepthMat;
        public double DepthRatio;
        public double XYRatio;
        public Vector3[] Points
        {
            get
            {
                Vector3[] points = new Vector3[DepthMat.Width * DepthMat.Height];

                throw new NotImplementedException();
                //Foreach pixels in the mat, add it to a point
                return points;
            }
        }
    }
}
