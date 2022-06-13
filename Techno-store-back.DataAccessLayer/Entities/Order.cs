using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Techno_store_back.DAL.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public bool Condition { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeProcessing { get; set; }
        [ForeignKey("LaptopId")]
        public Laptop Laptop { get; set; }
        public int LaptopId { get; set; }
    }
}
