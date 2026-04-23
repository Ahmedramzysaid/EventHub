using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    public class Badge
    {
        public  int Id { get; set; }
        public string BadgeNumber { get; set; } = default!;
        public string IssuedDate { get; set; } 
        public string Tier { get; set; } = default!;
        public int AttendeId { get; set; }
        public Attende Attende { get; set; }
    }
}
