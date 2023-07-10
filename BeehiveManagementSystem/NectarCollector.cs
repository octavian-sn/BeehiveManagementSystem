using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    public class NectarCollector : Bee
    {
        public override float CostPerShift => 1.95f;

        const float NECTAR_COLLECTED_PER_SHIFT = 33.25f;

        public NectarCollector() : base("Nectar Collector") { }

        protected override void DoJob()
        {
            HoneyVault.CollectNectar(NECTAR_COLLECTED_PER_SHIFT);
        }
    }
}
