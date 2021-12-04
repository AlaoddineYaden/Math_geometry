using System;
using System.Collections.Generic;
using System.Text;

namespace tp2
{

    class Droite
    {
        public Point p1 { get; set; }
        public Point p2 { get; set; }
        public Point vect { get; set; }
        
        /// <summary>
        /// constructeur du droite  avec deux points
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        public Droite(Point p1,Point p2)
        {
            vect = new Point(p1.x - p2.x, p1.y - p2.y, p1.z - p2.z);
            this.p1 = p1;
            this.p2 = p2;
        }
        /// <summary>
        /// constructeur du droite  avec des cordonnees
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="z1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="z2"></param>
        public Droite(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            vect = new Point(x1 - x2, y1-y2, z1-z2);
            this.p1 = new Point(x1, y1, z1);
            this.p2 = new Point(x2, y2, z2);
        }
        /// <summary>
        /// il va retourner true si les deux droite sont paralelle 
        /// </summary>
        /// <param name="t">une droite</param>
        /// <returns></returns>
        public bool paralelle(Droite t)
        {
            double k1 = (this.p1.x - this.p2.x)/vect.x;
            double k2 = (this.p1.y - this.p2.y)/vect.y;
            double k3 = (this.p1.z - this.p2.z)/vect.z;
            if (k1 == k2 && k1 == k3 && k2 == k3)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// cette fonction va retourner true si la point est appartienne a la droite t
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool appartient(Point p)
        {
            double k1 = (p.x - this.p1.x) / this.vect.x;
            double k2 = (p.y - this.p1.y) / this.vect.y;
            double k3 = (p.z - this.p1.z) / this.vect.z;
            if (k1 == k2 && k1 == k3 && k2 == k3)
            {
                return true;
            }
            return false;
        }

    }
}
