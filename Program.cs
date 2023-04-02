using System;
using tpmodul7_group5;
namespace tpmodul7_group5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa1302210001_PRAKTIKAN dataMahasiswa = new DataMahasiswa1302210001_PRAKTIKAN();
            dataMahasiswa.ReadJSON();

            Console.ReadKey();
        }
    }
}
