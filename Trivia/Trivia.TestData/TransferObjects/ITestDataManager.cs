using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.TestData.TransferObjects
{
    public interface ITestDataManager
    {
        void AddTestObject(object key, object value);

        object FindTestObjectByKey(object key);
    }
}
