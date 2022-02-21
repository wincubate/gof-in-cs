using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Wincubate.CS8.Slide30
{
    class Program
    {
        static void Main()
        {
            string[] urls = new string[]
            { 
                "http://www.jp.dk", 
                "http://dr.dk", 
                "http://bold.dk" 
            };
            foreach (string s in GetWords(urls))
            {
                Console.WriteLine(s);
                Console.WriteLine();
            }
        }

        static IEnumerable<string> GetWords(string[] urls)
        {
            foreach (var url in urls)
            {
                WebClient wc = new WebClient();
                string result = wc.DownloadString(url);
                yield return result.Substring(0, 256);
            }
        }
    }
}
