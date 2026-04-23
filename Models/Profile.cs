using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{

    //  use  here DataAnnotations 
    public class Profile
    {
        [ForeignKey("OgnaizerId")]  //  ==>  i am  use in 1 - to  - 1   using Shared Primary Key  so  i  am  use  ForeignKey Attribute  to  specify the relationship between Profile and Ognaizer
        [Key]
        public  int Id { get; set; }
        [MaxLength(1000)]
        public string? Bio { get; set; }

        public  string? WebsiteUrl { get; set; } 
        public  string? LogoUrl { get; set; }

        public   Ognaizer Ognaizer { get; set; } = default!;
    }
}
