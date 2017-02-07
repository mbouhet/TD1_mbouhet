using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        public struct Point2D
        {
            public int x, y;

            public Point2D(int c1, int c2)
            {
                x = c1;
                y = c2;
            }
        }

        public struct Rectangle2D
        {
            public int num;
            public Point2D ptSup;
            public Point2D ptInf;
            public int largeur, longueur, aire;

            public Rectangle2D(int numero, Point2D ptHG, Point2D ptBD)
            {
                num = numero;
                ptSup = ptHG;
                ptInf = ptBD;
                largeur = 0; 
                longueur = 0;
                aire = 0;
            }

            public void CalculeCotes()
            {
                largeur = Math.Abs(ptSup.x - ptInf.x);
                longueur = Math.Abs(ptSup.y - ptInf.y);

                if (largeur > longueur)
                {
                    int tmp = largeur;
                     largeur = longueur;
                     longueur = tmp;
                }
            }

           public  void CalculeAire( )
             {
                aire = largeur * longueur;
             }
        }



       /* public static int LargeurRectangle(Rectangle2D rect)
        {
            int cote1 = Math.Abs(rect.ptSup.x - rect.ptInf.x);
            int cote2 = Math.Abs(rect.ptSup.y - rect.ptInf.y);

            if (cote1 < cote2)
            {
                return cote1;
            }
            else
            {
                return cote2;
            }
        }

        public static int AireRectangle(Rectangle2D rect)
        {
            int aire = Math.Abs(rect.ptSup.x - rect.ptInf.x) * Math.Abs(rect.ptSup.y - rect.ptInf.y);
            return aire;
        }*/


        static void Main(string[] args)
        {/*Exercice 1 : Points et Rectangles*/

            Point2D P1 = new Point2D(1, 2);
            Point2D P2 = new Point2D(10, 25);
            Point2D P3 = new Point2D(15, -1);
            Point2D P4 = new Point2D(30, 20);

            Rectangle2D R1 =new Rectangle2D(1,P1,P3);
            Rectangle2D R3 = new Rectangle2D(3, P2, P4);

            Console.WriteLine("rectangle {0} :",R1.num);
            R1.CalculeCotes();
            R1.CalculeAire();
            Console.WriteLine("Largeur= {0} et aire= {1} ", R1.largeur,R1.aire);

            Console.WriteLine("rectangle {0} :", R3.num);
            R3.CalculeCotes();
            R3.CalculeAire();
            Console.WriteLine("Largeur= {0} et aire= {1} ", R3.largeur, R3.aire);

            Console.ReadKey();

        }
    }
}
