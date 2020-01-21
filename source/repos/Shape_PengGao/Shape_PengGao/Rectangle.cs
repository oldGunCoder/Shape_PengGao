using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_PengGao
{
    class Rectangle
    {
        decimal length;
        decimal width;

        public string Display()
        {
            Console.WriteLine("This is a rectangle");
        }

        public decimal CalculateArea()
        {
            decimal area = length * width;
        }
    }
}
