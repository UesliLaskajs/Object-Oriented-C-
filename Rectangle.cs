using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    internal class Rectangle
    {

        public double width {  get; set; }
        public double height { get; set; }

        public double Area()
        {
            return width * height;
        }

    }
}
