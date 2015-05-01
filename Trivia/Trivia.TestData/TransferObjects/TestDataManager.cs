using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.TestData.TransferObjects
{
    public class TestDataManager : ITestDataManager
    {
        private IDictionary<object, object> testDataObjects { get; set; }

        public TestDataManager()
        {
            testDataObjects = new Dictionary<object, object>();
        }

        public void AddTestObject(object key, object value)
        {
            testDataObjects.Add(key, value);
        }

        public object FindTestObjectByKey(object key)
        {
            object value = null;
            testDataObjects.TryGetValue(key, out value);
            return value;
        }
    }
}
