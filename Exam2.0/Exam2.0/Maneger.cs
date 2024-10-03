using Exam2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exam2._0
{
    public partial class Maneger : Form
    {
        public Maneger()
        {
            InitializeComponent();
        }

        public Maneger(bool isAdmiin)
        {
            InitializeComponent();

            if (!isAdmiin)
            {
                button_Add.Enabled = false;
                button_Change.Enabled = false;

                button_Add.BackColor = Color.DarkGray;
                button_Change.BackColor = Color.DarkGray;
            }
        }

        private void Maneger_Load(object sender, EventArgs e)
        {
            ShowDB();
        }

        private void button_ShowDb_Click(object sender, EventArgs e)
        {
            ShowDB();
        }

        private async void ShowDB()
        {
            using (var context = new WindowCalculatorContext())
            {
                await context.Materials.LoadAsync();
                await context.Products.LoadAsync();
                await context.Users.LoadAsync();

                dataGridView_Material.DataSource = context.Materials.Local.ToBindingList();
                dataGridView_Product.DataSource = context.Products.Local.ToBindingList();
                dataGridView_User.DataSource = context.Users.Local.ToBindingList();
            }
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            List<string> selectedRowData = GetSelectedRowData();

            int output_Id = int.Parse(selectedRowData[0]);
            int output_MaterialId = int.Parse(selectedRowData[1]);
            string output_forma = selectedRowData[3];
            double output_width = double.Parse(selectedRowData[4]);
            double output_heigth = double.Parse(selectedRowData[5]);
            bool output_extraOrder = bool.Parse(selectedRowData[6]);
            double output_total = double.Parse(selectedRowData[7]);

            using (Customer manager = new Customer(output_Id,output_MaterialId, output_forma, output_width, output_heigth, output_total, output_extraOrder))
            {
                var dialogResult = manager.ShowDialog();
            }
        }

        private List<string> GetSelectedRowData()
        {
            List<string> info = new List<string>();

            // Отримуємо поточний вибраний рядок
            var selectedRow = dataGridView_Product.CurrentRow;

            if (selectedRow != null)
            {
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    // Додаємо значення клітинки до списку, якщо воно не є null
                    info.Add(cell.Value?.ToString() ?? "Not specified");
                }
            }

            return info;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            using (Customer customer = new Customer())
            {
                var dialogResult = customer.ShowDialog();
            }
        }
    }
}
