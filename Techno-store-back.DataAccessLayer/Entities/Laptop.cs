using System.ComponentModel.DataAnnotations.Schema;

namespace Techno_store_back.DAL.Entities
{
    public class Laptop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public uint Count { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string Processor { get; set; }
        public string VideoCard { get; set; }
        public string RAM { get; set; }
        public string Display { get; set; }
        public string DataStorage { get; set; }
        public string Ports { get; set; }
        public string Camera { get; set; }
        public string Audio { get; set; }
        public string Connections { get; set; }
        public string Battery { get; set; }
        public string PowerSupplyUnit { get; set; }
        public string Weight { get; set; }
        [ForeignKey("CatalogId")]
        public Catalog Catalog { get; set; }
        public int CatalogId { get; set; }
    }
}
