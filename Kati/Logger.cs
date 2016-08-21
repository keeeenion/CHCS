using System;

namespace Kati {
    public static class Logger {

	    static Logger() {
		    
	    }

		// For unrecoverable errors
		public static void Error(string s, string m, string st) {
			string time = DateTime.Now.ToString("hh:mm:ss tt");

		}

	    public static void Alert(string s) {
		    
	    }

		// For simple notes and suggestions
		public static void Warn(string s) {

		}

		// Self-explanatory
		public static void Log(string s) {

		}

		// Stack traces
		private static void Trace(string s) {
		    
	    }

	}
}
