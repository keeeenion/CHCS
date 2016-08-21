using System;

namespace Kati {
	class Service {

		public Guid ID { get; set; }
		public string Name { get; set; }
		public Device Owner { get; set; }
		public string Description { get; set; }

		public Service(Guid ID, string Name, Device Owner, string description) {
			this.ID = ID;
			this.Name = Name;
			this.Owner = Owner;
			this.Description = description;
		}
	}
}
