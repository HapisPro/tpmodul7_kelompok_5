using System;
using tpmodul7_kelompok_5.models;

namespace tpmodul7_kelompok_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_103022300069 hafizh = new DataMahasiswa_103022300069();
            hafizh.ReadJSON();
            //Console.WriteLine(AppContext.BaseDirectory);
        }
    }
}