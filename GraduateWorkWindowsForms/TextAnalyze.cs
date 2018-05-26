using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Language.V1;
using static Google.Cloud.Language.V1.AnnotateTextRequest.Types;
using Google.Protobuf.Collections;

namespace GraduateWorkWindowsForms
{
    public class TextAnalyze
    {
        private Dictionary<string, string> wordAndType = new Dictionary<string, string>();
        
        public Dictionary<string, string> AnalyzeEntitiesFromText(string text)
        {
            var client = LanguageServiceClient.Create();
            var response = client.AnalyzeEntities(new Document()
            {
                Content = text,
                Type = Document.Types.Type.PlainText
            });

            foreach (var entity in response.Entities)
            {
                try
                {
                    wordAndType.Add(entity.Name, entity.Type.ToString());
                }
                catch (ArgumentException)
                {

                }                   
            
            }

            //wordAndType = WriteEntities(response.Entities);
            return wordAndType;

        }

        public static string[] GetProposals(string s)
        {
            var proposals = new List<string>();
            var lastIndex = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '.' && s.Length == i + 1)
                {
                    var p = s.Substring(lastIndex, i - lastIndex + 1);
                    proposals.Add(p);
                    break;
                }

                if (s[i] == '.' && s.Length > i + 2 && s[i + 1] == ' ' && char.IsUpper(s[i + 2]))
                {
                    var p = s.Substring(lastIndex, i - lastIndex + 1);
                    proposals.Add(p);
                    lastIndex = i + 2;
                }
            }

            return proposals.ToArray();
        }

        /*

        // [START analyze_entities_from_text]
        private Dictionary<string, string> WriteEntities(IEnumerable<Entity> entities)
        {
            foreach (var entity in entities)
            {
                try
                {
                    wordAndType.Add(entity.Name, entity.Type.ToString());
                }
                catch (ArgumentException)
                {
                    break;
                }
            }
            return wordAndType;
        }

    */
    }
}
