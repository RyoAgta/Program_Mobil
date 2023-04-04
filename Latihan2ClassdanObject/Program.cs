
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan2ClassdanObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new Mobil();
            mobil1.Warna = "Red";
            mobil1.Jmlh = 2;
            mobil1.Merk = "Ferrari";
            mobil1.Model = "mobil sport";
            mobil1.Thn = 2010;


            
            mobil1.Kecepatan = "2000 km/h";
            mobil1.TampilkanInfo();

            Console.WriteLine("\n");
            Console.WriteLine("===================");

            Mobil mobil2 = new Mobil();
            mobil2.Warna = "Yellow";
            mobil2.Jmlh = 2;
            mobil2.Merk = "mustang GT";
            mobil2.Model = "mobil sport";
            mobil2.Thn = 2012;

            mobil1.Kecepatan = "2000 km/h";
            mobil2.TampilkanInfo();


            Console.ReadKey();

        }
    }
}
