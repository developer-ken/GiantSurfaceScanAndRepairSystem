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
        /// <exception cref="Exceptions.CollisionException">运行中碰撞到物体触发保护</exception>
        /// <exception cref="Exceptions.MoveOverrangeException">移动目标位置不可达</exception>
        /// <exception cref="Exceptions.HardwareException">发生意外的硬件错误</exception>
        public Task<List<Vector3>> GetDefectionPositions(PointCloud pointcloud);
    }
}
