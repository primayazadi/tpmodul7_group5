using System;

namespace TP_MODUL7_1302213035
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa1302213035_PRAKTIKAN dataMahasiswa = new DataMahasiswa1302213035_PRAKTIKAN();
            dataMahasiswa.ReadJSON();

            Console.ReadKey();
        }
    }
}