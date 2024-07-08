namespace OCP.After;
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
            question.Print();
        }
    }
}
