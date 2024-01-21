namespace GiantSurfaceScanAndRepairSystem
{
    public partial class Form1 : Form
    {

        int OClickMoveDistance => (int)moveamount.Value;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axisController.EmergencyMotorOff();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            axisController.HomeDetectorAxis(libCommon.DataTypes.AxisSelection.X);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            axisController.HomeDetectorAxis(libCommon.DataTypes.AxisSelection.Y);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            axisController.HomeActuatorAxis(libCommon.DataTypes.AxisSelection.X);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            axisController.HomeActuatorAxis(libCommon.DataTypes.AxisSelection.Y);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            axisController.HomeActuatorAxis(libCommon.DataTypes.AxisSelection.Z);
        }

        private void BtnZPlus_Click(object sender, EventArgs e)
        {
            if (move_scanner.Checked)
                axisController.MoveDetector(libCommon.DataTypes.AxisSelection.Z, OClickMoveDistance);
            else
                axisController.MoveActurator(libCommon.DataTypes.AxisSelection.Z, OClickMoveDistance);
        }

        private void BtnZReduce_Click(object sender, EventArgs e)
        {
            if (move_scanner.Checked)
                axisController.MoveDetector(libCommon.DataTypes.AxisSelection.Z, -OClickMoveDistance);
            else
                axisController.MoveActurator(libCommon.DataTypes.AxisSelection.Z, -OClickMoveDistance);
        }

        private void BtnYPlus_Click(object sender, EventArgs e)
        {
            if (move_scanner.Checked)
                axisController.MoveDetector(libCommon.DataTypes.AxisSelection.Y, OClickMoveDistance);
            else
                axisController.MoveActurator(libCommon.DataTypes.AxisSelection.Y, OClickMoveDistance);
        }

        private void BtnYReduce_Click(object sender, EventArgs e)
        {
            if (move_scanner.Checked)
                axisController.MoveDetector(libCommon.DataTypes.AxisSelection.Y, -OClickMoveDistance);
            else
                axisController.MoveActurator(libCommon.DataTypes.AxisSelection.Y, -OClickMoveDistance);
        }

        private void BtnXPlus_Click(object sender, EventArgs e)
        {
            if (move_scanner.Checked)
                axisController.MoveDetector(libCommon.DataTypes.AxisSelection.X, OClickMoveDistance);
            else
                axisController.MoveActurator(libCommon.DataTypes.AxisSelection.X, OClickMoveDistance);
        }

        private void BtnXReduce_Click(object sender, EventArgs e)
        {
            if (move_scanner.Checked)
                axisController.MoveDetector(libCommon.DataTypes.AxisSelection.X, -OClickMoveDistance);
            else
                axisController.MoveActurator(libCommon.DataTypes.AxisSelection.X, -OClickMoveDistance);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await RunScan();
        }

        private async void button17_Click(object sender, EventArgs e)
        {
            if (scanner.IsPaused)
                await scanner.Resume();
            else
                await scanner.Pause();
        }

        private async void button18_Click(object sender, EventArgs e)
        {
            await scanner.Stop();
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            await RunDetect();
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            await RunSand();
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            await sander.Skip();
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            if (sander.IsPaused)
                await sander.Resume();
            else
                await sander.Pause();
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            await sander.Stop();
        }

        private async void button16_Click(object sender, EventArgs e)
        {
            await Run();
        }
    }
}