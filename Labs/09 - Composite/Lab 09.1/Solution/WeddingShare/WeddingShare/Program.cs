using System;

namespace WeddingShare
{
    class Program
    {
        static void Main( string[] args )
        {
            // Group 1
            Person noah = new Person("Noah");
            Person frederikke = new Person("Frederikke");
            Person ane = new Person("Ane");
            Person jesper = new Person("Jesper");

            // Group 2
            Person peter = new Person("Peter");
            Person malene = new Person("Malene");

            // Individuals
            Person thomas = new Person("Thomas");
            Person rasmus = new Person("Rasmus");
            Person mads = new Person("Mads");

            Group all = new Group(
                new Group ( noah, frederikke, ane, jesper ),
                new Group ( peter, malene ),
                thomas,
                rasmus,
                mads
            );

            // Share balanced by groups
            decimal giftPrice = 2500;
            all.MustPay = giftPrice;

            // Print the bill
            Console.WriteLine( all );
        }
    }
}

























