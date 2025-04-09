using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GlossaryItem_103022330076.GlossaryItem_103022330076.Glossary.GlossDiv.GlossList.GlossEntry;

namespace GlossaryItem_103022330076
{
    class GlossaryItem_103022330076
    {
            public Glossary glossary { get; set; }
            public Glossary.GlossDiv glossdiv { get; set; }
            public Glossary.GlossDiv.GlossList glosslist { get; set; }
            public Glossary.GlossDiv.GlossList.GlossEntry glossentry { get; set; }
            public Glossary.GlossDiv.GlossList.GlossEntry.GlossDef glossdef { get; set; }

            public class Glossary
            {
                public class GlossDiv
                {
                    public class GlossList
                    {
                        public class GlossEntry
                        {
                            public int ID { get; set; }
                            public string SortAs { get; set; }
                            public string GlossTerm { get; set; }
                            public string Acronym { get; set; }
                            public string Abbrev { get; set; }
                            public string GlossSee { get; set; }
                            public class GlossDef
                            {
                                public int para { get; set; }
                                public int GlossSeeAlso { get; set; }
                            }
                        }
                    }
                }
            }

            public void ReadJSON()
            {
                string dataJSON = File.ReadAllText("jurnal7_3_103022330076.json");
                var data = JsonConvert.DeserializeObject<GlossaryItem_103022330076>(dataJSON);
                Console.Write(data.glossentry.ID + ", " +  data.glossentry.SortAs + ", " + data.glossentry.GlossTerm + ", " + data.glossentry.Acronym + ", " + data.glossentry.Abbrev + ", " + data.glossdef.para + ", " + data.glossdef.GlossSeeAlso + ", " + data.glossentry.GlossSee);
            }
        }

    public class pROgRAM
    {
        public static void Main(String[] args)
        {
            GlossaryItem_103022330076 gloss = new GlossaryItem_103022330076();
            gloss.ReadJSON();
        }
    }
}
