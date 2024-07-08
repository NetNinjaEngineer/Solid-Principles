namespace OCP;

public static class QuestionBank
{
    public static List<Question> Generate()
    {
        return new List<Question>
        {
            new Question
            {
                Title = "What are the four pillars of OOP?",
                QuestionType = QuestionType.WHQuestion,
                Mark = 8
            },
            new Question
            {
                Title = "Which of the following are value types?",
                QuestionType = QuestionType.MultiChoiceQuestion,
                Mark = 6,
                Choices = new List<string>
                {
                    "A: Integer",
                    "B: Array",
                    "C: Single",
                    "D: String",
                    "E: Long",
                }
            },
           new Question
            {
                Title = "Earth is Bigger than sun?",
                QuestionType = QuestionType.TrueFalseQuestion,
                Mark = 4
            },
            new Question
            {
                Title = "Which of the following is an 8-byte Integer?",
                QuestionType = QuestionType.MultiChoiceQuestion,
                Mark = 6,
                Choices = new List<string>
                {
                   "A.  Char",
                   "B.  Long",
                   "C.  Short",
                   "D.  Byte",
                   "E.  Integer"
                }
            }

        };
    }
}
