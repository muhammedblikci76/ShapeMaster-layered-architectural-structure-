using ShapeMaster.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Entities
{
    public class Reatangle:Shape
    {
        public decimal Asied { get; set; }
        public decimal Bsied { get; set; }
        public Reatangle()
        {
            Type = "Rectangle";
        }
        public  override decimal GetArea() 
        {
            return Asied*Bsied;
        }
    }
}
