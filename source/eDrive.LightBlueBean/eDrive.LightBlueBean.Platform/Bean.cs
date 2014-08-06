using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.Devices.Bluetooth.GenericAttributeProfile;

namespace eDrive.LightBlueBean.Platform
{
    public partial class Bean
    {
        private readonly GattDeviceService _deviceService;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bean"/> class.
        /// </summary>
        /// <param name="deviceService">The device service.</param>
        public Bean(GattDeviceService deviceService)
        {
           _deviceService = deviceService;
        }

        private void PerformDispose()
        {
            _deviceService.Dispose();
        }
    }
}
