﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.UI.WebControls;

namespace WebScrum
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ScrumService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ScrumService.svc or ScrumService.svc.cs at the Solution Explorer and start debugging.
    public class ScrumService : IScrumService
    {
        List<Tasks> BackLogList = new List<Tasks>();

        public void AddTask()
        {
            //thanos
        }

        public void AddTask(string Name, DateTime StartTime, DateTime EndTime, string TaskOWner, int TaskPoints)
        {
            Tasks NewTask = new Tasks(Name, StartTime, EndTime, TaskOWner, TaskPoints);

            BackLogList.Add(NewTask);

        }

        public List<Tasks> MoveTasks(List<Tasks> fromList, List<Tasks> toList)
        {
            throw new NotImplementedException();
        }

        public void DeleteTasks(string UnitTask)
        {
            throw new NotImplementedException();
        }


        public void MoveTasksListBox(ListBox fromList, ListBox toList)
        {
            for (int i = 0; i < fromList.Items.Count; i++)
            {
                if (fromList.Items[i].Selected)
                {
                    toList.Items.Add(fromList.SelectedItem);
                    fromList.Items.Remove(fromList.Items[i]);
                }
            }
            fromList.SelectedIndex = -1;
            toList.SelectedIndex = -1;
        }
    }
}
