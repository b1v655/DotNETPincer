using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Order.Persistence.DTO
{
    public class OrdersDTO
    {
        [Required]
        public int ID { get; set; }

        public String Name { get; set; }

        public String Address { get; set; }

        public string PhoneNumber { get; set; }
        public string OrderedItems { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OutDate { get; set; }

        public int FullPrice { get; set; }
        public override Boolean Equals(Object obj)
        {
            return (obj is OrdersDTO dto) && ID == dto.ID;
        }
    }
}
