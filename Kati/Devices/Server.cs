using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kati.Enums;

namespace Kati.Devices {
	class Server : Device{

		public OSystem OS { get; set; }
		public bool DynamicIP { get; set; }
		public string IP { get; set; }
		public List<Service> Services { get; set; }

		public Server(Device device, OSystem os, bool dynamicIP, string IP, List<Service> services)
			: base(device.ID, device.Name, device.Description, device.AddedDate, device.Online) {
			this.OS = os;
			this.DynamicIP = dynamicIP;
			this.Services = services;
		}
	}
}
