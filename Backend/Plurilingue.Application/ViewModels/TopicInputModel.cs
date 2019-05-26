using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plurilingue.Application.ViewModels
{
    public class TopicInputModel
    {
        public long User_id { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string TextContent { get; set; }
    }
}
