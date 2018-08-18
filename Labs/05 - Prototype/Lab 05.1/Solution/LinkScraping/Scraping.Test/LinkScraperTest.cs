using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Linq;

namespace Scraping.Test
{
    [TestClass]
    public class LinkScraperTest
    {
        [TestMethod]
        public async Task TestClone()
        {
            LinkScraper original = new LinkScraper("http://www.jp.dk");
            await original.ScrapeAsync();

            LinkScraper copy = original.Clone() as LinkScraper;

            Assert.AreEqual(original.Url, copy.Url);

            Assert.IsTrue(original.AnalysisResult.SequenceEqual(
                copy.AnalysisResult,
                new LinkInfoEqualityComparer()
                )
            );
        }
    }
}
