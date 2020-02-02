using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper h = new Helper();
            int n, izaberi = 0;
            string opcijaUnosa;
            bool popunjen = false;

            Console.WriteLine("Unesite velicinu kvadratne matrice: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] matrica = new int[n,n];
            
            h.ispisiUputstvoUvod();
            opcijaUnosa= Console.ReadLine();

            while (!popunjen)
            {
                switch (opcijaUnosa)
                {
                    case "r":
                        h.popuniRandomMatricu(n, matrica);
                        h.ispisiMatricu(n, matrica);
                        popunjen = true;
                        break;
                    case "m":
                        h.popuniMatricuRucno(n, matrica);
                        h.ispisiMatricu(n, matrica);
                        popunjen = true;
                        break;
                    default:
                        if(izaberi > 1)
                        {
                            Console.WriteLine("Ispunili ste broj pokusaja.");
                            popunjen = true;
                            break;
                        }
                        Console.WriteLine("Pogresan unos, pokusajte ponovo.");
                        h.ispisiUputstvoUvod();
                        opcijaUnosa = Console.ReadLine();
                        izaberi++;
                        break;
                }
            }

            if (izaberi > 1)
                System.Environment.Exit(0);

            h.ispisiUputstvoOgledala();
            opcijaUnosa = Console.ReadLine();

            while (true)
            {
                switch (opcijaUnosa)
                {
                    case "r":
                        h.desnoOgledalo(n, matrica);
                        break;
                    case "d":
                        h.donjeOgledalo(n, matrica);
                        break;
                    case "b":
                        h.dijagonalnoOgledalo(n, matrica);
                        break;
                    default:
                        Console.WriteLine("Nesipravan unos!\n");
                        System.Environment.Exit(0);
                        break;
                }
                h.ispisiUputstvoOgledala();
                opcijaUnosa = Console.ReadLine();
            }
        }
    }
}
