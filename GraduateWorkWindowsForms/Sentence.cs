﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateWorkWindowsForms
{
    public class Sentence
    {
        public Dictionary<string, string> GoogleItemsDictionary = new Dictionary<string, string>();
        //public Dictionary<string, string> CustomItemsDictionary = new Dictionary<string, string>();
        private string sentence;

        TextAnalyze textAnalyze = new TextAnalyze();

        public Sentence()
        {

        }

        public Sentence(string text)
        {
            sentence = text;
            GoogleItemsDictionary = textAnalyze.AnalyzeEntitiesFromText(text);
            //CustomItemsDictionary = GoogleItemsDictionary;
        }

        public void UpdGoogleItemsDictionary(Dictionary<string, string> newDict)
        {
            GoogleItemsDictionary.Clear();
            foreach (var item in newDict)
            {
                try
                {
                    GoogleItemsDictionary.Add(item.Key, item.Value);
                }
                catch (ArgumentException)
                {

                }
            }
        }

        public Dictionary<string, string> GetGoogleItemsDictionary(string text)
        {
            return GoogleItemsDictionary;
        }

        public Dictionary<string, string> GetGoogleItemsDictionary()
        {
            return GoogleItemsDictionary;
        }


        public string GetSentence(string text)
        {
            return sentence;
        }

        public string GetSentence()
        {
            return sentence;
        }

        /*
        public void SetToGoogleItemsDictionary(string key, string value)
        {
            if (GoogleItemsDictionary.ContainsKey(key))
            {
                GoogleItemsDictionary[key] = value;
            }
            else
            {
                GoogleItemsDictionary.Add(key, value);
            }
        }
        
        public void SetToCustomItemsDictionary(string key, string value)
        {
            if (CustomItemsDictionary.ContainsKey(key))
            {
                CustomItemsDictionary[key] = value;
            }
            else
            {
                CustomItemsDictionary.Add(key, value);
            }
        }

        public string GetFromCustomItemsDictionary(string key)
        {
            string result = null;

            if (CustomItemsDictionary.ContainsKey(key))
            {
                result = CustomItemsDictionary[key];
            }

            return result;
        }
        */
    }
}
