using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Scraping
{
    class Program
    {
        async static Task Main( string[] args )
        {
            LinkScraper ls = new LinkScraper("http://www.jp.dk");
            await ls.ScrapeAsync();

            IEnumerable<LinkInfo> result = ls.AnalysisResult;
            foreach (LinkInfo info in result)
            {
                Console.WriteLine($"Reference to {info.Href} at index {info.Index}");
            }

            Console.ReadLine();
        }
    }
}
