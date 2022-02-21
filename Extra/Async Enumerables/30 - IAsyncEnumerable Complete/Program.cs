using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Wincubate.Threading.Module10
{
    class Program
    {
        static async Task Main()
        {
            string[] urls = new string[]
            { 
                "http://www.jp.dk", 
                "http://dr.dk", 
                "http://bold.dk" 
            };
            await foreach (string s in GetWordsAsync(urls))
            {
                Console.WriteLine(s);
            }
        }

        static async IAsyncEnumerable<string> GetWordsAsync(string[] urls)
        {
            foreach (var url in urls)
            {
                WebClient wc = new WebClient();
                string result = await wc.DownloadStringTaskAsync(url);
                yield return result.Substring(0, 256);
            }
        }
    }
}
