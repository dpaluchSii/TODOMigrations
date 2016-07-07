using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TODOMigrations.Models
{
    public class Task
    {
        public int TaskID { get; set; }

        public string Event { get; set; }

        public string Where { get; set; }

        public DateTime When { get; set; }
        //
    }
}