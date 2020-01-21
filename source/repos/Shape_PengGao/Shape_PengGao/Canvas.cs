using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_PengGao
{
    internal class Canvas
    {
        public decimal Radius { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }


        private void ShowShape (IShape sh)
        {
            sh.Display();
            sh.CalculateArea();
                   
        } 

    }
}
