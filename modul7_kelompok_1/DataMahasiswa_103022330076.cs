using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

public class DataMahasiswa_103022330076
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int age { get; set; }
    public Address address { get; set; }
    public List<Courses> courses { get; set; }

    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class Courses
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public void ReadJSON()
	{
        string dataJSON = File.ReadAllText("jurnal7_1_103022330076.json");
        var data = JsonConvert.DeserializeObject<DataMahasiswa_103022330076>(dataJSON);
        Console.Write(data.firstName + " " + data.lastName + " berumur " + data.age + " tinggal di " + data.address.streetAddress + ", di kota" + data.address.city + ", di wilayah " + data.address.state + ", mengambil course: ");
        Console.WriteLine(" ");
        Console.WriteLine("========= COURSES =========");
        for (int i = 0; i < data.courses.Count; i++)
        {
            Console.Write("Course code: " + data.courses[i].code + " dengan course bernama " + data.courses[i].name);
            Console.WriteLine(" ");
        }
	}
}

//public class ProGRAM
//{
//    public static void Main(string[] args)
//    {
//        DataMahasiswa_103022330076 dataMHS = new DataMahasiswa_103022330076();
//        dataMHS.ReadJSON();
//    }
//}
