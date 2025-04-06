using System;
using tpmodul7_kelompok_5.models;

namespace tpmodul7_kelompok_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_103022300069 hafizh = new DataMahasiswa_103022300069();
            KuliahMahasiswa_103022300069 kuliahHafizh = new KuliahMahasiswa_103022300069();
            hafizh.ReadJSON();
            Console.WriteLine("");
            kuliahHafizh.ReadJSON();
            Console.WriteLine("");

            DataMahasiswa_103022300058 bintang = new DataMahasiswa_103022300058();
            KuliahMahasiswa_103022300058 kuliahBintang = new KuliahMahasiswa_103022300058();
            bintang.ReadJSON();
            Console.WriteLine("");
            kuliahBintang.ReadJSON();
            Console.WriteLine("");

            DataMahasiswa_103022300094 syarif = new DataMahasiswa_103022300094();
            KuliahMahasiswa_103022300094 kuliahSyarif = new KuliahMahasiswa_103022300094();
            syarif.ReadJSON();
            Console.WriteLine("");
            kuliahSyarif.ReadJSON();
            Console.WriteLine("");
        }
    }
}