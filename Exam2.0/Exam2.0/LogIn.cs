using Exam2.Models;
using Microsoft.VisualBasic.Logging;

namespace Exam2._0
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        private void button_Customer_Click(object sender, EventArgs e)
        {

            using (Customer customer = new Customer())
            {
                var dialogResult = customer.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            using (var context = new WindowCalculatorContext())
            {
                if (context.ValidateLogin(textBox1.Text, textBox2.Text))
                {
                    bool isAdmin = false;
                    
                    if(context.CheckAdmin(textBox1.Text))
                    {
                        isAdmin = true;
                    }
                    else
                    {
                        isAdmin = false;
                    }
                    using (Maneger manager = new Maneger(isAdmin))
                    {
                        var dialogResult = manager.ShowDialog();

                        if (dialogResult == DialogResult.OK)
                        {
                            this.Close();
                        }
                        else
                        {
                            textBox2.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect password or login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBox2.Text = "";
            }
        }
    }
}
