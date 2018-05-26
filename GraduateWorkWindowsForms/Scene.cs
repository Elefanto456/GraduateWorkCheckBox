using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateWorkWindowsForms
{
    public class Scene
    {
        private int number;
        private List<Sentence> sentences = new List<Sentence>();

        public Scene()
        {

        }

        public Scene(List<Sentence> newSentences, int n)
        {
            number = n;
            for (int i = 0; i < newSentences.Count; i++)
            {
                sentences.Add(newSentences[i]);
            }
        }

        public List<Sentence> GetSceneList()
        {
            List<Sentence> result = new List<Sentence>();
            for (int i = 0; i < sentences.Count; i++)
            {
                result.Add(sentences[i]);
            }
            return result;
        }

        public string GetSceneSentence(string str)
        {
            string result = "";
            for (int i = 0; i < sentences.Count; i++)
            {
                if (str == sentences[i].GetSentence())
                {
                    result = sentences[i].GetSentence();
                }
            }
            return result;
        }
        
    }
}
