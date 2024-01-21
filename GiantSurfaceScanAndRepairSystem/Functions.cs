using libCommon;
using libCommon.DataTypes;
using libCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GiantSurfaceScanAndRepairSystem
{
    public partial class Form1
    {
        IMotorController motor_scanner_x1;
        IMotorController motor_scanner_x2;
        IMotorController motor_scanner_y;

        IMotorController motor_sander_x1;
        IMotorController motor_sander_x2;
        IMotorController motor_sander_y;

        IAxisController axisController;
        IDefectionDetector defectionDetector;
        ISander sander;
        IScanner scanner;
        ISandPathPlanner sandPathPlanner;

        PointCloud pointCloud;
        List<Vector3> defections;

        private async Task RunScan()
        {
            await sander.Park();
            pointCloud = await scanner.Scan(ScanProgressUpdate);
            await scanner.Park();
        }

        private async Task RunDetect()
        {
            defections = await defectionDetector.GetDefectionPositions(pointCloud);
        }

        private async Task RunSand()
        {
            await scanner.Park();
            sandPathPlanner.SetPointcloud(pointCloud);
            foreach (var defection in defections)
            {
                sandPathPlanner.AddDefectPoint(defection);
            }
            var sandpath = await sandPathPlanner.GetPath();
            await sander.RunSandPath(sandpath);
            await sander.Park();
        }

        private async Task Run()
        {
            await RunScan();
            await RunDetect();
            await RunSand();
        }

        private void ScanProgressUpdate(PointCloud cloud,Vector2 currentpos)
        {

        }
    }
}
