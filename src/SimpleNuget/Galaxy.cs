namespace SimpleNuget;

public class Galaxy
{
    public string? Name { get; private set; }
    public int Distance { get; private set; }

    public void AddStar(string name, int distance)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Value cannot be null or empty.", nameof(name));
        }

        if (distance <= 0) throw new ArgumentException(nameof(distance));

        Name = name;
        Distance = distance;

        //teste
    }
}
