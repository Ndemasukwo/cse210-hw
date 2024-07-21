using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Okon Main St", "Delta", "DA", "Nigeria");
        Address address2 = new Address("Margret Ekpo Rd", "Ebonyi State", "ES", "Nigeria");
        Address address3 = new Address("789 Oak Ave", "Port Harcourt", "PH", "Nigeria");

        Event lecture = new Lecture("The Grand Line", "Discussion on the region in the anime series One Piece", new DateTime(2024, 10, 15), "10:00 AM", address1, "Dr. Vegapunk", 100);
        Event reception = new Reception("Annual Gala", "Join us for a night of fun and networking", new DateTime(2024, 11, 20), "7:00 PM", address2, "rsvp@event.com");
        Event outdoorGathering = new OutdoorGathering("Beach Clean-Up", "Help us clean the beach and enjoy the sun", new DateTime(2024, 12, 5), "9:00 AM", address3, "Sunny with a chance of light breeze");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var evt in events)
        {
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine();
        }
    }
}
