using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSystem
{
    internal class OfficeTask
    {
        public string TaskName { get; }
        public OfficeTask(string taskname)
        {
            this.TaskName = taskname;
        }
    }
}
