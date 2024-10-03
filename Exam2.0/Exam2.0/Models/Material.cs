using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Models
{
    public class Material
    {
        public int MaterialId { get; set; }
        public string Name { get; set; }
        public decimal CostPerSquareMeter { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }

        public Material()
        {
            Products = new HashSet<Product>();
        }
    }

}
