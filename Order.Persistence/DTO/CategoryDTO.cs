using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Persistence.DTO
{
    public class CategoryDTO
    {
        public int ID { get; set; }

        public String Name { get; set; }

        public override Boolean Equals(Object obj)
        {
            return (obj is CategoryDTO dto) && ID == dto.ID;
        }
    }
}
