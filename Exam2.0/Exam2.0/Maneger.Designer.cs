namespace Exam2._0
{
    partial class Maneger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage_Material = new TabPage();
            dataGridView_Material = new DataGridView();
            tabPage_Product = new TabPage();
            dataGridView_Product = new DataGridView();
            tabPage_User = new TabPage();
            dataGridView_User = new DataGridView();
            button_ShowDb = new Button();
            button_Add = new Button();
            button_Change = new Button();
            tabControl1.SuspendLayout();
            tabPage_Material.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Material).BeginInit();
            tabPage_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Product).BeginInit();
            tabPage_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_User).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_Material);
            tabControl1.Controls.Add(tabPage_Product);
            tabControl1.Controls.Add(tabPage_User);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 237);
            tabControl1.TabIndex = 0;
            // 
            // tabPage_Material
            // 
            tabPage_Material.Controls.Add(dataGridView_Material);
            tabPage_Material.Location = new Point(4, 24);
            tabPage_Material.Name = "tabPage_Material";
            tabPage_Material.Padding = new Padding(3);
            tabPage_Material.Size = new Size(768, 209);
            tabPage_Material.TabIndex = 0;
            tabPage_Material.Text = "Material";
            tabPage_Material.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Material
            // 
            dataGridView_Material.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Material.Dock = DockStyle.Fill;
            dataGridView_Material.Location = new Point(3, 3);
            dataGridView_Material.Name = "dataGridView_Material";
            dataGridView_Material.RowTemplate.Height = 25;
            dataGridView_Material.Size = new Size(762, 203);
            dataGridView_Material.TabIndex = 0;
            // 
            // tabPage_Product
            // 
            tabPage_Product.Controls.Add(dataGridView_Product);
            tabPage_Product.Location = new Point(4, 24);
            tabPage_Product.Name = "tabPage_Product";
            tabPage_Product.Padding = new Padding(3);
            tabPage_Product.Size = new Size(768, 209);
            tabPage_Product.TabIndex = 1;
            tabPage_Product.Text = "Product";
            tabPage_Product.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Product
            // 
            dataGridView_Product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Product.Dock = DockStyle.Fill;
            dataGridView_Product.Location = new Point(3, 3);
            dataGridView_Product.Name = "dataGridView_Product";
            dataGridView_Product.RowTemplate.Height = 25;
            dataGridView_Product.Size = new Size(762, 203);
            dataGridView_Product.TabIndex = 0;
            // 
            // tabPage_User
            // 
            tabPage_User.Controls.Add(dataGridView_User);
            tabPage_User.Location = new Point(4, 24);
            tabPage_User.Name = "tabPage_User";
            tabPage_User.Padding = new Padding(3);
            tabPage_User.Size = new Size(768, 209);
            tabPage_User.TabIndex = 2;
            tabPage_User.Text = "User";
            tabPage_User.UseVisualStyleBackColor = true;
            // 
            // dataGridView_User
            // 
            dataGridView_User.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_User.Dock = DockStyle.Fill;
            dataGridView_User.Location = new Point(3, 3);
            dataGridView_User.Name = "dataGridView_User";
            dataGridView_User.RowTemplate.Height = 25;
            dataGridView_User.Size = new Size(762, 203);
            dataGridView_User.TabIndex = 0;
            // 
            // button_ShowDb
            // 
            button_ShowDb.Location = new Point(16, 251);
            button_ShowDb.Name = "button_ShowDb";
            button_ShowDb.Size = new Size(116, 23);
            button_ShowDb.TabIndex = 1;
            button_ShowDb.Text = "Show Data Base";
            button_ShowDb.UseVisualStyleBackColor = true;
            button_ShowDb.Click += button_ShowDb_Click;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(219, 251);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(103, 23);
            button_Add.TabIndex = 2;
            button_Add.Text = "Add order";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Change
            // 
            button_Change.Location = new Point(328, 251);
            button_Change.Name = "button_Change";
            button_Change.Size = new Size(118, 23);
            button_Change.TabIndex = 3;
            button_Change.Text = "Change order";
            button_Change.UseVisualStyleBackColor = true;
            button_Change.Click += button_Change_Click;
            // 
            // Maneger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 291);
            Controls.Add(button_Change);
            Controls.Add(button_Add);
            Controls.Add(button_ShowDb);
            Controls.Add(tabControl1);
            Name = "Maneger";
            Text = "Maneger";
            Load += Maneger_Load;
            tabControl1.ResumeLayout(false);
            tabPage_Material.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Material).EndInit();
            tabPage_Product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Product).EndInit();
            tabPage_User.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_User).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage_Material;
        private DataGridView dataGridView_Material;
        private TabPage tabPage_Product;
        private TabPage tabPage_User;
        private Button button_ShowDb;
        private DataGridView dataGridView_Product;
        private DataGridView dataGridView_User;
        private Button button_Add;
        private Button button_Change;
    }
}