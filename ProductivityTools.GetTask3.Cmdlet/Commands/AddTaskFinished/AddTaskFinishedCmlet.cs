using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.GetTask3.Commands.AddTaskFinished
{
     
    [Cmdlet(VerbsCommon.Add, "FinishedTask3")]
    public class AddTaskFinishedCmlet : GT3CmldetsBase, IFromElementPath
    {
        [Parameter(Position = 0)]
        public string Name { get; set; }

        [Parameter(Position = 2)]
        public string Path { get; set; }

        public AddTaskFinishedCmlet()
        {
            this.AddCommand(new AddElement(this));
        }

        protected override void ProcessRecord()
        {
            this.ProcessCommands();
            base.ProcessRecord();
        }

    }
}
