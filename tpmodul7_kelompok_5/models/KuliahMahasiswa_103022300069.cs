﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_5.models
{
    public class Courses
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class KuliahMahasiswa_103022300069
    {
        public List<Courses> courses { get; set; }

        public void ReadJSON()
        {
            string filePath = Path.GetFullPath("../../../../datas/tp7_2_103022300069.json");
            string jsonString = File.ReadAllText(filePath);

            KuliahMahasiswa_103022300069 courseList = JsonSerializer.Deserialize<KuliahMahasiswa_103022300069>(jsonString);
           
            int i = 1;
            foreach (var course in courseList.courses)
            {
                Console.WriteLine($"MK{i} {course.code} - {course.name}");
                i++;
            }

        }
    }
}
