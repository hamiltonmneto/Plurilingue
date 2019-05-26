using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plurilingue.Application.OutputModels
{
    public class QuestionsOutPutModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string TextContent { get; set; }
    }
}
