using System.Diagnostics;

namespace _5ti_LoukaConstant_triTableaux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans cette methode de tris format tableau !");
            int[] T;
            int tailleTableau;
            string nUser;
            string repeatProg;
            string message;
            Methodedetri mestris = new Methodedetri();

            do
            {
                Console.WriteLine(" Pour commencer, quel méthode de tri voulez - vous ?");
                Console.WriteLine(" - Taper 1 pour le tri pas sélection.\n - Taper 2 pour le tri par insertion.\n - Taper 3 pour le tri intuitif.\n - Taper 4 pour le tri shell.\n - Taper 5 pour le tri à bulles.\n");
                nUser = Console.ReadLine();

                if (nUser == "1")
                {
                    Console.WriteLine("Vous avez choisi le tri par sélection !");
                    Console.WriteLine("Combien de cases voulez-vous ?");
                    tailleTableau = int.Parse(Console.ReadLine());

                    Console.WriteLine("Voici le tableau de base :");
                    mestris.tableauAleatoire(tailleTableau, out T);
                    mestris.afficherTableau(T, out message);
                    Console.WriteLine(message);

                    //traitement
                    mestris.triparSelection(ref T);

                    Console.WriteLine("Voici le tableau après le tri :");
                    mestris.afficherTableau(T, out message);
                    

                    Stopwatch chrono = new Stopwatch();
                    long millisec;
                    chrono = Stopwatch.StartNew();
                    mestris.triparSelection(ref T);
                    chrono.Stop();
                    millisec = chrono.ElapsedMilliseconds;
                    Console.WriteLine(message);
                    Console.WriteLine($"{millisec} millisecondes");

                }

                else if (nUser == "2")
                {
                    Console.WriteLine("Combien de cases voulez-vous ?");
                    tailleTableau = int.Parse(Console.ReadLine());


                    Console.WriteLine("Voici le tableau de base :");
                    mestris.tableauAleatoire(tailleTableau, out T);
                    mestris.afficherTableau(T, out message);
                    Console.WriteLine(message);

                    //traitement
                    mestris.triparInsertion(T);

                    Console.WriteLine("Voici le tableau après le tri :");
                    mestris.afficherTableau(T, out message);
                    

                    Stopwatch chrono = new Stopwatch();
                    long millisec;
                    chrono = Stopwatch.StartNew();
                    mestris.triparInsertion(T);
                    chrono.Stop();
                    millisec = chrono.ElapsedMilliseconds;
                    Console.WriteLine(message);
                    Console.WriteLine($"{millisec} millisecondes");

                }



                else if (nUser == "3")
                {
                    Console.WriteLine("Vous avez choisi le tri intuitif !");
                    Console.WriteLine("Combien de cases voulez-vous ?");
                    tailleTableau = int.Parse(Console.ReadLine());

                    Console.WriteLine("Voici le tableau de base :");
                    mestris.tableauAleatoire(tailleTableau, out T);
                    mestris.afficherTableau(T, out message);
                    Console.WriteLine(message);

                    //traitement
                    mestris.triIntuitif(T);

                    Console.WriteLine("Voici le tableau après le tri :");
                    mestris.afficherTableau(T, out message);
                    

                    Stopwatch chrono = new Stopwatch();
                    long millisec;
                    chrono = Stopwatch.StartNew();
                    mestris.triIntuitif(T);
                    chrono.Stop();
                    millisec = chrono.ElapsedMilliseconds;
                    Console.WriteLine(message);
                    Console.WriteLine($"{millisec} millisecondes");

                }

                else if (nUser == "4")
                {
                    Console.WriteLine("Vous avez choisi le tri shell !");
                    Console.WriteLine("Combien de cases voulez-vous ?");
                    tailleTableau = int.Parse(Console.ReadLine());

                    Console.WriteLine("Voici le tableau de base :");
                    mestris.tableauAleatoire(tailleTableau, out T);
                    mestris.afficherTableau(T, out message);
                    Console.WriteLine(message);

                    //traitement
                    mestris.triShell(T);

                    Console.WriteLine("Voici le tableau après le tri :");
                    mestris.afficherTableau(T, out message);
              
                    Stopwatch chrono = new Stopwatch();
                    long millisec;
                    chrono = Stopwatch.StartNew();
                    mestris.triShell(T);
                    chrono.Stop();
                    millisec = chrono.ElapsedMilliseconds;
                    Console.WriteLine(message);
                    Console.WriteLine($"{millisec} millisecondes");

                }

                else if (nUser == "5")
                {
                    Console.WriteLine("Vous avez choisi le tri à bulles !");
                    Console.WriteLine("Combien de cases voulez-vous ?");
                    tailleTableau = int.Parse(Console.ReadLine());

                    Console.WriteLine("Voici le tableau de base :");
                    mestris.tableauAleatoire(tailleTableau, out T);
                    mestris.afficherTableau(T, out message);
                    Console.WriteLine(message);

                    //traitement
                    mestris.triABulles(T);

                    Console.WriteLine("Voici le tableau après le tri :");
                    mestris.afficherTableau(T, out message);
                   
                    Stopwatch chrono = new Stopwatch();
                    long millisec;
                    chrono = Stopwatch.StartNew();
                    mestris.triABulles(T);
                    chrono.Stop();
                    millisec = chrono.ElapsedMilliseconds;
                    Console.WriteLine(message);
                    Console.WriteLine($"{millisec} millisecondes");

                }

                //demande de reprise
                Console.WriteLine("Voulez-vous recommencer ? 'o' = oui, 'n' = non");
                repeatProg = Console.ReadLine();

            } while (repeatProg == "o");
        }
    }
}
