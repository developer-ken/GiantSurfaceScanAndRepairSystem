using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using libCommon.DataTypes;
using OpenCvSharp;

namespace libCommon.Interfaces
{
    public interface ISandPathPlanner
    {
        /// <summary>
        /// 传入当前点云
        /// </summary>
        /// <param name="cloud">点云</param>
        public void SetPointcloud(PointCloud cloud);

        /// <summary>
        /// 添加一个缺陷点
        /// </summary>
        /// <param name="position">缺陷点</param>
        public void AddDefectPoint(Vector3 position);

        /// <summary>
        /// 计算打磨路径
        /// </summary>
        /// <returns>一个队列，包含路径上的每一个路点。</returns>
        public Task<Queue<SanderStatusPoint>> GetPath();
    }
}
