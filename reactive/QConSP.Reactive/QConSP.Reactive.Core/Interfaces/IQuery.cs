using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QConSP.Reactive.Core
{
    public interface IQuery<TElement,TParam>
    {
        IObservable<TElement> Execute(TParam param);
    }
}
