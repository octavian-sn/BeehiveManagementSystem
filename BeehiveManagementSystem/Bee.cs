using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    public class Bee
    {
        public virtual float CostPerShift { get; }
        public string Job { get; }
        public Bee(string job)
        {
            Job = job;
        }
        public void WorkTheNextShift()
        {
          if (HoneyVault.ConsumeHoney(CostPerShift)) DoJob();
        }
        protected virtual void DoJob() { /* Will be over-written by subclass */ }
    }
}
