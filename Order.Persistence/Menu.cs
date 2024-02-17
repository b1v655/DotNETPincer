using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Order.Persistence
{
    public class Menu
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        [ForeignKey("Categories")]
        public Category Category { get; set; }

        public String Description { get; set; }

        public Int32 Price { get; set; }

        public bool Spicy { get; set; }

        public bool Vegetarian { get; set; }
        public int Count { get; set; }
        



    }
}
