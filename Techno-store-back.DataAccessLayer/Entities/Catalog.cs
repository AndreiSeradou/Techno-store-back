using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_store_back.DAL.Entities
{
    public class Catalog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Laptop> Laptops { get; set; }
    }
}
