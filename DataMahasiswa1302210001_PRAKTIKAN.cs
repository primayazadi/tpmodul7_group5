using System.Text.Json;



    class DataMahasiswa1302210001_PRAKTIKAN
    {
        public class Mahasiswa
        {
            public NamaLengkap nama { get; set; }

            public int nim { get; set; }

            public string fakultas { get; set; }

            public Mahasiswa() { }

            public Mahasiswa(NamaLengkap nama, int nim, string fakultas)
            {
                this.nama = nama;
                this.nim = nim;
                this.fakultas = fakultas;
            }
        }

        public class NamaLengkap
        {
            public string depan { get; set; }
            public string belakang { get; set; }

            public NamaLengkap() { }

            public NamaLengkap(string depan, string belakang)
            {
                this.depan = depan;
                this.belakang = belakang;
            }
        }
        public void ReadJSON()
        {
            string file = "C:\\Users\\acer\\source\\repos\\tpmodul7_group5\\tpmodul7_group5\\bin\\Debug\\net6.0\\tp7_1_1302210001.json";
            string JSON = File.ReadAllText(file);
            Mahasiswa d = JsonSerializer.Deserialize<Mahasiswa>(JSON);
            Console.WriteLine($"Nama {d.nama.depan + " " + d.nama.belakang} dengan NIM {d.nim} dari Fakultas {d.fakultas}");

        }
    }

   







