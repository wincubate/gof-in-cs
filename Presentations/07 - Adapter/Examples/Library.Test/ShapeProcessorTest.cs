using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Wincubate.AdapterExamples.Library.Test
{
    [TestClass]
    public class ShapeProcessorTest
    {
        [TestMethod]
        public void TestGetAreaOk()
        {
            TriangleStrip ts = new TriangleStrip(
                new List<Vertex>
                {
                    new Vertex( 0, 0 ),
                    new Vertex( 2, 0 ),
                    new Vertex( 2, 2 ),
                    new Vertex( 4, 2 ),
                }
            );

            ShapeProcessor processor = new ShapeProcessor();
            double actual = processor.GetArea(ts);
            double expected = 4;

            Assert.IsTrue(Math.Abs( expected - actual ) < 0.000001 ); // <-- Doubles are not precise! :-(
        }
    }
}