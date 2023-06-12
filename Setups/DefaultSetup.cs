using BlankADMI.Behaviors;
using DJeyeMouseWrapper.Behaviors;
using DJeyeMouseWrapper.Modules;
using NeeqDMIs.Eyetracking.MouseEmulator;
using NeeqDMIs.Eyetracking.PointFilters;
using NeeqDMIs.Eyetracking.Tobii;
using NeeqDMIs.Filters.ValueFilters;
using NeeqDMIs.Keyboard;
using NeeqDMIs.Mouse;
using NeeqDMIs.Template;
using RawInputProcessor;
using System;
using System.Collections.Generic;
using System.Windows.Interop;

namespace DJeyeMouseWrapper.Setups
{
    public class DefaultSetup : ISetup
    {
        public DefaultSetup(MainWindow mainWindow)
        {
            MainWindow = mainWindow;
            Disposables = new List<IDisposable>();
        }

        private List<IDisposable> Disposables { get; set; }
        private MainWindow MainWindow { get; set; }

        /// <summary>
        /// Launches the setup actions for the instrument
        /// </summary>
        public void Setup()
        {
            // Make saving system and spawn settings
            Rack.SavingSystem = new SavingSystem();
            Rack.UserSettings = new DefaultSettings();
            Rack.UserSettings = Rack.SavingSystem.LoadSettings();

            // Modules spawn
            Rack.MappingModule = new MappingModule();
            Rack.RenderingModule = new RenderingModule(MainWindow);
            Rack.TobiiModule = new TobiiModule(Tobii.Interaction.Framework.GazePointDataMode.Unfiltered);
            Rack.MouseModule = new MouseModule(10000, 1.0f, new DoubleFilterBypass(), new DoubleFilterBypass());
            Rack.KeyboardModule = new KeyboardModule(new WindowInteropHelper(MainWindow).Handle, RawInputCaptureMode.ForegroundAndBackground);

            // Mouse emulator spawn
            Rack.TobiiModule.MouseEmulator = new MouseEmulatorModule(new PointFilterMAExpDecaying(Rack.UserSettings.FilterWeight));

            // Blink Behaviors trim
            Rack.BBmouseClicks = new BBmouseClicks();
            Rack.BBmouseClicks.DCThresh = Rack.UserSettings.BlinkThresholdSamples;
            Rack.BBmouseClicks.LCThresh = Rack.UserSettings.WinkThresholdSamples;
            Rack.BBmouseClicks.RCThresh = Rack.UserSettings.WinkThresholdSamples;

            // Behaviors spawn
            Rack.TobiiModule.BlinkBehaviors.Add(Rack.BBmouseClicks);
            Rack.TobiiModule.BlinkBehaviors.Add(new BBsuppressHorizontalPeak());
            Rack.KeyboardModule.KeyboardBehaviors.Add(new KBshortcuts());

            // Add disposables to list
            Disposables.Add(Rack.RenderingModule);

            // You will probably want to leave this at the end!
            // NOTE: Nothing to render...
            // Rack.RenderingModule.StartRendering();
        }

        /// <summary>
        /// This method will dispose all the disposable modules. Call on program exit.
        /// </summary>
        public void Dispose()
        {
            Rack.SavingSystem.SaveSettings(Rack.UserSettings);

            foreach (IDisposable disposable in Disposables)
            {
                disposable.Dispose();
            }
        }
    }
}