using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
namespace ReadFileRandomSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("..\\..\\SentenceParts.txt");
            StringBuilder words = new StringBuilder();
            StringBuilder sentence = new StringBuilder();
            using (reader)
            {
                string line = reader.ReadLine();
                words.Append(line);
                while (line != null)
                {
                    line = reader.ReadLine();
                    words.Append(line);
                }
                string all = words.ToString();           
                string[] allWords =all.Split(',');
                string[] nouns = new string[10];
                string[] verbs = new string[2];
                string[] phrases = new string[3];
                for (int i = 0; i < nouns.Length; i++)
                   {
                    nouns[i] = allWords[i]; 
                    }                
                for (int n = 0; n<verbs.Length; n++)
                {
                    verbs[n] = allWords[n + 10];
                }
                for(int p= 0; p<phrases.Length; p++)
                {
                    phrases[p] = allWords[p + 12];
                }
                CryptoRandom randomNum = new CryptoRandom();
                int noun = randomNum.Next(1, 11);
                int verb = randomNum.Next(1, 3);
                int phrase = randomNum.Next(1, 4);                
                sentence.Append(nouns[noun-1] + " ");
                sentence.Append(verbs[verb-1] + " ");
                sentence.Append(phrases[phrase-1]);
                Console.WriteLine(sentence);
            }
            
        }
        class CryptoRandom : RandomNumberGenerator              //with thanks to Ben Klopfer at Imagine Technology Group
        {
            private static RandomNumberGenerator r;
            public CryptoRandom()
            {
                r = RandomNumberGenerator.Create();
            }
            public override void GetBytes(byte[] buffer)
            {
                r.GetBytes(buffer);
            }
            public double NextDouble()
            {
                byte[] b = new byte[4];
                r.GetBytes(b);
                return (double)BitConverter.ToUInt32(b, 0) / UInt32.MaxValue;
            }
            public int Next(int minValue, int maxValue)
            {
                return (int)Math.Round(NextDouble() * (maxValue - minValue - 1)) + minValue;
            }
            public int Next()
            {
                return Next(0, Int32.MaxValue);
            }
            public int Next(int maxValue)
            {
                return Next(0, maxValue);
            }
        }
    }
}
