using ProductivityTools.GetTask3.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.GetTask3.Commands.AddTaskFinished
{
     class AddElement : PSCmdlet.PSCommandPT<AddTaskFinishedCmlet>
    {
        protected override bool Condition => true;

        public AddElement(AddTaskFinishedCmlet cmdlet) : base(cmdlet)
        {
        }

        protected override void Invoke()
        {
            App.Task ts = TaskStructureFactory.Get(this.Cmdlet);
            string[] elements = this.Cmdlet.Name.Split('\n').Where(x => !string.IsNullOrEmpty(x)).ToArray();
            foreach (var element in elements)
            {
                ts.Add(element, CoreObjects.ElementType.Task, true);
            }
        }
    }
}
