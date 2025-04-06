    using System;
    using System.IO;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    namespace tpmodul7_kelompok_5.models
    {
        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public class DataMahasiswa_103022300069
        {
            public Nama nama { get; set; }
            public long nim { get; set; }
            public string fakultas { get; set; }

            public void ReadJSON()
            {
                string filePath = Path.GetFullPath("../../../../datas/tp7_1_103022300069.json");

                string jsonString = File.ReadAllText(filePath);

                DataMahasiswa_103022300069 dataHafizh = JsonSerializer.Deserialize<DataMahasiswa_103022300069>(jsonString);
                Console.WriteLine($"Nama {dataHafizh.nama.depan} {dataHafizh.nama.belakang} dengan nim {dataHafizh.nim} dari fakultas {dataHafizh.fakultas}");
            }
        }
    }
