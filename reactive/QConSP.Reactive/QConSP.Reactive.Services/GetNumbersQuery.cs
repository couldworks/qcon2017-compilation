using QConSP.Reactive.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QConSP.Reactive.Services
{
    public class GetNumbersQuery<TResult, TParam> : IQuery<TResult, TParam>
    {
        public IObservable<TResult> Execute(TParam param)
        {
            return Observable.Create<TResult>( num => {
                num.OnNext(1);
                num.OnNext(2);
                num.OnNext(3);
                num.OnCompleted();
            });
        }
    }
}
