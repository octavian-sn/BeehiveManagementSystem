using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    public class Queen :Bee
    {
        private float eggs;

        private float unassignedWorkers = 3;

        private const float EGGS_PER_SHIFT = 0.45f;

        private const float HONEY_PER_UNASSIGNED_WORKER = 0.5f;

        private Bee[] workers;

        public Queen(string job) : base(job) {
            AssignBee("Egg Care");
            AssignBee("Nectar Collector");
            AssignBee("Honey Manufacturer");
        }

        public override float CostPerShift => 2.15f;

        private void AddWorker(Bee worker)
        {
            if (unassignedWorkers >= 1)
            {
                unassignedWorkers--;
                Array.Resize(ref workers, workers.Length + 1);
                workers[workers.Length - 1] = worker;
            }
        }

        public void AssignBee(string job)
        {
            switch (job)
            {
                case "Egg Care":
                    AddWorker(new EggCare(job));
                    break;
                case "Nectar Collector":
                    AddWorker(new NectarCollector(job));
                    break;
                case "Honey Manufacturer":
                    AddWorker(new HoneyManufacturer(job));
                    break;
            }
        }

        void CareForEggs (float eggsToConvert)
        {
            if (eggs >= eggsToConvert) unassignedWorkers += eggsToConvert;
            eggs -= eggsToConvert;
        }

        protected override void DoJob()
        {
            eggs *= EGGS_PER_SHIFT;

            foreach (var worker in workers)
            {
                worker.WorkTheNextShift();
            }

            HoneyVault.ConsumeHoney(HONEY_PER_UNASSIGNED_WORKER * workers.Length);

        }

        private void UpdateStatusReport() {
            int nectar = 0;
            int honey = 0;
            int care = 0;
            foreach (var worker in workers)
            {
                if (worker.Job == "Egg Care") care++;
                if (worker.Job == "Nectar Collector") nectar++;
                if (worker.Job == "Honey Manufacturer") honey++;
            }
            string message = $"{HoneyVault.StatusReport}" + $"\n\nEgg count: {eggs}" + $"\nUnassigned workers: {unassignedWorkers}" + $"\n{nectar} Nectar Collector bees" + $"\n{honey} Honey Manufacturer bees" + $"\n{care} Egg Care bees" + $"\nTOTAL WORKERS: {workers.Length}" ;

            Console.WriteLine(message); ;
        }
    }
}
