[System.Serializable]
public class Question
{
    public int phase;
    public string questionText;
    public QuestionType type;
    public string[] options; // null if TextInput
    public string previousAnswer; // for contradiction display
}
