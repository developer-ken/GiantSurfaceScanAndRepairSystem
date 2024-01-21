using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommon.Interfaces
{
    public interface IMotorController
    {
        /// <summary>
        /// 触发回零
        /// </summary>
        public Task TriggerHome();

        /// <summary>
        /// 电机转动到设定位置
        /// </summary>
        /// <param name="dest">以脉冲数计量的目标位置</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.CollisionException">电机运行中发生堵转</exception>
        public Task MoveTo(uint dest);

        /// <summary>
        /// 刹车，保证停止在触发时的位置，如果因惯性超过位置会反向旋转修正
        /// </summary>
        /// <returns></returns>
        public Task Brake();

        /// <summary>
        /// 急停。此操作释放电机扭矩，不刹车
        /// </summary>
        /// <returns></returns>
        public Task EmergencyStop();

        /// <summary>
        /// 将电机从堵转保护中恢复
        /// </summary>
        /// <returns></returns>
        public Task FailsafeReset();

        /// <summary>
        /// 电机堵转保护是否触发
        /// </summary>
        public bool IsFailsafeTriggered { get; }
    }
}
