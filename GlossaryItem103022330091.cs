using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7
{
    class GlossaryItem103022330091
    {
        public class GlossaryItem
        {
            public Glossary glossary { get; set; }
        }

        public class Glossary
        {
            public string title { get; set; }
            public GlossDiv GlossDiv { get; set; }
        }

        public class GlossDiv
        {
            public string title { get; set; }
            public GlossList GlossList { get; set; }
        }

        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; }
        }

        public class GlossEntry
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }

            public GlossDef GlossDef { get; set; }
            public string GlosSee { get; set; }
        }

        public class GlossDef
        {
            public string para { get; set; }
            public List<string> GlossSeeAlso { get; set; }
        }

        public static void readJSON()
        {
            try
            {
                string json = File.ReadAllText("jurnal7_3_103022330091.json");
                GlossaryItem glossaryItem = JsonSerializer.Deserialize<GlossaryItem>(json);

                GlossEntry glossEntry = glossaryItem.glossary.GlossDiv.GlossList.GlossEntry;

                Console.WriteLine($"ID: {glossEntry.ID},\nSortAs: { glossEntry.SortAs}\nGlossTerm: {glossEntry.GlossTerm}" +
                    $"\nAcronym: {glossEntry.Acronym}\nAbbrev: {glossEntry.Abbrev}\nGlossDef: \n" +
                    $"para: {glossEntry.GlossDef.para}\nGlossSeeAlso: {glossEntry.GlossDef.GlossSeeAlso.ElementAt(0) + glossEntry.GlossDef.GlossSeeAlso.ElementAt(1)}" +
                    $"\nGlossSee: {glossEntry.GlosSee}");
            } catch (Exception e)
            {
                Console.WriteLine($"[Error] {e}");
            }
        }
    }


}
