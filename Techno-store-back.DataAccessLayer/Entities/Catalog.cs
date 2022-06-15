﻿using System.Collections.Generic;

namespace Techno_store_back.DAL.Entities
{
    public class Catalog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Laptop> Laptops { get; set; }
    }
}
