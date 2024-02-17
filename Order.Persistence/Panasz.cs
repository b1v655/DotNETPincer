using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Order.Persistence
{
    public class Panasz
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string ManName { get; set; }
        [Required]
        public string ManAddress { get; set; }
        [Required]
        public String fail { get; set; }

        public DateTime time { get; set; }

        public bool IsOk { get; set; }




    }
}