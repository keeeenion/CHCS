using System;

namespace Kati {
	class Device {

        public Guid ID { get; set; }
        public string Name { get; set; }
		public string Description { get; set; }
		public DateTime AddedDate { get; set; }
        public bool Online { get; set; }

        public Device(Guid ID, string name, string description, DateTime addedDate, bool online) {
            this.ID = ID;
            this.Name = name;
	        this.Description = description;
            this.AddedDate = addedDate;
            this.Online = online;
        }

        public bool IsOnline() {
            return this.Online;
        }

    }
}
