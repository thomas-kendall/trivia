using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.TestData.TestObjects
{
    public abstract class TestObject<TEntity>
    {
        public TEntity Entity { get; protected set; }
    }
}
