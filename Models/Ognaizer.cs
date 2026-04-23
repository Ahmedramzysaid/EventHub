using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    public class Ognaizer
    {
        public  int Id { get; set; }    
        public string Name { get; set; }  =  default!;
        public  string? CompanyName { get; set; }
        public  bool  Isverified { get; set; }
        public Profile Profile { get; set; } = default!;  
       public ICollection<Event> Events { get; set; } = new List<Event>();

    }
}
