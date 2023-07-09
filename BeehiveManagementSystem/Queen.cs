using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class Queen :Bee
    {
        public Queen(string job) : base(job) { }

        public override float CostPerShift => 2.15f;

    }
}
