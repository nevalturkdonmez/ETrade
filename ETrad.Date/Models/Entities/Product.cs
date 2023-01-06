using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrad.Date.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Img { get; set; }

        public int Stock { get; set; }
        public decimal Price { get; set; }
        public bool IsHome { get; set; } //anasayfada görünsün mü ?
        public bool IsApproved { get; set; }    //Satışta mı değil mi ?
        public Category Category { get; set; }



    }
}
