using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobsPizza.DTO
{
    public class DtoOrder
    {
        public System.Guid OrderID { get; set; }
        public DTO.Enums.PizzaSize Size { get; set; }
        public DTO.Enums.CrustType Crust { get; set; }
        public bool Sausage { get; set; }
        public bool Pepperoni { get; set; }
        public bool Onions { get; set; }
        public bool Green_Peppers { get; set; }
        public double Cost { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public bool Status { get; set; }
    }
}
