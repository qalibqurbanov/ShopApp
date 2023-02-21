using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBrand.WebUI.Models.Entities
{
    public class ProductSize : BaseEntity
    {
        public string Abbreviatura { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
