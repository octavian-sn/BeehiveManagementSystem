using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    public class NectarCollector : Bee
    {
        public NectarCollector(string job) : base(job) { }

        public override float CostPerShift => 1.95f;

        private const float NECTAR_COLLECTED_PER_SHIFT = 33.25f;

        protected override void DoJob()
        {
            HoneyVault.CollectNectar(NECTAR_COLLECTED_PER_SHIFT);
        }
    }
}
