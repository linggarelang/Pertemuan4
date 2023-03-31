using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myApps
{
    public class Program
    {
        static void Main(string[] args)
        {
            float cekIpk = 3.00f;

            // Inisialisasi variable Mahasiswa
            Mahasiswa mhs = new Mahasiswa();

            // Mengisi Property pada Objek
            mhs.Nama = "Linggar Elang Pratama";
            mhs.Nim = "22.11.4849";
            mhs.Ipk = 2.79f;

            // Ternary Operation
            string res = mhs.Ipk < cekIpk ? "Tidak Lulus" : "Lulus";

            // Menampilkan Informasi Mahasiswa
            mhs.infoMahasiswa();
            Console.WriteLine($"Dengan Nim anda {mhs.Ipk} anda dinyatakan : " + res);
        }

    }
}