using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Sockets;

namespace modul7
{
    class DataMahasiswa103022330091
    {
        public class Mahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public Address address { get; set; }
            public List<Course> courses { get; set; }
        }

        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public static void readJSON()
        {
            try {
                string json = File.ReadAllText("jurnal7_1_103022330091.json");
                Mahasiswa mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(json);

                Console.WriteLine($"{mahasiswa.firstName} {mahasiswa.lastName}");
                Console.WriteLine($"Gender: {mahasiswa.gender} \t Umur: {mahasiswa.age}");
                Console.WriteLine($"Alamat: {mahasiswa.address.streetAddress}, {mahasiswa.address.city}, {mahasiswa.address.state}");
                Console.WriteLine("-- Mata Kuliah");

                for (int i = 0; i < mahasiswa.courses.Count(); i++)
                {
                    Console.WriteLine($"{mahasiswa.courses.ElementAt(i).code} - {mahasiswa.courses.ElementAt(i).name}");
                }

                Console.WriteLine();

            } catch (Exception e)
            {
                Console.WriteLine($"[Error] {e}");
            }
        }
    }
}
