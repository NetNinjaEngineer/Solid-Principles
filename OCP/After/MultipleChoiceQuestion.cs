namespace OCP.After;

public class MultipleChoiceQuestion : Question
{
    public List<string> Choices { get; set; } = [];

    public override void Print()
    {
        base.Print();

        foreach (var choice in Choices)
        {
            Console.WriteLine($" {choice}");
        }
    }
}
