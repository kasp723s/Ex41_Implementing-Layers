using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex41_Implementing_Layers.Application
{
    public class PetRepo : IObserver
    {
        private IObservable Pet; 
        public void Update()
        {
            throw new NotImplementedException();
        }
        public PetRepo(IObservable o, string name)
        {
            o.Notify();
        }


    }
}
