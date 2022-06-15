﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_store_back.DAL.Entities;

namespace Techno_store_back.DAL.Models.DTOs
{
    public class CatalogDAL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Laptop> Laptops { get; set; }
    }
}
