using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Repository;

namespace Trivia.TestData.TransferObjects
{
    public abstract class TransferObject<T>
    {
        public object Key { get; set; }

        public abstract T Materialize(ITestDataManager testDataManager);
    }
}
