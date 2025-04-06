    using System;
    using System.IO;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    namespace tpmodul7_kelompok_5.models
    {

        public class DataMahasiswa_103022300127
        {
            public Nama nama { get; set; }
            public long nim { get; set; }
            public string fakultas { get; set; }

            public void ReadJSON()
            {
                string filePath = Path.GetFullPath("../../../../datas/tp7_1_103022300127.json");

                string jsonString = File.ReadAllText(filePath);

                DataMahasiswa_103022300127 dataHizkia = JsonSerializer.Deserialize<DataMahasiswa_103022300127>(jsonString);
                Console.WriteLine($"Nama {dataHizkia.nama.depan} {dataHizkia.nama.belakang} dengan nim {dataHizkia.nim} dari fakultas {dataHizkia.fakultas}");
            }
        }
    }
