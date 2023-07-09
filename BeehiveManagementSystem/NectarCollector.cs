﻿using System;
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
    }
}
