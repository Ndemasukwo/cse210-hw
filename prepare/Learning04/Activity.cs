public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} Activity: {_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {_name} Activity. Duration: {_duration} seconds.");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b/");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b-");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b\\");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
