using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    public class Attende
    {
        public  int Id { get; set; }    
        public string FullName { get; set; } = default!;
        [Required]
        [MaxLength(265, ErrorMessage ="Email Is Required aaaaaaaa@gmial")] 
        public  string Email { get; set; } = default!;
        public string Street { get;  set; } = default!;
        public string City { get;  set; } = default!;

        public  string Country { get;  set; } = default!;

        public  string PostalCode { get;  set; } = default!;
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
       
        public Badge Badges { get; set; } 

    }
}
