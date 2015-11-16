using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebScrum
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ScrumService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ScrumService.svc or ScrumService.svc.cs at the Solution Explorer and start debugging.
    public class ScrumService : IScrumService
    {
        public void AddTask()
        {
        }

        public void AddTask(string Name, DateTime StartTime, DateTime EndTime, string TaskOWner, int TaskPoints)
        {
            throw new NotImplementedException();
        }

        public List<Tasks> MoveTasks(List<Tasks> fromList, List<Tasks> toList)
        {
            throw new NotImplementedException();
        }

        public void DeleteTasks(string UnitTask)
        {
            throw new NotImplementedException();
        }
    }
}
