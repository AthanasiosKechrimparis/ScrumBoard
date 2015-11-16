using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebScrum
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IScrumService" in both code and config file together.
    [ServiceContract]
    public interface IScrumService
    {
        [OperationContract]
        void AddTask(Tasks Task);

        [OperationContract]
        List<Tasks> MoveTasks(List<Tasks> fromList,List<Tasks>toList);

        [OperationContract]
        void DeleteTasks(string UnitTask);
        
    }
}
