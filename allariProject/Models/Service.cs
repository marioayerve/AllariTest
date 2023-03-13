using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace allariProject.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public static IEnumerable<Service> GetServices ()
        {
            List<Service> lstService = new List<Service>()
            {
                new Service{ServiceId=1, ServiceName="Wash"},
                new Service{ServiceId=2, ServiceName="Wash/Dry"},
                new Service{ServiceId=3, ServiceName="Complete WDW"},//WASH, DRY AND WAX
                new Service{ServiceId=4, ServiceName="Clean D'Lux"},
            };
            return lstService;
        }
    }
}