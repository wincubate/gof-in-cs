using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Scraping
{
    class Program
    {
        async static Task Main(string[] args)
        {
            LinkScraper original = new LinkScraper("http://www.jp.dk");
            await original.ScrapeAsync();

            foreach (LinkInfo info in original.AnalysisResult)
            {
                Console.WriteLine( $"Reference to {info.Href} at index {info.Index}" );
            }

            Console.ReadLine();
        }
    }
}
