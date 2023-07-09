using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    public class HoneyManufacturer : Bee
    {
        public HoneyManufacturer(string job): base(job) { }

        public override float CostPerShift => 1.7f;
    }
}
