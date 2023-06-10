using DJeyeMouseWrapper.Modules;
using NeeqDMIs.Eyetracking.Tobii;

namespace DJeyeMouseWrapper.Behaviors
{
    internal class BBmouseClicks : ATobiiBlinkBehavior
    {
        public BBmouseClicks() : base()
        {
            LOThresh = 1;
            ROThresh = 1;
            DOThresh = 1;
        }

        
        public override void Event_doubleClose()
        {
            Rack.MappingModule.ReceiveDoubleClickInput();
        }

        public override void Event_doubleOpen()
        {
            
        }

        public override void Event_leftClose()
        {
            Rack.MappingModule.ReceiveClickInput();
        }

        public override void Event_leftOpen()
        {
            
        }

        public override void Event_rightClose()
        {
            if (!Rack.MappingModule.IsHoldScroll)
            {
                Rack.MappingModule.ReceiveHoldScroll_Start();
            }
        }

        public override void Event_rightOpen()
        {
            if (Rack.MappingModule.IsHoldScroll)
            {
                Rack.MappingModule.ReceiveHoldScroll_End();
            }
        }
    }
}
