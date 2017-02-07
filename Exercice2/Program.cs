using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice2
{
    class Program
    {
        public struct Chrono
        {
            public int min, sec, cent;

            public Chrono(int minutes, int secondes, int centiemes)
            {
                min = minutes;
                sec = secondes;
                cent = centiemes;
            }

            public void AfficheChrono()
            {
                Console.WriteLine("Chrono : {0}min {1}s {2}", min, sec, cent);
            }

        }

        

        public static Chrono AjouteChrono(Chrono chrono1,Chrono chrono2)
        {
            Chrono chronoS;
            chronoS.min=chrono1.min+chrono2.min;
            chronoS.sec = chrono1.sec + chrono2.sec;
            chronoS.cent = chrono1.cent + chrono2.cent;

            if (chronoS.cent >= 100)
            {
                chronoS.sec++;
                chronoS.cent = chronoS.cent - 100;
            }
            if (chronoS.sec >= 60)
            {
                chronoS.min++;
                chronoS.sec = chronoS.sec - 60;
            }
            return chronoS;
        }

        public static int CompareChrono(Chrono chrono1, Chrono chrono2)
        {
            if (chrono1.min < chrono2.min)
                return -1;
            else
            {
                if (chrono1.min > chrono2.min)
                    return 1;

                else //chrono1.min==chrono2.min
                {
                    if (chrono1.sec < chrono2.sec)
                        return -1;
                    else
                    {
                        if (chrono1.sec > chrono2.sec)
                            return 1;
                        else//chrono1.sec == chrono2.sec
                        {
                            if (chrono1.cent < chrono2.cent)
                                return -1;
                            else
                            {
                                if (chrono1.cent > chrono2.cent)
                                    return 1;

                                else//chrono1.cent == chrono2.cent
                                {
                                    return 0;
                                }
                            }
                        }
                    }
                }
            }
        }

        public struct ChronoEquipe
        {
            public Chrono chrono1;
            public Chrono chrono2;
            public Chrono chrono3;
            public Chrono chronoTot;
            
            public void CalculeTotal()
            {
                Chrono chronoSum = AjouteChrono(chrono1, chrono2);
                chronoTot = AjouteChrono(chronoSum, chrono3);
            }

        }



        static void Main(string[] args)
        {/*Exercice 2 ; Coureurs*/

        }
    }
}
