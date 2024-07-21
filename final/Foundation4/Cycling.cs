public class Cycling : Activity
{
    public double Speed { get; private set; }

    public Cycling(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return (Speed / 60) * LengthInMinutes;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }
}
