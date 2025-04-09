using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace modul7_kelompok_1
{
    class DataMahasiswa_Raditya
    {
        public class Data()
        {
            public Nama nama { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public Address address { get; set; 
            public List<Course> courses { get; set; }
        

        public class Course()
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Address()
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }

        }

        public class Nama()
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
        }

        public void ReadJSON()
        {
            string jsonData = File.ReadAllText("jurnal7_1_103022330026.json");
            var data = JsonSerializer.Deserialize<Data>(jsonData);
                Console.WriteLine("Nama Mahasiswa : " + data.nama.firstName + " " + data.nama.lastName);
                Console.WriteLine("Gender : " + data.gender);
                Console.WriteLine("Age : " + data.age);
                Console.WriteLine("Alamat : " + data.address.streetAddress + ", " + data.address.city + ", " + data.address.state);
                Console.WriteLine("Mata Kuliah : ");

                for (int i = 0; i < data.courses.Count; i++)
                {
                    Console.WriteLine("MK " + (i + 1) + data.courses[i].code + " - " + data.courses[i].name);
                }
        }
    }
}
