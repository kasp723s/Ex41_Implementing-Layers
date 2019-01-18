using Ex41_Implementing_Layers.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex41_Implementing_Layers
{
   public interface IObservable
    {
        void Attach(IObserver o);
        void Detach(IObserver o);
        void Notify();
    }
}
