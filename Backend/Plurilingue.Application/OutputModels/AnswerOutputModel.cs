namespace Plurilingue.Application.OutputModels
{
    public class AnswerOutputModel
    {
        public long Id { get; set; }
        public long Question_Id { get; set; }
        public string TextContent { get; set; }
        public bool IsBestAnswer { get; set; }
    }
}
