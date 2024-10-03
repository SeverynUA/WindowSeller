
namespace Exam2._0
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button_logIn = new Button();
            button_customer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Loggin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 67);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(240, 23);
            textBox2.TabIndex = 3;
            // 
            // button_logIn
            // 
            button_logIn.Location = new Point(124, 102);
            button_logIn.Name = "button_logIn";
            button_logIn.Size = new Size(75, 23);
            button_logIn.TabIndex = 4;
            button_logIn.Text = "Log in";
            button_logIn.UseVisualStyleBackColor = true;
            button_logIn.Click += button_LogIn_Click;
            // 
            // button_customer
            // 
            button_customer.Location = new Point(418, 48);
            button_customer.Name = "button_customer";
            button_customer.Size = new Size(75, 23);
            button_customer.TabIndex = 5;
            button_customer.Text = "Customer";
            button_customer.UseVisualStyleBackColor = true;
            button_customer.Click += button_Customer_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 159);
            Controls.Add(button_customer);
            Controls.Add(button_logIn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LogIn";
            Text = "Log in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button_logIn;
        private Button button_customer;
    }
}
