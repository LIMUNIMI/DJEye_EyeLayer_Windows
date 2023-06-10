using System;
using System.Windows.Threading;

namespace DJeyeMouseWrapper.Modules
{
    public class RenderingModule : IDisposable
    {
        public RenderingModule(MainWindow instrumentWindow)
        {
            InstrumentWindow = instrumentWindow;
            DispatcherTimer = new DispatcherTimer();
            DispatcherTimer.Interval = new TimeSpan(10000); // 10000 nanoseconds = one millisecond
            DispatcherTimer.Tick += DispatcherUpdate;
        }

        private DispatcherTimer DispatcherTimer { get; set; }
        private MainWindow InstrumentWindow { get; set; }

        public void Dispose()
        {
            DispatcherTimer.Stop();
        }

        /// <summary>
        /// Starts the rendering timer
        /// </summary>
        public void StartRendering()
        {
            DispatcherTimer.Start();
        }

        /// <summary>
        /// Stops the rendering timer
        /// </summary>
        public void StopRendering()
        {
            DispatcherTimer.Stop();
        }

        /// <summary>
        /// This method will be called every time the dispatcher timer is triggered, to update graphics.
        /// </summary>
        private void DispatcherUpdate(object sender, EventArgs e)
        {
            // TODO edit this! Put all the rendering actions here!
        }
    }
}