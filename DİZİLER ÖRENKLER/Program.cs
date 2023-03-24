using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DİZİLER_ÖRENKLER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            int asalsayilar;


            int[,] dizi = new int[y, x];
            dizi[0, 0] = 10;
            dizi[0, 1] = 20;
            dizi[1, 0] = 30;
            dizi[1, 1] = 40;
            dizi[2, 0] = 50;
            dizi[2, 1] = 60;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(" {0} ", dizi[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
