using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shivgarjana.Models.Event
{
    public class Event
    {
        public long EventID { get; set; }
        
        [Display(Name ="Event Name")]
        public string Title { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Where")]
        public Location Location { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [Display(Name = "When")]
        public DateTime DateTime { get; set; }
        public List<Gallery> Media { get; set; }
    }

   
}