using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5ti_LoukaConstant_triTableaux
{
    public struct Methodedetri
    {
        public void tableauAleatoire(int tailleTableau, out int[] T)
        {
            T = new int[tailleTableau];
            Random alea = new Random();


            for (int i = 0; i < tailleTableau; i++)
            {
                T[i] = alea.Next(1, 101);
            }


        }

        public void afficherTableau(int[] T, out string message)
        {
            message = "";
            foreach (int i in T)
            {
                message = message + i + " ";
            }
        }


        public void triparSelection(ref int[] T)
        {
            int i;
            int j;
            int n; //nbre éléments dans le tableau.
            int p; //place de l'élément à changer.
            int echange;


            for (i = 0; i <= T.Length - 2; i++)
            {
                p = i;

                for (j = i + 1; j <= T.Length - 1; j++)
                {
                    if (T[j] < T[p])
                    {
                        p = j;
                    }


                }

                if (p != i)
                {
                    echange = T[p];
                    T[p] = T[i];
                    T[i] = echange;

                }

            }
        }

        public void triparInsertion(int[] T)
        {
            int n;
            int x;
            bool bpp;
            int j;
            int i;

            for (j = 1; j < T.Length - 1; j++)
            {
                x = T[j];
                i = j - 1;
                bpp = false;

                while (x < T[i])
                {
                    T[i + 1] = T[i];

                    if (i == 0)
                    {
                        bpp = true;

                    }

                    else
                    {
                        i = i - 1;
                    }

                    if (bpp)
                    {
                        T[0] = x;
                    }

                    else
                    {
                        T[i + 1] = x;
                    }
                }


            }
        }

        public void triIntuitif(int[] T)
        {
            int echange;

            for (int i = 0; i <= T.Length - 2; i++)
            {
                for (int j = i + 1; j <= T.Length - 1; j++)
                {
                    if (T[i] > T[j])
                    {


                        echange = T[i];
                        T[i] = T[j];
                        T[j] = echange;
                    }
                }
            }



        }

        public void triShell(int[] T)
        {
            int n = T.Length;
            bool permut;
            int Ec = n / 2;
            int x;

            while (Ec >= 1)
            {
                do
                {
                    permut = false;
                    for (int i = 0; i <= n - 1 - Ec; i++)
                    {
                        if (T[i] > T[i + Ec])
                        {
                            x = T[i];
                            T[i] = T[i + Ec];
                            T[i + Ec] = x;
                            permut = true;
                        }
                    }
                } while (permut == true);

                Ec = Ec / 2;

            }
        }

        public void triABulles(int[] T1)
        {
            bool b1 = true;
            int az;

            while (b1 == true)
            {
                b1 = false;

                for (int i = 0; i <= T1.Length - 2; i++)
                {
                    if (T1[i] > T1[i + 1])
                    {
                        az = T1[i];
                        T1[i] = T1[i + 1];
                        T1[i + 1] = az;
                        b1 = true;
                    }
                }
            }
        }
    }
}
