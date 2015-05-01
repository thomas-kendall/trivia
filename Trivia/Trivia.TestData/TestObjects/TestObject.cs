using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.TestData.TransferObjects;

namespace Trivia.TestData.TestObjects
{
    public abstract class TestObject<T, U>
        where T : TransferObject<U>
    {
        public T TransferObject { get; protected set; }

        private static List<TestObject<T, U>> _Values = new List<TestObject<T, U>>();

        public TestObject()
        {
            _Values.Add(this);
        }

        public static IEnumerable<TestObject<T, U>> values
        {
            get
            {
                return _Values.AsEnumerable();
            }
        }
    }
}
