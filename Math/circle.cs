using System;
using System.Collections.Generic;
using System.Text;

namespace tp2
{
    class circle : Ellipse
    {
        /// <summary>
        /// constructeur de cercle
        /// </summary>
        /// <param name="pt"></param>
        /// <param name="r"></param>
        public circle(Point pt, double r) : base(pt, r, r){ }
    }
    
}
