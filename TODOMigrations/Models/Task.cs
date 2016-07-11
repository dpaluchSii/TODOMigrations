using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TODOMigrations.Models
{

    public class Task
    {
        public int TaskID { get; set; }

        
        [Required(ErrorMessage = "Event is required.")]
        public string Event { get; set; }

        //public string Eventt { get; set; }

        public string Where { get; set; }

        public DateTime When { get; set; }
        
    }
}