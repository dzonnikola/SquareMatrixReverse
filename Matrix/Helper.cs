using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Helper
    {
        public void ispisiUputstvoUvod()
        {
            Console.WriteLine("Izaberite nacin popunjavanja matrice\n");
            Console.WriteLine("\tr -> random popunjavanje\n");
            Console.WriteLine("\tm -> rucno popunjavanje\n");
            Console.WriteLine("Vas izbor: ");
        }
        public void ispisiUputstvoOgledala()
        {
            Console.WriteLine("Unesite karakter 'r' za levo ogledalo!\n"); 
            Console.WriteLine("Unesite karakter 'd' za donje ogledalo!\n");
            Console.WriteLine("Unesite karakter 'b' za dijagonalu ogledala!\n");
            Console.WriteLine("Vas izbor: ");
        }


        public void popuniRandomMatricu(int n, int [,] matrica)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrica[i, j] = r.Next(0, 50);
        }
        public void popuniMatricuRucno(int n, int [,] matrica)
        {
            Console.WriteLine("Unesite elemente matrice!\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("matrica[{0}][{1}]: ", i + 1, j + 1); 
                    matrica[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\n"); 
            }

        }
        public void ispisiMatricu(int n, int [,] matrica)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(matrica[i,j] + " ");
                Console.WriteLine();
            }
        }
        public void desnoOgledalo(int n, int [,] matrica)
        {
            int tmp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    tmp = matrica[i,j];
                    matrica[i,j] = matrica[i, n - 1 - j];
                    matrica[i, n - 1 - j] = tmp;
                }
            }
            ispisiMatricu(n, matrica);
        }

        public void donjeOgledalo(int n, int [,] matrica)
        {
            int tmp;
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tmp = matrica[i,j];
                    matrica[i,j] = matrica[n - 1 - i,j];
                    matrica[n - 1 - i,j] = tmp;
                }
            }
            ispisiMatricu(n, matrica);
        }

        public void dijagonalnoOgledalo(int n, int [,] matrica)
        {
            int tmp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    tmp = matrica[i,j];
                    matrica[i,j] = matrica[n - 1 - j,n - 1 - i];
                    matrica[n - 1 - j,n - 1 - i] = tmp;
                }
            }
            ispisiMatricu(n, matrica);
        }
    }
}
