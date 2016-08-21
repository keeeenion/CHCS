using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kati.Enums {
	public enum AuthType {
		// Linux local account
		LINUX = 1,
		// Radius server
		RADIUS = 2,
		// LDAP
		LDAP = 3,
		// Kati's auth
		KATI = 4
	}
}
