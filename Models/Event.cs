using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    /*
     craete RelationShip Recursive between Event Contain  SubEvent
    1  to  m  relationShip  between Event and SubEvent  using  Self Referencing  so  i  am  add  ParentEventId in Event class to  specify the relationship between Event and SubEvent

     
     
     */
    public class Event
    {
        public  int Id { get; set; }
        public string Title { get; set; } = default!;
        [Required]
        [MaxLength(500, ErrorMessage ="Description is required and should not exceed 500 characters")]
        public string Description { get; set; }
        public DateTime StartDate { get; set; } 
        public  DateTime? EndDate { get; set; }
        public int MaxAttendees { get; set; }
        public int OgnaizerId { get; set; }  
        public  Ognaizer Ognaizer { get; set; } = default!;
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();

        public ICollection<Event> WorkShops { get; set; }

        public int? ParentEventId { get; set; }
        public Event ParentEvent { get; set; }
        [NotMapped]

        public int Ramzy3dawanaId { get; set; }

    }
}
