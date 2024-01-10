using libCommon.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommon.Interfaces
{
    public interface ISandPathFollower
    {
        /// <summary>
        /// 执行指定的路径
        /// </summary>
        /// <param name="path">路径</param>
        public void RunSandPath(Queue<SanderStatusPoint> path);

        /// <summary>
        /// 暂停执行
        /// </summary>
        /// <exception cref="InvalidOperationException">打磨流程当前不在执行</exception>
        public void Pause();

        /// <summary>
        /// 继续执行
        /// </summary>
        /// <exception cref="InvalidOperationException">打磨流程没有暂停</exception>
        public void Resume();

        /// <summary>
        /// 停止执行
        /// </summary>
        /// <exception cref="InvalidOperationException">当前流程不在运行或无法停止</exception>
        public void Stop();
    }
}
