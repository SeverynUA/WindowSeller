using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; }

        public string Forma { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public bool ExtraOrder { get; set; }
        public double Total_price { get; set; }
    }

}
