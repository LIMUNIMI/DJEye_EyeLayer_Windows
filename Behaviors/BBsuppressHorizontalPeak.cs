using DJeyeMouseWrapper.Modules;
using NeeqDMIs.Eyetracking.Tobii;
using System;

namespace DJeyeMouseWrapper.Behaviors
{
    internal class BBsuppressHorizontalPeak : ATobiiBlinkBehavior
    {
        public BBsuppressHorizontalPeak()
        {
            DCThresh = 1;
            LCThresh = 1;
            RCThresh = 1;
            DOThresh = 2;
            LOThresh = 2;
            ROThresh = 2;
        }

        public override void Event_doubleClose()
        {
            Rack.MappingModule.SuppressGaze = true;
        }

        public override void Event_doubleOpen()
        {
            Rack.MappingModule.SuppressGaze = false;
        }

        public override void Event_leftClose()
        {
            Rack.MappingModule.SuppressGaze = true;
        }

        public override void Event_leftOpen()
        {
            Rack.MappingModule.SuppressGaze = false;
        }

        public override void Event_rightClose()
        {
            Rack.MappingModule.SuppressGaze = true;
        }

        public override void Event_rightOpen()
        {
            Rack.MappingModule.SuppressGaze = false;
        }
    }
}