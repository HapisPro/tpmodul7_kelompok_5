using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tpmodul7_kelompok_5.models
{
    public class Nama_Bintang
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class DataMahasiswa_103022300058
    {
        public Nama_Bintang nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }

        public void ReadJSON()
        {
            string filePath = Path.GetFullPath("../../../../datas/tp7_1_103022300058.json");

            string jsonString = File.ReadAllText(filePath);
            

            DataMahasiswa_103022300058 dataBintang = JsonSerializer.Deserialize<DataMahasiswa_103022300058>(jsonString);
            Console.WriteLine($"Nama {dataBintang.nama.depan} {dataBintang.nama.belakang} dengan nim {dataBintang.nim} dari fakultas {dataBintang.fakultas}");
        }   

    }
}
