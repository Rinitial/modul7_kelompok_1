using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static modul7_kelompok_1.TeamMembers_Raditya;

namespace modul7_kelompok_1
{
    class GlossaryItem_Raditya
    {
        public class GlossDef
        {
            public string para { get; set; }
            public List<string> GlossSeeAlso { get; set; }
        }

        public class GlossEntry
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public GlossDef GlossDef { get; set; }
            public string GlossSee { get; set; }
        }

        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; }
        }

        public class GlossDiv
        {
            public string title { get; set; }
            public GlossList GlossList { get; set; }
        }

        public class Glossary
        {
            public string title { get; set; }
            public GlossDiv GlossDiv { get; set; }
        }

        public class GlossaryItem
        {
            public Glossary glossary { get; set; }
        }

        public void ReadJson()
        {
            string jsonData = File.ReadAllText("jurnal7_3_103022330026.json");
            var glossary = JsonSerializer.Deserialize<Members>(jsonData);
            Console.WriteLine("Gloss Entry : ");
        }
    }
}
