using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;
using Trivia.Core.Repository;

namespace Trivia.TestData.TransferObjects
{
    public class QuestionTO : TransferObject<Question>
    {
        private string Text { get; set; }

        public QuestionTO(object key, string text)
        {
            this.Key = key;
            this.Text = text;
        }

        public override Question Materialize(ITestDataManager testDataManager)
        {
            var entity = (Question)testDataManager.FindTestObjectByKey(Key);
            if(entity == null)
            {
                entity = new Question();
                entity.Text = Text;
                testDataManager.AddTestObject(Key, entity);
            }
            return entity;
        }
    }
}
