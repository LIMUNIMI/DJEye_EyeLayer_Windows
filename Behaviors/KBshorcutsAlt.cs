using DJeyeMouseWrapper.Modules;
using NeeqDMIs.Keyboard;
using RawInputProcessor;

namespace BlankADMI.Behaviors
{
    internal class KBshortcutsAlt : IKeyboardBehavior
    {
        const VKeyCodes keyEnable = VKeyCodes.E;
        const VKeyCodes keyDisable = VKeyCodes.D;
        const VKeyCodes keyAlt = VKeyCodes.LeftMenu;

        private bool isModPressed = false;
        public int ReceiveEvent(RawInputEventArgs e)
        {
            // ALT MOD
            if (e.VirtualKey == (int)keyAlt)
            {
                if(e.KeyPressState == KeyPressState.Down)
                {
                    isModPressed = true;
                }
                else if(e.KeyPressState == KeyPressState.Up)
                {
                    isModPressed = false;
                }
            }

            // ENABLE, DISABLE
            if(e.VirtualKey == (int)keyEnable && e.KeyPressState == KeyPressState.Down && isModPressed)
            {
                Rack.MappingModule.Enabled = true;
            }
            if (e.VirtualKey == (int)keyDisable && e.KeyPressState == KeyPressState.Down && isModPressed)
            {
                Rack.MappingModule.Enabled = false;
            }
            return 0;
        }
    }
}
