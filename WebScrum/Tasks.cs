using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebScrum
{
    public class Tasks
    {
        public string  TaskName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string TasksOwner { get; set; }
        public int TaskPoints { get; set; }

        public Tasks (string tn, DateTime st, DateTime et, string to, int tp)
        {
            TaskName = tn;
            StartTime = st;
            EndTime = et;
            TasksOwner = to;
            TaskPoints = tp;
        }
    }
}