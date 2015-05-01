using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.Core.Entities
{
    public class Answer : Entity
    {
        public string Text { get; set; }
        public Question Question { get; set; }
        public bool IsCorrect { get; set; }
    }
}
