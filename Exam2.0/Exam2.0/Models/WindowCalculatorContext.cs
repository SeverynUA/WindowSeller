using Exam2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Exam2.Models
{
    public class WindowCalculatorContext : DbContext
    {
        public DbSet<Material> Materials { get; set; } = null;
        public DbSet<Product> Products { get; set; } = null;
        public DbSet<User> Users { get; set; } = null;

        public WindowCalculatorContext(DbContextOptions options) : base(options) { }

        public WindowCalculatorContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Window4;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Material>().HasData
             (
                 new Material { MaterialId = 1, Name = "PVC", CostPerSquareMeter = 9, Description = "PVC (Polyvinyl Chloride): PVC windows are very popular due to their high thermal and sound insulation, resistance to corrosion, ease of maintenance, and affordability." },
                 new Material { MaterialId = 2, Name = "Wooden", CostPerSquareMeter = 7, Description = "Wooden windows are aesthetically pleasing and natural. They are environmentally friendly, have good insulating properties, but require regular maintenance and protection from moisture and pests." },
                 new Material { MaterialId = 3, Name = "Aluminum", CostPerSquareMeter = 15, Description = "Aluminum windows are known for their high strength, resistance to corrosion, lightness, and long service life. They are often used in commercial and modern residential buildings." },
                 new Material { MaterialId = 4, Name = "Composite", CostPerSquareMeter = 3, Description = "Composite (Wood-Aluminum): These windows combine the beauty and warmth of wood on the inside with the durability of aluminum on the outside. They have high thermal and sound insulation and are more wear-resistant, requiring less maintenance compared to fully wooden windows." },
                 new Material { MaterialId = 5, Name = "Steel", CostPerSquareMeter = 10, Description = "Steel windows are less common in residential buildings but are used in industrial and commercial structures for their exceptional strength and security." },
                 new Material { MaterialId = 6, Name = "Fiberglass", CostPerSquareMeter = 11, Description = "Fiberglass windows are durable, energy-efficient, and corrosion-resistant. They have a low coefficient of thermal expansion, which ensures high stability." }
             );

            modelBuilder.Entity<User>().HasData
             (
                 new User { UserId = 1, Username = "Severyn", Password = "1234567890", Role = "Admin" },
                 new User { UserId = 2, Username = "Nazar", Password = "1234567890", Role = "Manager" }
             );
        }

        public void MakeOrder(ref string materialName,ref string forma, ref double width, ref double height,ref bool extraOrder)
        {
            int? materialId = GetMaterialIdByName(materialName);
            if (materialId == null)
            {
                return;
            }

            // costPerSquareMeter і total_price визначаються на основі матеріалу і розміру
            double costPerSquareMeter = (double)(Materials.Find(materialId)?.CostPerSquareMeter ?? 0);

            double total_price = costPerSquareMeter * (width* height);
            if(extraOrder)
            {
                total_price += total_price * 0.1; // Додаємо 10% до загальної ціни
            }

            var newOrder = new Product
            {
                MaterialId = materialId.Value,
                Width = width,
                Height = height,
                Forma = forma,
                ExtraOrder = extraOrder,
                Total_price = total_price
            };

            Products.Add(newOrder);
            SaveChanges();
        }


        public int? GetMaterialIdByName(string name)
        {
            var material = Materials.FirstOrDefault(m => m.Name.ToLower() == name.ToLower());

            return material?.MaterialId;
        }

        public bool ValidateLogin(string username, string password)
        {
            var user = Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            return user != null;
        }

        public bool CheckAdmin(string username)
        {
            var user = Users.FirstOrDefault(u => u.Username == username && u.Role == "Admin");

            return user != null;
        }

        public string Found_Material(string output_temp)
        {
            var material = Materials.FirstOrDefault(m => m.Name.ToLower() == output_temp.ToLower());
            if (material != null)
            {
                return material.Name;
            }
            return "Don't founded!";
        }

        public string Found_Material(decimal output_temp)
        {
            var material = Materials.FirstOrDefault(m => m.CostPerSquareMeter == output_temp);
            if (material != null)
            {
                return material.Name;
            }
            return "Don't founded!";
        }

        public void DeleteOrder(ref int Id)
        {
            var product = Products.Find(Id);

            if (product != null)
            {
               Products.Remove(product);
               SaveChanges();
            }
        }
    }
}