namespace OCP;
public class Quiz
{
    private readonly List<Question> _questions;

    public Quiz(List<Question> questions)
    {
        _questions = questions;
    }

    public void Print()
    {
        foreach (var question in _questions)
        {
            Console.WriteLine($"{question.Title} ({question.Mark})");

            switch (question.QuestionType)
            {
                case QuestionType.TrueFalseQuestion:
                    Console.WriteLine(" 1. True");
                    Console.WriteLine(" 2. False");
                    break;
                case QuestionType.WHQuestion:
                    Console.WriteLine(" -------------------- ");
                    Console.WriteLine(" -------------------- ");
                    Console.WriteLine(" -------------------- ");
                    break;
                case QuestionType.MultiChoiceQuestion:
                    foreach (var choice in question.Choices)
                    {
                        Console.WriteLine($" {choice}");
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
