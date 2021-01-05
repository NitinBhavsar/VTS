using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VTSAPI.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string VehicleNumber { get; set; }
        public string VehicleType { get; set; }
        public string ChassisNumber { get; set; }

        public string EngineNumber { get; set; }
        public string Manufacturingyear { get; set; }

        public string Loadcarryingcapacity { get; set; }
        public string Makeofvehicle { get; set; }
        public string ModelNumber { get; set; }

        public string Bodytype { get; set; }
        public string Organisationname { get; set; }
        public string DeviceID { get; set; }
        public string UserID { get; set; }
    }

}
