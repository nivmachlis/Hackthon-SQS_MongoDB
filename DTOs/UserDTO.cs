using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class DataUserDTO : DataInterface
	{
		public int UserID { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Country { get; set; }
		public string City { get; set; }
		public int VisitNumber { get; set; }
		public int EventsNumber { get; set; }
		public double TimeOnSite { get; set; }
		public string UserType { get; set; }
    }
}
