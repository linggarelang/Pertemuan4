using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myApps
{
    public class Mahasiswa
    {
        // Field
        private string _nama;
        private string _nim;
        private float _ipk;

        // Property
        public string Nama
        {
            get
            {
                return _nama;
            }

            set
            {
                _nama = value;
            }
        }

        public string Nim
        {
            get
            {
                return _nim;
            }

            set
            {
                _nim = value;
            }
        }
        public float Ipk
        {
            get
            {
                return _ipk;
            }

            set
            {
                _ipk = value;
            }
        }

        public void infoMahasiswa()
        {
            Console.WriteLine("\n__________Mahasiswa Hadir__________");
            Console.WriteLine("Dengan Nama  : {0}", Nama);
            Console.WriteLine("Dengan Nim   : {0}", Nim);
            Console.WriteLine("Memiliki Ipk : {0}", Ipk);
            Console.WriteLine();
        }
    }
}