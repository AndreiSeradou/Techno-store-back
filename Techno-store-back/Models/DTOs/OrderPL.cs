using System;
using Techno_store_back.DAL.Entities;

namespace Techno_store_back.Web.Models.DTOs
{
    public class OrderPL
    {
        public int Id { get; set; }
        public bool Condition { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeProcessing { get; set; }
        public int LaptopId { get; set; }
    }
}
