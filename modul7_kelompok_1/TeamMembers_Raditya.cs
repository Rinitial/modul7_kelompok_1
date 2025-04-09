using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static modul7_kelompok_1.DataMahasiswa_Raditya;

namespace modul7_kelompok_1
{
    class TeamMembers_Raditya
    {
        public class Member()
        {
            public Nama nama { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
        }

        public class Nama()
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
        }

        public class Members()
        {
            public List<Member> members { get; set; }
        }

        public void ReadJson()
        {
            string jsonData = File.ReadAllText("jurnal7_1_103022330026.json");
            var members = JsonSerializer.Deserialize<Members>(jsonData);
            Console.WriteLine("List Anggota : ");
            for (int i = 0; i < members.members.Count; i++)
            {
                Console.WriteLine("NIM : " + members.members[i].nim);
                Console.WriteLine("Nama Anggota Ke - " + (i + 1) + " : " + members.members[i].nama.firstName + " " + members.members[i].nama.firstName)
                Console.WriteLine("Gender : " + members.members[i].gender);
                Console.WriteLine("Age : " + members.members[i].age);
            }
        }
    }
}
