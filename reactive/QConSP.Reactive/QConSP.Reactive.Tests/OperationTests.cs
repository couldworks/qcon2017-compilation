using Microsoft.Reactive.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace QConSP.Reactive.Tests
{
    public class OperationTests: ReactiveTest
    {
        [Fact]
        public void TesteMathod()
        {
            bool next = false;
            var res = Observer.Create<int>(x => 
            {
                Assert.Equal(42, x); next = true;
            });

            res.OnNext(42);

            Assert.True(next);

            res.OnCompleted();
        }
    }
}
