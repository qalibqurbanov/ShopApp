using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBrand.WebUI.Models.Entities
{
    /// <summary>
    /// Diger entitylerin ortaq ozelliklerini saxlayan base entity sinifidir.
    /// </summary>
    public class BaseEntity
    {
        public int ID { get; set; }

        public int? CreatedByUserId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int? DeletedByUserId { get; set; }
        public DateTime? DeletedDate { get; set; } = DateTime.Now;
    }
}
