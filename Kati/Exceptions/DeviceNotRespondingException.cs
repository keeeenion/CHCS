using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kati.Exceptions {
	class DeviceNotRespondingException : Exception {

		public DeviceNotRespondingException() {
		}

		public DeviceNotRespondingException(string message)
			: base(message) {
		}

		public DeviceNotRespondingException(string message, Exception inner)
			: base(message, inner) {
		}
	}
}
