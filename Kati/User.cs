using System;
using Kati.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kati {
	class User {

		public Guid ID { get; set; }
		public String DisplayName { get; set; }
		public String FullName { get; set; }
		public String Email { get; set; }
		public List<Device> Systems { get; set; }
		public List<Privilege> Privileges { get; set; }

		public User(Guid ID, String displayname, String fullName, String email, List<Device> devices, List<Privilege> privileges) {
			this.ID = ID;
			this.DisplayName = displayname;
			this.FullName = fullName;
			this.Email = email;
			this.Devices = devices;
			this.Privileges = privileges;
		}

		public bool AddDevice() {
			return false;
		}

		public bool GivePrivileges() {
			return false;
		}


	}
}
