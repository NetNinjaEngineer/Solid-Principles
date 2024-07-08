namespace OCP.After;

public class TrueFalseQuestion : Question
{
    public override void Print()
    {
        base.Print();
        Console.WriteLine(" 1. True");
        Console.WriteLine(" 2. False");
    }
}