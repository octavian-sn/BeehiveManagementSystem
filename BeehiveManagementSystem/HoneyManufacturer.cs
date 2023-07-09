﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    public class HoneyManufacturer : Bee
    {
        public override float CostPerShift => 1.7f;

        const float NECTAR_PROCESSED_PER_SHIFT = 33.15f;
        
        public HoneyManufacturer(string job): base(job) { }

        protected override void DoJob()
        {
            HoneyVault.ConvertNectarToHoney(NECTAR_PROCESSED_PER_SHIFT);
        }
    }
}
