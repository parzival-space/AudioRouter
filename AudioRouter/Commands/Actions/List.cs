using CSCore.CoreAudioAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioRouter.Commands.Actions
{
    internal class List
    {
        public static int Run(Formats.List options)
        {
            // enumerate all multimedia devicces
            using (MMDeviceEnumerator deviceEnumerator = new MMDeviceEnumerator())
            {
                using (var devices = deviceEnumerator.EnumAudioEndpoints(DataFlow.Render, DeviceState.Active))
                {
                    Console.WriteLine($"{"Name".PadRight(50)}  Device ID");

                    // print each device
                    foreach (var device in devices)
                    {
                        var name = device.FriendlyName.Length > 50 ? device.FriendlyName.Substring(0, 50) : device.FriendlyName;

                        Console.WriteLine($"{name.PadRight(50)}  {device.DeviceID}");
                    }
                }
            }

            return 0;
        }
    }
}
