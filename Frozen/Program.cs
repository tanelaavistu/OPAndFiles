using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class SS
    {
        string who;
        string what;

        public SS(string _who, string _what)
        {
            who = _who;
            what = _what;
        }

        //getters for SS(Secret Santa)

        public string Who
        {
            get { return who; }
        }
        public string What
        {
            get { return what; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<SS> mySecretSanta = new List<SS>();
            string[] ssFromFile = GetDataFromFile();
            foreach (string line in ssFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                SS newSS = new SS(tempArray[0], tempArray[1]);
                mySecretSanta.Add(newSS);
            }

            foreach (SS ssFromList in mySecretSanta)
            {
                Console.WriteLine($"{ssFromList.Who} wants {ssFromList.What} for Christmas.");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\***\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }


}
