using System.Collections.Generic;
using Techno_store_back.DAL.Entities;

namespace Techno_store_back.Web.Models.DTOs
{
    public class CatalogPL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Laptop> Laptops { get; set; }
    }
}
