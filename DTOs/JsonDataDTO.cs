using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class JsonDataDTO
    {
        public List<MessageDTO> EventValues { get; set; }
        public List<MessageDTO> SessionsValues { get; set; }
        public List<MessageDTO> UsersValues { get; set; }
        
    }
}
