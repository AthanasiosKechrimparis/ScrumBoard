using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceScrumboard
{
    public class Tasks
    {
        public string  TaskName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string TaksOwner { get; set; }
        public int TaskPoints { get; set; }
    }
}