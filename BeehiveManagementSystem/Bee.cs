using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    public abstract class Bee : IWorker
    {
        public abstract float CostPerShift { get; }
        public string Job { get; }
        /* Not setting a private setter on Job means it's value can only be 
        set during object initialization, and in this case, that's all we need.*/
        public Bee(string job)
        {
            Job = job;
        }
        public void WorkTheNextShift()
        {
          if (HoneyVault.ConsumeHoney(CostPerShift)) DoJob();
        }
        protected abstract void DoJob();
    }
}
