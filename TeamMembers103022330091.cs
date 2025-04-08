using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7
{
    class TeamMembers103022330091
    {
        public class Members
        {
            public List<Member> members { get; set; }
        }

        public class Member
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
        }

        public static void readJSON()
        {
            try
            {
                string json = File.ReadAllText("jurnal7_2_103022330091.json");
                Members memberList = JsonSerializer.Deserialize<Members>(json);

                Console.WriteLine("Team member list: ");
                foreach (Member member in memberList.members)
                {
                    Console.WriteLine($"{member.nim} - {member.firstName} {member.lastName} ({member.age} {member.gender})");
                }
            } catch (Exception e)
            {
                Console.WriteLine($"[Error] {e}");
            }
        }
    }
}
