using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace allariProject.Models
{
    public interface ITransient
    {
    }

    public interface IScoped
    {
    }


    public class Customers: ITransient, IScoped
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public string Address { get; set; }
        public int ServiceId { get; set; }

        public static IEnumerable<Customers> GetCustomers()
        {
            List<Customers> lstcustomers = new List<Customers>()
            {
                new Customers{Id=1, Name="Jose", Address= "Street XYZ", ServiceId = 1},
                new Customers{Id=2, Name="Mario", Address= "Street ABC", ServiceId = 4},
                new Customers{Id=3, Name="Jesus", Address= "Street DDD", ServiceId = 1},
                new Customers{Id=4, Name="Karina", Address= "Street AWS", ServiceId = 1},
                new Customers{Id=5, Name="Mateo", Address= "Street XCV", ServiceId = 1},
                new Customers{Id=6, Name="Joseph", Address= "Street EFV", ServiceId = 2},
                new Customers{Id=7, Name="Nicolas", Address= "Street YUH", ServiceId = 3},
                new Customers{Id=8, Name="Andres", Address= "Street OLK", ServiceId = 1},
                new Customers{Id=9, Name="Jorge", Address= "Street UIU", ServiceId = 2},
                new Customers{Id=10, Name="Danny", Address= "Street SSS", ServiceId = 3},
            };
            return lstcustomers;

        }
    }
}