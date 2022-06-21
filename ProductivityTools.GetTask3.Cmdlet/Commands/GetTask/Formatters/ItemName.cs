using ProductivityTools.ConsoleColor;
using ProductivityTools.GetTask3.Contract;
using ProductivityTools.GetTask3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.GetTask3.Commands.GetTask.Formatters
{
    public class ItemName
    {
        internal void Format(ColorString input, ElementView element)
        {
            var part = new ColorStringItem();
            var domain = element;

            if (domain.Type == CoreObjects.ElementType.Task.ToString())
            {
                part.Value = $"{domain.Name} ";
            }
            else if (domain.Type == CoreObjects.ElementType.TaskBag.ToString())
            {
                part.Value = $"[{domain.Name}] ";
            }

            Dictionary<Func<bool>, byte> colormap = new Dictionary<Func<bool>, byte>();
            colormap.Add(() => true, 15);
            colormap.Add(() => domain.Type == CoreObjects.ElementType.TaskBag.ToString(), 15);
            colormap.Add(() => domain.Type != CoreObjects.ElementType.TaskBag.ToString() && domain.Delayed(), 9);
            //pw: correct status
            colormap.Add(() => domain.Type != CoreObjects.ElementType.TaskBag.ToString() && domain.Status == "InProgress", 40);
            colormap.Add(() => domain.Type != CoreObjects.ElementType.TaskBag.ToString() && domain.Finished.HasValue, 8);

            foreach (var item in colormap)
            {
                if(item.Key.Invoke())
                {
                    part.Color = item.Value;
                }
            }

            input.Add(part);
        }
    }
}
