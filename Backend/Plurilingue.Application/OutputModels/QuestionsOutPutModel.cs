using System.Collections.Generic;

namespace Plurilingue.Application.OutputModels
{
    public class QuestionsOutPutModel
    {
        public long Id { get; set; }
        public UserOutputModel User { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string TextContent { get; set; }
        public List<AnswerOutputModel> Answers { set; get; }

    }
}
