using DJeyeMouseWrapper.Behaviors;
using NeeqDMIs.Eyetracking.Tobii;
using NeeqDMIs.Keyboard;
using NeeqDMIs.Mouse;

namespace DJeyeMouseWrapper.Modules
{
    /// <summary>
    /// This will contains all the modules
    /// </summary>
    internal static class Rack
    {
        public static MappingModule MappingModule { get; set; }
        public static RenderingModule RenderingModule { get; set; }
        public static TobiiModule TobiiModule { get; set; }
        public static KeyboardModule KeyboardModule { get; set; }
        public static SavingSystem SavingSystem { get; set; }
        public static DJeyeWrapperSettings UserSettings { get; set; }
        public static BBmouseClicks BBmouseClicks { get; set; }
        public static MouseModule MouseModule { get; set; }

        public static void LoadSettings()
        {
            
        }

        // TODO declare here all the other modules!
    }
}