using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kati.Devices {
	class Workstation : Device {

		public Location OS { get; set; }

		public Workstation(Device device, Location os) : base(device.ID, device.Name, device.Description, device.AddedDate, device.Online) {
			this.OS = os;
		}
	}
}
