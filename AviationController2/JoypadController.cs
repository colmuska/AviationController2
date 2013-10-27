using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using Microsoft.DirectX.DirectInput;


namespace AviationController2
{
    class JoypadController
    {
        const int THROTTLE_TIC = 8;
        const int FLAPS_TIC = 4;

        Device joypad = null;
        JoystickState state;
        int flaps;
        int throttle;

        int[] buttonsPrev;


        public static string[] getJoypadList()
        {
            
            DeviceList deviceList = Manager.GetDevices(DeviceClass.GameControl, EnumDevicesFlags.AttachedOnly);
            string[] devNames = new string[deviceList.Count];

            for (int i = 0; i < deviceList.Count; i++)
            {
                deviceList.MoveNext();
                DeviceInstance tmp = (DeviceInstance)deviceList.Current;

                devNames[i] = tmp.ProductName;

            }
            
            return devNames;

        }

        public JoypadController(int deviceIndex)
        {
            DeviceList deviceList = Manager.GetDevices(DeviceClass.GameControl, EnumDevicesFlags.AttachedOnly);

            for (int i = 0; i < deviceIndex+1; i++)
            {
                deviceList.MoveNext();
            }
            DeviceInstance joyInstance = (DeviceInstance)deviceList.Current;

            joypad = new Device(joyInstance.InstanceGuid);
            joypad.SetCooperativeLevel(null, CooperativeLevelFlags.Background | CooperativeLevelFlags.NonExclusive);

            joypad.SetDataFormat(DeviceDataFormat.Joystick);

            joypad.Acquire();

            buttonsPrev = new int[joypad.Caps.NumberButtons];

            flaps = 0;
            throttle = 0;
        }

        public void updateJoyState()
        {
            joypad.Poll();
            state = joypad.CurrentJoystickState;

            if (buttonsPrev[7 - 1] == 0 && state.GetButtons()[7-1] == 128)
            {
                throttle -= 255 / (THROTTLE_TIC-1);
            }
            if (buttonsPrev[8 - 1] == 0 && state.GetButtons()[8 - 1] == 128)
            {
                throttle += 255 / (THROTTLE_TIC-1);
            }
            if (buttonsPrev[2 - 1] == 0 && state.GetButtons()[2 - 1] == 128)
            {
                throttle = 255;
            }
            if (buttonsPrev[1 - 1] == 0 && state.GetButtons()[1 - 1] == 128)
            {
                throttle = 0;
            }
            if (255 < throttle)
            {
                throttle = 255;
            }
            else if (throttle < 0)
            {
                throttle = 0;
            }

            if (buttonsPrev[3 - 1] == 0 && state.GetButtons()[3 - 1] == 128)
            {
                flaps -= 255 / (FLAPS_TIC-1);
            }
            if (buttonsPrev[4 - 1] == 0 && state.GetButtons()[4 - 1] == 128)
            {
                flaps += 255 / (FLAPS_TIC-1);
            }
            if (255 < flaps)
            {
                flaps = 255;
            }
            else if (flaps < 0)
            {
                flaps = 0;
            }


            for (int i = 0; i < buttonsPrev.Length; i++)
            {
                buttonsPrev[i] = state.GetButtons()[i];
            }

        }

        public int getPitch()//0 to 255
        {
            return 255-state.Y/256;
        }

        public int getRole()// 0 to 255
        {
            return state.X / 256;
        }

        public int getYaw()//0 to 255
        {
            return 255-state.Z/256;
        }

        public int getThrottle()//0 to 255
        {
            return throttle;
        }

        public int getFlaps()//0 to 255
        {
            return flaps;
        }
    }

}
