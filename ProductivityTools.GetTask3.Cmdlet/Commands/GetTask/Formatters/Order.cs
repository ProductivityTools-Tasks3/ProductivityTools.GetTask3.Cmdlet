using ProductivityTools.ConsoleColor;
using ProductivityTools.GetTask3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.GetTask3.Commands.GetTask.Formatters
{
    public class Order
    {
        internal void Format(ColorString input, PSElementView element)
        {
            var part = new ColorStringItem();
            var domain = element.Element;
            ElementMetadata viewMetadata = element.SessionElement;// this.View.ItemOrder[element.ElementId];

            if (domain.Type == CoreObjects.ElementType.Task.ToString())
            {
                part.Value = $"T{GetOrder(viewMetadata)}. ";
            }
            else if (domain.Type == CoreObjects.ElementType.TaskBag.ToString())
            {
                part.Value = $"B{GetOrder(viewMetadata)}. ";
            }

            part.Color = 15;
            input.Add(part);
        }

        private string GetOrder(ElementMetadata metadata)
        {
            return metadata.Order.ToString().PadLeft(3, '0');
        }
    }
}
