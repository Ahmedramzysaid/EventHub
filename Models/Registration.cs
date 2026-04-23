using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    [Table("Registrations")]
    public class Registration
    {

        //  Using Surrogate Key  as  Primary Key  in Registration Class  to  avoid  the problem of  Composite Key  between EventId and AttendeeId
        //public int Id { get; set; }

        
        public string? Note { get; set; }
        public DateTime RegisteredAt {get;} = DateTime.UtcNow;

        public int EventId { get; set; }
        public Event Event { get; set; } = default!;

        public int AttendeeId { get; set; }
        public Attende Attendee { get; set; } = default!;


    }
}
