
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
            mobil1.warna = "Red";
            mobil1.JumlahPintu = 2;
            mobil1.merek = "Ferrari";
            mobil1.model = "mobil sport";
            mobil1.TahunKeluar = 2010;

            mobil1.Gas(300);
            mobil1.Klakson("Beemm Bemm");
            mobil1.TampilkanInfo();

            Console.WriteLine("\n");
            Console.WriteLine("===================");

            Mobil mobil2 = new Mobil();
            mobil2.warna = "Yellow";
            mobil2.JumlahPintu = 2;
            mobil2.merek = "mustang GT";
            mobil2.model = "mobil sport";
            mobil2.TahunKeluar = 2012;

            mobil2.Gas(200);
            mobil2.Klakson("Tenn Tenn");
            mobil2.TampilkanInfo();


            Console.ReadKey();

        }
    }
}
