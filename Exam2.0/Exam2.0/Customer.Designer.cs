namespace Exam2._0
{
    partial class Customer
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
            ListViewItem listViewItem11 = new ListViewItem("Double-Hung Windows");
            ListViewItem listViewItem12 = new ListViewItem("Casement Windows");
            ListViewItem listViewItem13 = new ListViewItem("Awning Windows");
            ListViewItem listViewItem14 = new ListViewItem("Sliding Windows");
            ListViewItem listViewItem15 = new ListViewItem("Bay Windows");
            ListViewItem listViewItem16 = new ListViewItem("Bow Windows");
            ListViewItem listViewItem17 = new ListViewItem("Fixed Windows");
            ListViewItem listViewItem18 = new ListViewItem("Tilt and Turn Windows");
            ListViewItem listViewItem19 = new ListViewItem("Skylight Windows");
            ListViewItem listViewItem20 = new ListViewItem("Garden Windows");
            dataGridView1 = new DataGridView();
            listView1 = new ListView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox_infoForm = new TextBox();
            button_MakeOrder = new Button();
            textBox_ShowPrice = new TextBox();
            label3 = new Label();
            button1 = new Button();
            radioButton_ExtraOrder = new RadioButton();
            radioButton_StandartOrder = new RadioButton();
            button_Search = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 241);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView_CellCklick;
            // 
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem11, listViewItem12, listViewItem13, listViewItem14, listViewItem15, listViewItem16, listViewItem17, listViewItem18, listViewItem19, listViewItem20 });
            listView1.Location = new Point(12, 269);
            listView1.Name = "listView1";
            listView1.Size = new Size(166, 97);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.SmallIcon;
            listView1.ItemActivate += ItemActivate_listView;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(484, 272);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(484, 302);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Length";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(542, 269);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(55, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(542, 299);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(55, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox_infoForm
            // 
            textBox_infoForm.Location = new Point(184, 269);
            textBox_infoForm.Multiline = true;
            textBox_infoForm.Name = "textBox_infoForm";
            textBox_infoForm.ReadOnly = true;
            textBox_infoForm.Size = new Size(279, 97);
            textBox_infoForm.TabIndex = 6;
            // 
            // button_MakeOrder
            // 
            button_MakeOrder.Location = new Point(362, 387);
            button_MakeOrder.Name = "button_MakeOrder";
            button_MakeOrder.Size = new Size(101, 23);
            button_MakeOrder.TabIndex = 7;
            button_MakeOrder.Text = "Make order";
            button_MakeOrder.UseVisualStyleBackColor = true;
            button_MakeOrder.Click += button_MakeOrder_Click;
            // 
            // textBox_ShowPrice
            // 
            textBox_ShowPrice.Location = new Point(682, 303);
            textBox_ShowPrice.Name = "textBox_ShowPrice";
            textBox_ShowPrice.Size = new Size(78, 23);
            textBox_ShowPrice.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(638, 306);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 9;
            label3.Text = "Price";
            // 
            // button1
            // 
            button1.Location = new Point(28, 387);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 10;
            button1.Text = "Check material";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton_ExtraOrder
            // 
            radioButton_ExtraOrder.AutoSize = true;
            radioButton_ExtraOrder.Location = new Point(495, 347);
            radioButton_ExtraOrder.Name = "radioButton_ExtraOrder";
            radioButton_ExtraOrder.Size = new Size(82, 19);
            radioButton_ExtraOrder.TabIndex = 11;
            radioButton_ExtraOrder.TabStop = true;
            radioButton_ExtraOrder.Text = "Extra order";
            radioButton_ExtraOrder.UseVisualStyleBackColor = true;
            radioButton_ExtraOrder.CheckedChanged += radioButton_ExtraOrder_CheckedChanged;
            // 
            // radioButton_StandartOrder
            // 
            radioButton_StandartOrder.AutoSize = true;
            radioButton_StandartOrder.Location = new Point(495, 328);
            radioButton_StandartOrder.Name = "radioButton_StandartOrder";
            radioButton_StandartOrder.Size = new Size(100, 19);
            radioButton_StandartOrder.TabIndex = 12;
            radioButton_StandartOrder.TabStop = true;
            radioButton_StandartOrder.Text = "Standart order";
            radioButton_StandartOrder.UseVisualStyleBackColor = true;
            radioButton_StandartOrder.CheckedChanged += radioButton_StandartOrder_CheckedChanged;
            // 
            // button_Search
            // 
            button_Search.Location = new Point(154, 387);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(116, 23);
            button_Search.TabIndex = 13;
            button_Search.Text = "Search material";
            button_Search.UseVisualStyleBackColor = true;
            button_Search.Click += button_Search_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 422);
            Controls.Add(button_Search);
            Controls.Add(radioButton_StandartOrder);
            Controls.Add(radioButton_ExtraOrder);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox_ShowPrice);
            Controls.Add(button_MakeOrder);
            Controls.Add(textBox_infoForm);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(dataGridView1);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ListView listView1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox_infoForm;
        private Button button_MakeOrder;
        private TextBox textBox_ShowPrice;
        private Label label3;
        private Button button1;
        private RadioButton radioButton_ExtraOrder;
        private RadioButton radioButton_StandartOrder;
        private Button button_Search;
    }
}