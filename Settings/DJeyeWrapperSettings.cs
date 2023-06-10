using System;

namespace DJeye_Wrapper
{
    [Serializable]
    public class DJeyeWrapperSettings
    {
        public DJeyeWrapperSettings()
        {

        }

        public DJeyeWrapperSettings(int deadzoneSize, float filterWeight, int winkThresholdSamples, int blinkThresholdSamples, int wheelScrollMilliseconds)
        {
            DeadzoneSize = deadzoneSize;
            FilterWeight = filterWeight;
            WinkThresholdSamples = winkThresholdSamples;
            BlinkThresholdSamples = blinkThresholdSamples;
            ScrollSpeedMilliseconds = wheelScrollMilliseconds;
        }

        public int DeadzoneSize { get; set; }
        public float FilterWeight { get; set; }
        public int WinkThresholdSamples { get; set; }
        public int BlinkThresholdSamples { get; set; }
        public int ScrollSpeedMilliseconds { get; set; }
    }
}