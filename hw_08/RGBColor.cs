using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RGBColorClass
{
    
    struct RGBColor
    {
        private Color color;
        public int r;
        public int g;
        public int b;
        
        public RGBColor(int r, int g, int b)
        {
            color = new Color(r, g, b);
            this.r = r;
            this.g = g;
            this.b = b;
        }
        //public string ToHex()                             /// System.Drawing does not work
         
    }
}
