using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}

/*
Extra Features Added:
To make this mindfulness program more engaging and user-friendly, several enhancements have been implemented. Meaningful spinner and countdown animations have been added during pauses to make the experience more interactive. Detailed prompts and instructions are provided to guide users through each activity, ensuring clarity and ease of use. After completing the listing activity, users receive feedback on the number of items they listed, adding a sense of accomplishment. The code is designed with separate classes for each activity, ensuring it is easy to maintain and extend. Additionally, random prompts and questions in the reflection and listing activities offer a varied experience each time, and users can set their own activity duration for greater flexibility.
*/
```