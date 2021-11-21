using System;
using System.Collections.Generic;
using System.Text;

namespace tp2
{
    class Point
    {
        public double x;
        public double y;
        public double z;
        /// <summary>
        /// constructeur pour le point
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        /// <summary>
        /// retourner la distance entre deux points
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public double distance(Point p)
        {
            double result;
            result = Math.Sqrt(Math.Pow((this.x-p.x),2)+ Math.Pow((this.y - p.y), 2)+ Math.Pow((this.z - p.z), 2));
            return result;
        }
        /// <summary>
        /// reteurn true si les deux points sont en meme position sinon il retourne false
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool egale(Point p)
        {
            return (this.x == p.x && this.y == p.y && this.z == p.z);
        }
        /// <summary>
        /// trnstation du point par un dx, dy et dz
        /// </summary>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        /// <param name="dz"></param>
        /// <returns></returns>
        public Point translation(double dx, double dy, double dz)
        {
            this.x += dx;
            this.y += dy;
            this.z += dz;
            return new Point(x,y,z);
        }
        /// <summary>
        /// cette fonction va retourner true si la point est appartienne a la droite t
        /// </summary>
        /// <param name="t">une droite</param>
        /// <returns></returns>
        public bool appartient(Droite t)
        {
            double k1 = (this.x - t.p1.x) / (t.p1.x - t.p2.x);
            double k2 = (this.y - t.p1.y) / (t.p1.y - t.p2.y);
            double k3 = (this.z - t.p1.z) / (t.p1.z - t.p2.z);
            if (k1 == k2 && k1 == k3 && k2 == k3)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// determine si 3 points sont allignes
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public bool alignés(Point p1, Point p2)
        {
            Point pp1 = new Point(p1.x-this.x, p1.y - this.y, p1.z - this.z);
            Point pp2 = new Point(p2.x-this.x, p2.y - this.y, p2.z - this.z);
            double k1 = pp1.x / pp2.x;
            double k2 = pp1.y / pp2.y;
            double k3 = pp1.z / pp2.z;
            return (k1 == k2 && k1 == k3 && k2 == k3);
        }
    }
}
