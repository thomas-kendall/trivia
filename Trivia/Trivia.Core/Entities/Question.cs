using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.Core.Entities
{
    public class Question : Entity
    {
        public string Text { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }

        public Question()
        {
            Answers = new List<Answer>();
        }

        public Answer CorrectAnswer
        {
            get
            {
                return Answers.SingleOrDefault(a => a.IsCorrect);
            }
        }
    }
}
