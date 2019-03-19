using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndraBagusP3
{
   
    public class Mahasiswa
    {
        public string Nim { get; set; }
        public string Nama { get; set; }
        public float Ipk { get; set; }


        public void regristrasi()
        {
            Console.WriteLine("Nama : {0} ", Nama);
            Console.WriteLine("NIM : {0} ", Nim);
            Console.WriteLine("IPK : {0} ", Ipk);
            Console.WriteLine("\n Telah Melakukan Regristrasi");
        }
        public void isikrs()
        {
            Console.WriteLine("{0} Sedang Melakukan Proses Krs ", Nama);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            saya.Nim = "12345";
            saya.Nama = "Jono";
            saya.Ipk = 3.95f;

            kamu.Nim = "123456";
            kamu.Nama = "Paijo";
            kamu.Ipk = 3.70f;

            saya.regristrasi();
            saya.isikrs();

            kamu.regristrasi();
            kamu.isikrs();

            Console.ReadKey();


        }
    }
}

