using libCommon.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace libCommon.Interfaces
{
    public interface IScanner
    {
        /// <summary>
        /// 开始扫描
        /// </summary>
        /// <param name="processUpdateCallback">扫描结果更新回调</param>
        /// <returns>最终扫描结果点云</returns>
        public Task<PointCloud> Scan(Action<PointCloud,Vector2> processUpdateCallback);

        /// <summary>
        /// 暂停扫描。挂起扫描任务，扫描头不移动。
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">扫描流程当前不在执行</exception>
        public Task Pause();

        /// <summary>
        /// 继续被暂停的扫描，从上次挂起位置继续执行。
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">扫描流程没有暂停</exception>
        public Task Resume();

        /// <summary>
        /// 停止扫描。释放当前任务/挂起的任务，扫描头不会移动。
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">当前流程不在运行或无法停止</exception>
        public Task Stop();

        /// <summary>
        /// 移动扫描头到泊位
        /// </summary>
        /// <returns></returns>
        public Task Park();
    }
}
