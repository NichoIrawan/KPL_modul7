using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static DataMahasiswa103022300108;

namespace modul7
{
    public class TeamMembers103022300108
    {
        public class Members() {
            public List<MembersItem> members { get; set; }
        }
        public class MembersItem(){
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("..//..//..//jurnal7_2_1030223000108.json");
            var members = JsonSerializer.Deserialize<Members>(json);
            Console.WriteLine("Team Member List: ");
            for (int i = 0; i < members.members.Count; i++)
            {
                Console.WriteLine(
                    members.members.ElementAt(i).nim + " " + 
                    members.members.ElementAt(i).firstName + " " + 
                    members.members.ElementAt(i).lastName + " (" +
                    members.members.ElementAt(i).age + " " +
                    members.members.ElementAt(i).gender + ") ");
            }
        }
    }
}
