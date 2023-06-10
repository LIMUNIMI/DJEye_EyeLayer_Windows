using NeeqDMIs.Music;
using System;

namespace DJeye_Wrapper
{
    [Serializable]
    internal class DefaultSettings : DJeyeWrapperSettings
    {
        public DefaultSettings() : base()
        {
            FilterWeight = 0.30f;
            WinkThresholdSamples = 3;
            BlinkThresholdSamples = 5;
            DeadzoneSize = 5;
            ScrollSpeedMilliseconds = 500;
        }
    }
}