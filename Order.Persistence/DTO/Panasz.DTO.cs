
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Order.Persistence.DTO
{
    public class PanaszDTO
    {
        public int ID { get; set; }
        public string ManName { get; set; }
        public string ManAddress { get; set; }
        public String fail { get; set; }

        public DateTime time { get; set; }

        public bool IsOk { get; set; }

        public override Boolean Equals(Object obj)
        {
            return (obj is PanaszDTO dto) && ID == dto.ID;
        }
    }
}