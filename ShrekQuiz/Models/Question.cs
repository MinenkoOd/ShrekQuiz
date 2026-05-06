namespace ShrekQuiz.Models;

public class Question
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public List<string> Options { get; set; } = [];
    public int CorrectAnswerIndex { get; set; }
    public string ImagePath { get; set; } = string.Empty;
}
