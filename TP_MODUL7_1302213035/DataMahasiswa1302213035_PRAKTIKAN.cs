using System.Text.Json;
class DataMahasiswa1302213035_PRAKTIKAN
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
        string file = "C:\\Users\\asus\\Documents\\TUGAS ADEK\\SEMESTER 4\\KPL\\TP\\tpmodul7_group5\\TP_MODUL7_1302213035\\DataMahasiswa1302213035_PRAKTIKAN.json";
        string JSON = File.ReadAllText(file);
        Mahasiswa d = JsonSerializer.Deserialize<Mahasiswa>(JSON);
        Console.WriteLine($"Nama {d.nama.depan + " " + d.nama.belakang} dengan NIM {d.nim} dari Fakultas {d.fakultas}");
    }
}