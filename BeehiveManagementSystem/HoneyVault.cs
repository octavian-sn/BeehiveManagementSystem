using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    static class HoneyVault
    {
        private const float NECTAR_CONVERSION_RATIO = .19f;

        private const float LOW_LEVEL_WARNING = 10f;

        private static float honey = 25f;

        private static float nectar = 100f;

        public static void ConvertNectarToHoney (float amount)
        {
            if (nectar < amount) {  
                honey += nectar * NECTAR_CONVERSION_RATIO;
                nectar = 0;
            }
            else
            {
                honey += amount * NECTAR_CONVERSION_RATIO;
                nectar -= amount;
            }
        }

        public static bool ConsumeHoney(float amount)
        {
            if (honey >= amount) 
            {
                honey -= amount;
                return true;
            }
            return false;
        }
        
        public static void CollectNectar(float amount)
        {
            if (amount > 0f) nectar += amount;
        }

        public static string StatusReport
        {
            get{
                string message = $"{honey:0.0} units of honey \n" + $"{nectar:0.0} units of nectar";
                string warnings = "";
                if (honey < LOW_LEVEL_WARNING) warnings += "\nLOW HONEY - ADD A HONEY MANUFACTURER";
                if (nectar < LOW_LEVEL_WARNING) warnings += "\nLOW NECTAR - ADD A NECTAR COLLECTOR";
                return message + warnings;
            }
        }
    }
}
