using libCommon.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommon.Interfaces
{
    public interface ISander
    {
        /// <summary>
        /// 是否已被暂停
        /// </summary>
        public bool IsPaused { get; }

        /// <summary>
        /// 当打磨头到达指定位点，准备开始打磨时触发。
        /// 提供正在打磨的位点编号，可通过返回值控制是否跳过此位点。
        /// </summary>
        public event Func<bool, int> OnSandBegin;

        /// <summary>
        /// 当打磨头结束打磨指定位点时触发。
        /// 提供刚才打磨的位点编号，可通过返回值控制是否跳过下一个位点。
        /// </summary>
        public event Func<bool, int> OnSandEnd;

        /// <summary>
        /// 执行指定的路径
        /// </summary>
        /// <param name="path">路径</param>
        /// <exception cref="Exceptions.CollisionException">运行中碰撞到物体触发保护</exception>
        public Task RunSandPath(Queue<SanderStatusPoint> path);

        /// <summary>
        /// 暂停执行
        /// </summary>
        /// <exception cref="InvalidOperationException">打磨流程当前不在执行</exception>
        public Task Pause();

        /// <summary>
        /// 继续执行
        /// </summary>
        /// <exception cref="InvalidOperationException">打磨流程没有暂停</exception>
        public Task Resume();

        /// <summary>
        /// 停止执行
        /// </summary>
        /// <exception cref="InvalidOperationException">当前流程不在运行或无法停止</exception>
        public Task Stop();

        /// <summary>
        /// 跳过当前打磨的位点，直接前往下一个位点。
        /// </summary>
        /// <returns></returns>
        public Task Skip();

        /// <summary>
        /// 打磨头进入泊位
        /// </summary>
        /// <returns></returns>
        public Task Park();

    }
}
