using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
	public class DataSessionDTO : DataInterface
	{
		public int UserID { get; set; }
		public string VisitStartTime { get; set; }
		public string VisitEndTime { get; set; }
		public int EventNumberInSession { get; set; }
		public string OperatingSystem { get; set; }
		public int SessionID { get; set; }
		public string Date { get; set; }

	}
}