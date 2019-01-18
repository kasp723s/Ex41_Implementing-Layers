using Ex41_Implementing_Layers.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex41_Implementing_Layers
{
    public class Pet : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();
        public string PetName { get; set; }
        public string PetBreed { get; set; }
        public string PetType { get; set; }
        public string PetDOB { get; set; }
        public string PetWeight { get; set; }
        public string OwnerID { get; set; }

        public Pet(string petName, string petBreed, string petType, string petDOB, string petWeight, string ownerID)
        {
            PetName = petName;
            PetBreed = petBreed;
            PetType = petType;
            PetDOB = petDOB;
            PetWeight = petWeight;
            OwnerID = ownerID;
            Notify();
        }

        public void Attach(IObserver o)
        {
            observers.Add(o);
            //Notify();
        }

        public void Detach(IObserver o)
        {
            observers.Remove(o);
            //Notify();
        }

        public void Notify()
        {
            
        }
    }
}
