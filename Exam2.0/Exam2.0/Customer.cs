using Exam2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing;
using System.Windows.Forms;

namespace Exam2._0
{
    public partial class Customer : Form
    {
        double final_total = 0, width = 0, height = 0, CostPerSquareMeter = 0;
        DataGridViewRow selectedRow = null;
        ListViewItem selectedItem = null;
        bool extraOrder = false;

        bool change_order = false;
        int tempId_delete = 0;

        public Customer()
        {
            InitializeComponent();
            ShowDB();

            // Підписка на події TextBox
            this.textBox1.TextChanged += (s, e) => DoSomething();
            this.textBox2.TextChanged += (s, e) => DoSomething();

            this.textBox1.KeyPress += textBox_KeyPress;
            this.textBox2.KeyPress += textBox_KeyPress;

            radioButton_StandartOrder.Checked = true;

        }
        public Customer(int Id, int materialId,string name_forma,double width,double heigth,double total_price,bool extraOrder)
        {
            InitializeComponent();
            ShowDB();

            change_order = true;
            tempId_delete = Id;

            // Підписка на події TextBox
            this.textBox1.TextChanged += (s, e) => DoSomething();
            this.textBox2.TextChanged += (s, e) => DoSomething();

            this.textBox1.KeyPress += textBox_KeyPress;
            this.textBox2.KeyPress += textBox_KeyPress;

            radioButton_StandartOrder.Checked = true;

            FoundInDataGridViewAsync(materialId);
            FoundListView(name_forma);
            textBox1.Text = width.ToString();
            textBox2.Text = heigth.ToString();
            textBox_ShowPrice.Text = $"{total_price.ToString()}$";

            if (extraOrder) 
            {
                radioButton_StandartOrder.Checked = false;
                radioButton_ExtraOrder.Checked = true;
            }
            else
            {
                radioButton_ExtraOrder.Checked = false;
                radioButton_StandartOrder.Checked = true;
            }
        }

        private async void FoundInDataGridViewAsync(int searchValue)
        {
            await ShowDB();

            using (var context = new WindowCalculatorContext())
            {
                var material = context.Materials.FirstOrDefault(m => m.MaterialId == searchValue); // Пошук матеріалу за ID.
                if (material != null)
                {
                    bool valueFound = false;

                    dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (String.Equals(row.Cells["Name"].Value?.ToString(), material.Name, StringComparison.OrdinalIgnoreCase))
                        {
                            // Встановлення поточної клітинки на клітинку з відповідним ім'ям
                            dataGridView1.CurrentCell = row.Cells["Name"];

                            dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;

                            valueFound = true;
                            break;
                        }
                    }

                    if (!valueFound)
                    {
                        MessageBox.Show("Material name not found.", "Search Result");
                    }
                }
                else
                {
                    MessageBox.Show("Material not found in Db!");
                }
            }
        }


        private void FoundListView(string searchValue)
        {
            bool valueFound = false;
             
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text.Equals(searchValue, StringComparison.OrdinalIgnoreCase) || item.SubItems.Cast<ListViewItem.ListViewSubItem>().Any(subItem => subItem.Text.Equals(searchValue, StringComparison.OrdinalIgnoreCase)))
                {
                    item.Selected = true;
                    listView1.Focus();
                    valueFound = true;
                    break;
                }
            }

            if (!valueFound)
            {
                MessageBox.Show("Value not found");
            }
        }

        private void DoSomething()
        {
            bool widthResult = double.TryParse(textBox1.Text, out width);
            bool heightResult = double.TryParse(textBox2.Text, out height);

            if (widthResult && heightResult)
            {
                // Якщо обидва значення успішно спарсились, робимо розрахунок

                if (radioButton_ExtraOrder.Checked)
                {
                    final_total = width * height * CostPerSquareMeter * 1.10; //Add to 10% to price
                }
                else
                {
                    final_total = width * height * CostPerSquareMeter;
                }
                // Заокруглення до 2 знаків після коми
                final_total = Math.Round(final_total, 2);

                textBox_ShowPrice.Text = $"{final_total.ToString("F2")}$";
            }
        }

        private void radioButton_StandartOrder_CheckedChanged(object sender, EventArgs e)
        {
            extraOrder = false;
            DoSomething();
        }

        private void radioButton_ExtraOrder_CheckedChanged(object sender, EventArgs e)
        {
            extraOrder = true;   
            DoSomething();
        }

        private async Task ShowDB()
        {
            using (var context = new WindowCalculatorContext())
            {
                await context.Materials.LoadAsync();
                dataGridView1.DataSource = context.Materials.Local.ToBindingList();

                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns[0].Visible = false;
                }

                if (dataGridView1.Columns.Count > 1)
                {
                    int lastColumnIndex = dataGridView1.Columns.Count - 1;

                    dataGridView1.Columns[lastColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    for (int i = 1; i < lastColumnIndex; i++)
                    {
                        dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                    dataGridView1.AutoResizeColumns();
                }
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            ShowDB();
        }

        private void ItemActivate_listView(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                selectedItem = listView1.SelectedItems[0];

                switch (selectedItem.Text)
                {
                    case "Double-Hung Windows":
                        textBox_infoForm.Text = "Windows with two sashes that move vertically up and down. The top or bottom can be open for ventilation.";
                        break;
                    case "Casement Windows":
                        textBox_infoForm.Text = "Windows that open outwards or inwards with the help of a handle. They are hinged on one side and are often used to provide good ventilation.";
                        break;
                    case "Awning Windows":
                        textBox_infoForm.Text = "Casement-like windows, but with hinges mounted at the top, allowing them to open outwards from below. They are great for use in rainy weather as they prevent water from getting inside.";
                        break;
                    case "Sliding Windows":
                        textBox_infoForm.Text = "Windows that open by moving the sash horizontally to the left or right. They effectively save space and are often used in modern homes.";
                        break;
                    case "Bay Windows":
                        textBox_infoForm.Text = "Window structures protruding from the wall of the building, forming a multifaceted or semicircular projecting part. They create additional space inside and provide a wide view.";
                        break;
                    case "Bow Windows":
                        textBox_infoForm.Text = "Similar to bay windows, but with a smoother and more rounded shape, creating a curved protruding part. They add elegance to the exterior of the house.";
                        break;
                    case "Fixed Windows":
                        textBox_infoForm.Text = "Windows that do not open. They are intended exclusively for the entry of light and inspection of the external environment.";
                        break;
                    case "Tilt and Turn Windows":
                        textBox_infoForm.Text = "Windows that can be opened in two ways: lean into the room for ventilation or open completely as casemate windows.";
                        break;
                    case "Skylight Windows":
                        textBox_infoForm.Text = "Windows mounted on a roof or high on a wall, providing additional light and sometimes ventilation.";
                        break;
                    case "Garden Windows":
                        textBox_infoForm.Text = "Small protruding windows, similar to miniature greenhouses, are ideal for growing plants inside the house.";
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDB();
        }

        private void dataGridView_CellCklick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dataGridView1.Rows[e.RowIndex];

                // Спроба парсингу значення з третьої клітинки (з індексом 2) в double
                bool parseResult = double.TryParse(selectedRow.Cells[2].Value?.ToString(), out double costPerSquareMeter);

                if (parseResult)
                {
                    CostPerSquareMeter = costPerSquareMeter;
                    DoSomething();
                }
                else
                {
                    MessageBox.Show("Can't convert numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Дозволити лише числові символи, крапку та клавішу Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Відхилити символ, якщо він не відповідає критеріям
            }

            // Дозволити тільки одну крапку в TextBox
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button_MakeOrder_Click(object sender, EventArgs e)
        {
            // Переконуємось, що всі необхідні поля заповнені
            if (selectedRow != null && selectedItem != null && !string.IsNullOrEmpty(selectedItem.Text) && !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                // Тепер безпечно використовуємо selectedRow і selectedItem
                var material = selectedRow?.Cells[1].Value?.ToString() ?? "Not specified";
                var form = selectedItem.Text;

                DialogResult result = MessageBox.Show($"Are you sure you want to place the order?\n\nMaterial: {material}\nForm: {form}\nTotal: {final_total}$", "Order Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Order created successfully.", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (change_order)
                    {
                        using var context = new WindowCalculatorContext();
                        context.DeleteOrder(ref tempId_delete);
                    }

                    using (var context = new WindowCalculatorContext())
                    {
                        context.MakeOrder(ref material, ref form, ref width,ref height,ref extraOrder);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Order cancelled.", "Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Вказуємо користувачеві, які саме поля необхідно заповнити
                string message = "";
                if (selectedRow == null)
                {
                    message += "Please select a material!\n";
                }
                if (selectedItem == null || string.IsNullOrEmpty(selectedItem.Text))
                {
                    message += "Please select a form!\n";
                }
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    message += "Please enter a width!\n";
                }
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    message += "Please enter a length!\n";
                }
                MessageBox.Show(message, "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string output_temp = Interaction.InputBox("Enter the parameter by which you will start the search.", "Input", "");

            if (string.IsNullOrEmpty(output_temp))
            {
                return;
            }

            using (var context = new WindowCalculatorContext())
            {
                if (decimal.TryParse(output_temp, out decimal costPerSquareMeter))
                {
                    MessageBox.Show(context.Found_Material(costPerSquareMeter));
                    return;
                }
                else
                {
                    MessageBox.Show(context.Found_Material(output_temp));
                    return;
                }
            }
        }
    }
}
