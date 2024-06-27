using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        // Instance
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Dispaly();

        {
        Journal journal = new Journal();

        Entry entry1 = new Entry { _date = "2023-01-01", _promptText = "What did you learn today?", _entryText = "I learned about C# classes." };
        journal.AddEntry(entry1);

        Entry entry2 = new Entry { _date = "2023-01-02", _promptText = "What are you grateful for?", _entryText = "I am grateful for my family." };
        journal.AddEntry(entry2);

        journal.DisplayAll();
        }
    }
}