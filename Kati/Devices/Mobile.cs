using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kati.Enums;

namespace Kati.Devices {
	class Mobile : Device {

		public Location Location { get; set; }

		public Mobile(Device device, Location location) : base(device.ID, device.Name, device.Description, device.AddedDate, device.Online) {
			this.Location = location;
		}
	}
}
