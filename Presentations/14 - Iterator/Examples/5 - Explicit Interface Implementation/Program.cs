using System;

namespace Wincubate.IteratorExamples
{
    interface IArtist
    {
        void Draw();
    }

    interface IGunslinger
    {
        void Draw();
    }

    class ArtisticCowboy : IArtist, IGunslinger
    {
        public void Draw()
        {
            Console.WriteLine( "Swinging brush, painting canvas..." );
        }

        void IGunslinger.Draw()
        {
            Console.WriteLine("Drawing Colt .45 from gun belt...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IGunslinger ac = new ArtisticCowboy();
            ac.Draw();
        }
    }
}
