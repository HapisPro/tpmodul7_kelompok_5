using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_5.models
{
    public class KuliahMahasiswa_103022300003
    {
        public List<Courses> courses { get; set; }

        public void ReadJSON()
        {
            string filePath = Path.GetFullPath("../../../../datas/tp7_2_103022300003.json");
            string jsonString = File.ReadAllText(filePath);

            KuliahMahasiswa_103022300003 courseList = JsonSerializer.Deserialize<KuliahMahasiswa_103022300003>(jsonString);

            int i = 1;
            foreach (var course in courseList.courses)
            {
                Console.WriteLine($"MK{i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}
