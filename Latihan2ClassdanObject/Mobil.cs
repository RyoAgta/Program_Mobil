using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Latihan2ClassdanObject
{
    public class Mobil
    {
        private string warna;
        private string merek;
        private string model;
        private string kecepatan;
        private int JumlahPintu;
        private int TahunKeluar;



        public string Warna
        {
            get
            {
                return warna;
            }
            set
            {
                warna = value;
            }
        }
        public int Jmlh
        {
            get
            {
                return JumlahPintu;
            }
            set
            {
                JumlahPintu = value;
            }
        }
        public string Merk
        {
            get { return merek; }
            set
            {
                merek = value;
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                model = value;
            }
        }
        public int Thn
        {
            get { return TahunKeluar; }
            set
            {
                TahunKeluar = value;
            }
        }
        public string Kecepatan
        {
            get { return kecepatan; }
            set
            {
                kecepatan = value;
            }
            
        }
        public void TampilkanInfo()
        {
            Console.WriteLine("Mobil saya berwarna{0}, merk {1}, Model {2} Berjalan dengan kecepatan {3} Keluaran Tahun {4} Dengan Jumlah Pintu Sebanyak {5}", warna, merek, model, Kecepatan, TahunKeluar, JumlahPintu);
        }

    }
}
