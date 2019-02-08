using System;
using System.Collections.Generic;

namespace Lup.Telematics.Models {
	public class OnTrackingReceivedArgs {
		/// <summary>
		/// The claimed details of the device providing this data.
		/// </summary>
		public Device Device { get; set; }
		
		/// <summary>
		/// The data that has been provided by the device.
		/// </summary>
		public IList<Reading> Readings { get; set; }
	}
}