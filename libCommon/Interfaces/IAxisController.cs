using libCommon.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace libCommon.Interfaces
{
    public interface IAxisController
    {
        /// <summary>
        /// 检测装置当前位置
        /// </summary>
        public Vector2 DetectorCurrentPosition { get; }

        /// <summary>
        /// 执行器当前位置
        /// </summary>
        public Vector3 ActuatorCurrentPosition { get; }

        /// <summary>
        /// 将检测装置的指定轴回零。检测装置不存在Z轴，对检测装置Z轴回零会触发异常。
        /// </summary>
        /// <exception cref="InvalidOperationException">当对检测装置Z轴回零时触发</exception>
        public Task HomeDetectorAxis(AxisSelection axis);
        
        /// <summary>
        /// 将执行器的指定轴回零
        /// </summary>
        public Task HomeActuatorAxis(AxisSelection axis);

        /// <summary>
        /// 全部回零
        /// </summary>
        public Task HomeAxis();

        /// <summary>
        /// 移动检测头到指定二维坐标
        /// </summary>
        /// <param name="dest">指定二维坐标</param>
        public Task MoveDetector(Vector2 dest);

        /// <summary>
        /// 移动检测头到指定三维坐标上方。请注意检测头不会进行Z轴运动。
        /// </summary>
        /// <param name="dest">指定三维坐标</param>
        public Task MoveDetector(Vector3 dest);

        /// <summary>
        /// 移动执行器到指定三维坐标。执行器会出现Z轴运动。
        /// </summary>
        /// <param name="dest">指定三维坐标</param>
        public Task MoveActurator(Vector3 dest);

        /// <summary>
        /// 立即刹停所有电机。
        /// </summary>
        public Task MotorsBrake();

        /// <summary>
        /// 紧急停止所有电机。此操作只释放电机供电，电机可能会惯性滑行。
        /// </summary>
        public Task EmergencyMotorOff();
    }
}
