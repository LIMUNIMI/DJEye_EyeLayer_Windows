using DJeye_Wrapper.Modules;
using NeeqDMIs.Keyboard;
using RawInputProcessor;

namespace BlankADMI.Behaviors
{
    internal class KBshortcuts : IKeyboardBehavior
    {
        const VKeyCodes keyEnable = VKeyCodes.E;
        const VKeyCodes keyDisable = VKeyCodes.D;
        const VKeyCodes keyShow = VKeyCodes.S;
        const VKeyCodes keyHide = VKeyCodes.H;
        public int ReceiveEvent(RawInputEventArgs e)
        {
            if(e.VirtualKey == (int)keyEnable && e.KeyPressState == KeyPressState.Down)
            {
                Rack.MappingModule.Enabled = true;
            }
            if (e.VirtualKey == (int)keyDisable && e.KeyPressState == KeyPressState.Down)
            {
                Rack.MappingModule.Enabled = false;
            }
            return 0;
        }
    }
}
