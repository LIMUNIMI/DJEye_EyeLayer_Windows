using DJeye_Wrapper.Modules;
using NeeqDMIs.MicroLibrary;
using NeeqDMIs.Mouse;

namespace DJeye_Wrapper
{
    /// <summary>
    /// A blank mapping module, which will contain the instrument mapping. Rename and edit!
    /// </summary>
    public class MappingModule
    {
        private readonly int SCROLLING_SPEED = 120;
        private bool enabled = false;

        public bool Enabled
        {
            get { return enabled; }
            set
            {
                enabled = value;
                ReceiveHoldScroll_End();
                Rack.TobiiModule.MouseEmulator.Enabled = value;
            }
        }

        public bool IsHoldScroll { get; private set; } = false;
        private double HoldScrollY { get; set; }

        private MicroTimer TimerScroll { get; set; }

        internal void ReceiveClickInput()
        {
            if (Enabled)
            {
                Rack.MouseModule.SendMouseButtonEvent(MouseButtonFlags.LeftDown);
                Rack.MouseModule.SendMouseButtonEvent(MouseButtonFlags.LeftUp);
            }
        }

        internal void ReceiveDoubleClickInput()
        {
            if (Enabled)
            {
                Rack.MouseModule.SendMouseButtonEvent(MouseButtonFlags.LeftDown);
                Rack.MouseModule.SendMouseButtonEvent(MouseButtonFlags.LeftUp);
                Rack.MouseModule.SendMouseButtonEvent(MouseButtonFlags.LeftDown);
                Rack.MouseModule.SendMouseButtonEvent(MouseButtonFlags.LeftUp);
            }
        }

        internal void ReceiveHoldScroll_End()
        {
            IsHoldScroll = false;
            if (TimerScroll != null)
            {
                TimerScroll.Abort();
            }
            if (Enabled)
            {
                Rack.TobiiModule.MouseEmulator.Enabled = true;
            }
        }

        internal void ReceiveHoldScroll_Start()
        {
            if (Enabled)
            {
                IsHoldScroll = true;
                HoldScrollY = Rack.TobiiModule.LastEyePositionData.LeftEye.Y;
                Rack.TobiiModule.MouseEmulator.Enabled = false;
                TimerScroll = new MicroTimer();
                TimerScroll.Interval = 1000 * Rack.UserSettings.ScrollSpeedMilliseconds;
                TimerScroll.MicroTimerElapsed += TimerScroll_MicroTimerElapsed;
                TimerScroll.Start();
            }
        }

        private void TimerScroll_MicroTimerElapsed(object sender, MicroTimerEventArgs e)
        {
            double verticalOffset = Rack.TobiiModule.LastEyePositionData.LeftEye.Y - HoldScrollY;
            if(verticalOffset > Rack.UserSettings.DeadzoneSize)
            {
                Rack.MouseModule.SendMouseWheelMove(SCROLLING_SPEED);
            }
            else if(verticalOffset < -Rack.UserSettings.DeadzoneSize)
            {
                Rack.MouseModule.SendMouseWheelMove(-SCROLLING_SPEED);
            }
           
        }
    }
}