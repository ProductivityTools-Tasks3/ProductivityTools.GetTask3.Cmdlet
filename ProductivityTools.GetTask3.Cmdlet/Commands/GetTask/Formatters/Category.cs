using ProductivityTools.ConsoleColors;
using ProductivityTools.GetTask3.Contract;
using ProductivityTools.GetTask3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.GetTask3.Commands.GetTask.Formatters
{

    public class Category
    {
        internal void Format(ColorString input, ElementView element)
        {
            var part = new ColorStringItem();
            if (!string.IsNullOrEmpty(element.Category))
            {
                part.Value = $"[{element.Category}] ";
                part.Color = 70;
                input.Add(part);
            }
        }
    }
}
