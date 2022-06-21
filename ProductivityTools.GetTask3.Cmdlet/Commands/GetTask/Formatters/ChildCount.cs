using ProductivityTools.ConsoleColor;
using ProductivityTools.GetTask3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.GetTask3.Commands.GetTask.Formatters
{
    public class ChildCount
    {
        internal void Format(ColorString input, PSElementView element)
        {
            Func<CoreObjects.ElementType, string> getString = (x) => x.ToString();

            var part = new ColorStringItem();
            var domain = element.Element;
            ElementMetadata viewMetadata = element.SessionElement;// this.View.ItemOrder[element.ElementId];
            if(domain.Type== CoreObjects.ElementType.Task.ToString())
            {
                part.Value = $"<{viewMetadata.ChildCount}>";
            }
            else if(domain.Type== CoreObjects.ElementType.TaskBag.ToString())
            {
                part.Value = $"<{viewMetadata.ChildCount}t>";
            }
            part.Color = 215;
            input.Add(part);
        }
    }
}
