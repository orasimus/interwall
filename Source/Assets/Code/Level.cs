public class Level
{
    public string Interval { get; set; }
    public string WrongInterval1 { get; set; }
    public string WrongInterval2 { get; set; }

    public override string ToString()
    {
        return string.Format(
            "Level: Correct interval {0}, wrong intervals {1} and {2}.",
            Interval, WrongInterval1, WrongInterval2);
    }
}
