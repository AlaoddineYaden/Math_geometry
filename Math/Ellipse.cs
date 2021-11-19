using System;
using System.Collections.Generic;
using System.Text;

namespace tp2
{
    
    class Ellipse
    {
        public double longueur;
        public double largeur;
        public Point centre;
        /// <summary>
        /// constructeur d'un ellipse
        /// </summary>
        /// <param name="centre"></param>
        /// <param name="longueur"></param>
        /// <param name="largeur"></param>
        public Ellipse(Point centre, double longueur, double largeur)
        {
            
            this.centre = centre;
            this.longueur = longueur;
            this.largeur = largeur;
        }
        /// <summary>
        /// retourne le circonference d'ellipse ou cercle
        /// </summary>
        /// <returns></returns>
        public double circonference()
        {
            double p = 2 * 3.14 * Math.Sqrt((Math.Pow(longueur,2) + Math.Pow(largeur,2))/2);
            return p;
        }
        /// <summary>
        /// retourne la surface d'ellipse ou cercle
        /// </summary>
        /// <returns></returns>
        public double surface()
        {
            double s =  3.14 * longueur * largeur;
            return s;
        }
    }
}
