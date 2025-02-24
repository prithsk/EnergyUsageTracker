using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyUsageTracker
{
    
    public class Appliance
    {
        public int ApplianceID { get; set; }
        public int UserID { get; set; }
        public string ApplianceName { get; set; }
        public float Wattage { get; set; }
        public float UsageDuration { get; set; }
        public float EnergyUsage => CalculateEnergyUsage();

        public Appliance(int applianceID, int userID, string applianceName, float wattage, float usageDuration)
        {
            ApplianceID = applianceID;
            UserID = userID;
            ApplianceName = applianceName;
            Wattage = wattage;
            UsageDuration = usageDuration;
        }

        public float CalculateEnergyUsage()
        {
            return Wattage * UsageDuration; 
        }

        public void AddAppliance()
        {
            Console.WriteLine($"Appliance {ApplianceName} added for User ID: {UserID}.");
        }

        public void ModifyAppliance(float newWattage, float newUsageDuration)
        {
            Wattage = newWattage;
            UsageDuration = newUsageDuration;
            Console.WriteLine($"Appliance {ApplianceName} updated.");
        }
    }

}

