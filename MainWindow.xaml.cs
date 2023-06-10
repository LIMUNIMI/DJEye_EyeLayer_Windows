using DJeyeMouseWrapper.Modules;
using DJeyeMouseWrapper.Setups;
using NeeqDMIs.Eyetracking.PointFilters;
using NeeqDMIs.Template;
using System.Windows;

namespace DJeyeMouseWrapper
{
    /// <summary>
    /// Interaction logic for the instrument window
    /// </summary>
    public partial class MainWindow : Window
    {
        private ISetup Setup;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void UpdateIndicators()
        {
            txtBlinkThresh.Text = Rack.UserSettings.BlinkThresholdSamples.ToString();
            txtScrollDeadzone.Text = Rack.UserSettings.DeadzoneSize.ToString();
            txtScrollSpeed.Text = Rack.UserSettings.ScrollSpeedMilliseconds.ToString();
            txtSmooth.Text = Rack.UserSettings.FilterWeight.ToString("0.00");
            txtWinkThresh.Text = Rack.UserSettings.WinkThresholdSamples.ToString();
        }

        private void btnBlinkThreshM_Click(object sender, RoutedEventArgs e)
        {
            Rack.UserSettings.BlinkThresholdSamples -= 1;
            if (Rack.UserSettings.BlinkThresholdSamples < 0)
            {
                Rack.UserSettings.BlinkThresholdSamples = 0;
            }

            Rack.BBmouseClicks.DCThresh = Rack.UserSettings.BlinkThresholdSamples;
            UpdateIndicators();
        }

        private void btnBlinkThreshP_Click(object sender, RoutedEventArgs e)
        {
            Rack.UserSettings.BlinkThresholdSamples += 1;

            Rack.BBmouseClicks.DCThresh = Rack.UserSettings.BlinkThresholdSamples;
            UpdateIndicators();
        }

        private void btnScrollDeadzoneM_Click(object sender, RoutedEventArgs e)
        {
            Rack.UserSettings.DeadzoneSize -= 5;
            if (Rack.UserSettings.DeadzoneSize < 0)
            {
                Rack.UserSettings.DeadzoneSize = 0;
            }
            UpdateIndicators();
        }

        private void btnScrollDeadzoneP_Click(object sender, RoutedEventArgs e)
        {
            Rack.UserSettings.DeadzoneSize += 5;
            UpdateIndicators();
        }

        private void btnScrollSpeedM_Click(object sender, RoutedEventArgs e)
        {
            Rack.UserSettings.ScrollSpeedMilliseconds -= 10;
            if (Rack.UserSettings.ScrollSpeedMilliseconds < 100)
            {
                Rack.UserSettings.ScrollSpeedMilliseconds = 100;
            }
            UpdateIndicators();
        }

        private void btnScrollSpeedP_Click(object sender, RoutedEventArgs e)
        {
            Rack.UserSettings.ScrollSpeedMilliseconds += 10;
            UpdateIndicators();
        }

        private void btnSmoothM_Click(object sender, RoutedEventArgs e)
        {
            Rack.UserSettings.FilterWeight -= 0.01f;
            if (Rack.UserSettings.FilterWeight < 0.01f)
            {
                Rack.UserSettings.FilterWeight = 0.01f;
            }

            Rack.TobiiModule.MouseEmulator.Filter = new PointFilterMAExpDecaying(Rack.UserSettings.FilterWeight);
            UpdateIndicators();
        }

        private void btnSmoothP_Click(object sender, RoutedEventArgs e)
        {
            Rack.UserSettings.FilterWeight += 0.01f;
            if (Rack.UserSettings.FilterWeight > 1f)
            {
                Rack.UserSettings.FilterWeight = 1f;
            }

            Rack.TobiiModule.MouseEmulator.Filter = new PointFilterMAExpDecaying(Rack.UserSettings.FilterWeight);
            UpdateIndicators();
        }

        private void btnWinkThreshM_Click(object sender, RoutedEventArgs e)
        {
            Rack.UserSettings.WinkThresholdSamples -= 1;
            if (Rack.UserSettings.WinkThresholdSamples < 0)
            {
                Rack.UserSettings.WinkThresholdSamples = 0;
            }

            Rack.BBmouseClicks.LCThresh = Rack.UserSettings.WinkThresholdSamples;
            Rack.BBmouseClicks.DCThresh = Rack.UserSettings.WinkThresholdSamples;
            UpdateIndicators();
        }

        private void btnWinkThreshP_Click(object sender, RoutedEventArgs e)
        {
            Rack.UserSettings.WinkThresholdSamples += 1;

            Rack.BBmouseClicks.LCThresh = Rack.UserSettings.WinkThresholdSamples;
            Rack.BBmouseClicks.RCThresh = Rack.UserSettings.WinkThresholdSamples;
            UpdateIndicators();
        }

        private void cbxEnabled_Checked(object sender, RoutedEventArgs e)
        {
            Rack.MappingModule.Enabled = (bool)cbxEnabled.IsChecked;
        }

        private void cbxEnabled_Unchecked(object sender, RoutedEventArgs e)
        {
            Rack.MappingModule.Enabled = (bool)cbxEnabled.IsChecked;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Setup.Dispose();
        }

        /// <summary>
        /// This method will be called when the window finished loading. A good moment to call a setup
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Setup = new DefaultSetup(this);
            Setup.Setup();
            UpdateIndicators();
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            txtTest.Text = Rack.TobiiModule.LastEyePositionData.LeftEye.Y.ToString();
        }
    }
}