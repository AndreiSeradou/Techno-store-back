using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_store_back.DAL.Entities;

namespace Techno_store_back.DAL.Models.DTOs
{
    public class OrderDAL
    {
        public int Id { get; set; }
        public bool Condition { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeProcessing { get; set; }
        public Laptop Laptop { get; set; }
    }
}
