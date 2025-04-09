using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamMembers_103022330076
{
    class TeamMembers_103022330076
    {
        public List<Members> members { get; set; }

        public class Members
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public string age { get; set; }
            public string nim { get; set; }
        }

        public void ReadJSON()
        {
            string dataJSON = File.ReadAllText("jurnal7_2_103022330076.json");
            var data = JsonConvert.DeserializeObject<TeamMembers_103022330076>(dataJSON);
            Console.WriteLine("Team member list:");
            for (int i = 0; i < data.members.Count; i++)
            {
                Console.Write(data.members[i].nim + ", " + data.members[i].firstName + " " + data.members[i].lastName + " (" + data.members[i].age + ", " + data.members[i].gender + ")");
                Console.WriteLine(" ");
            }
        }


    }

    //public class PROgram
    //{
    //    public static void Main(String[] args)
    //    {
    //        TeamMembers_103022330076 teamMEMBERS = new TeamMembers_103022330076();
    //        teamMEMBERS.ReadJSON();
    //    }
    //}
}
