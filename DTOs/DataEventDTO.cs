using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class DataEventDTO : DataInterface
    {
        public int EventID { get; set; }
        public int SessionID { get; set; }
        public string EventTime { get; set; }
        public string EventLabel { get; set; }
        public string EventAction { get; set; }
        public string EventCategory { get; set; }
    }

}
