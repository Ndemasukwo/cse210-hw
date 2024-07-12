public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by focusing on your breathing.", 50) { }

    public void Run()
    {
        DisplayStartingMessage();
        // Add specific behavior for breathing activity here
        ShowCountDown(10);
        DisplayEndingMessage();
    }
}
