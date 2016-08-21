namespace Kati.Devices {
	class Gadget : Device {

		public Gadget(Device device)
			: base(device.ID, device.Name, device.Description, device.AddedDate, device.Online) {

		}
	}
}
