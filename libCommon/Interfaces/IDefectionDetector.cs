using libCommon.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace libCommon.Interfaces
{
    public interface IDefectionDetector
    {
        /// <summary>
        /// 从点云获取缺陷位置
        /// </summary>
        /// <param name="pointcloud"></param>
        /// <returns></returns>
        public List<Vector3> GetDefectionPositions(PointCloud pointcloud);
    }
}
