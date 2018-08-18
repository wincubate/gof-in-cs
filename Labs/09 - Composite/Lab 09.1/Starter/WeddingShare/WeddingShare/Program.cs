using System;
using System.Collections.Generic;

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

            List<Person> participants = new List<Person>
            {
                noah,
                frederikke,
                ane,
                jesper,

                peter,
                malene,

                thomas,
                rasmus,
                mads
            };

            decimal giftPrice = 2500;

            // Equal sharing among all participants
            foreach (Person person in participants)
            {
                person.MustPay = giftPrice / participants.Count;
            }

            // Print the bill
            foreach (Person person in participants)
            {
                Console.WriteLine( person );
            }
        }
    }
}