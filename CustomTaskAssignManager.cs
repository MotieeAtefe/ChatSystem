using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ChatSystem
{
    internal class CustomTaskAssignManager : TaskAssignmentManager
    {
        protected override void OnTaskAssigned(OfficeTask task)
        {
            Console.WriteLine("Custom ligic before Task assignment");
            base.OnTaskAssigned(task);
            Console.WriteLine("Custom logic after Task assignment");
        }

        private void CustomTaskHandler(object sender, OfficeTask task)
        {
            Console.WriteLine($"New task Assigned:  {task.TaskName}");
        }
        public CustomTaskAssignManager()
        {
            TaskAssigned += CustomTaskHandler;
        }

    }
}
