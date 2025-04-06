using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tpmodul7_kelompok_5.models
{ 
    public class DataMahasiswa_103022300003
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }

        public void ReadJSON()
        {
            string filePath = Path.GetFullPath("../../../../datas/tp7_1_103022300003.json");

            string jsonString = File.ReadAllText(filePath);
            

            DataMahasiswa_103022300003 dataAlbert = JsonSerializer.Deserialize<DataMahasiswa_103022300003>(jsonString);
            Console.WriteLine($"Nama {dataAlbert.nama.depan} {dataAlbert.nama.belakang} dengan nim {dataAlbert.nim} dari fakultas {dataAlbert.fakultas}");
        }   

    }
}
