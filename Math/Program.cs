using System;

namespace tp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(2,3,4);
            Point p2 = new Point(4,6,8);
            Point p3 = new Point(4,6,8);

            Droite t = new Droite(p,p2);
            Droite t1 = new Droite(p,new Point(4,6,8));
            t1.paralelle(t);
            p2.distance(p);
            Ellipse ellipse = new Ellipse(p, 2,3);
            double x = ellipse.longueur;
            ellipse.longueur = 7;
            Console.WriteLine(p2.distance(p));
            Console.WriteLine(t1.paralelle(t));

           
            Console.WriteLine(ellipse.circonference());
            Console.WriteLine(p3.appartient(t));

        }
    }
}
