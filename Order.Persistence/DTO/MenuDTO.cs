using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Order.Persistence.DTO
{
    public class MenuDTO
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public int CategoryID { get; set; }

       
        public Category Category { get; set; }

        public String Description { get; set; }
        [Required]
        public Int32 Price { get; set; }

        public bool Spicy { get; set; }

        public bool Vegetarian { get; set; }
        public int Count { get; set; }

        
        public override Boolean Equals(Object obj)
        {
            return (obj is MenuDTO dto) && ID == dto.ID;
        }
    }
}
