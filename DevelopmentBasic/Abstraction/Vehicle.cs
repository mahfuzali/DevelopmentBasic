using System;
using System.Collections.Generic;
using System.Text;

namespace DevelopmentBasic.Abstraction
{
    public abstract class Vehicle
    {
        public abstract bool VehicleComponentsStatus(int millagesRunFromLastService, string engineOilLevel, string tyresConditions);

        public void RequiredService(bool status) {
            if (status)
            {
                Console.WriteLine("Service Required");
            }
            else 
            {
                Console.WriteLine("Service not necessary");
            }
        }
    }

    internal class Car : Vehicle
    {
        public override bool VehicleComponentsStatus(int millagesRunFromLastService, string engineOilLevel, string tyresConditions)
        {
            return millagesRunFromLastService > 500 || engineOilLevel == "ADD" || tyresConditions == "POOR" ? true : false;
        }
    }

    internal class MotoCycle : Vehicle
    {
        public override bool VehicleComponentsStatus(int millagesRunFromLastService, string engineOilLevel, string tyresConditions)
        {
            return millagesRunFromLastService > 200 || engineOilLevel == "ADD" || tyresConditions == "POOR" ? true : false;
        }
    }

    internal sealed class ServiceVehicle {
        List<Vehicle> vehicles = new List<Vehicle>();
        
        public void Service() {
            int millagesRunFromLastService = 600;
            string engineOilLevel = "FULL";
            string tyresConditions = "POOR";

            foreach (Vehicle vehicle in vehicles) {
                bool vehicleCheck = vehicle.VehicleComponentsStatus(millagesRunFromLastService, engineOilLevel, tyresConditions);
                vehicle.RequiredService(vehicleCheck); 
            }
        }
    }
}
