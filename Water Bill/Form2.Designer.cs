namespace Water_Bill
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            LbWaterBIll = new Label();
            cbbCusType = new ComboBox();
            LbCustomerName = new Label();
            label2 = new Label();
            LbOWI = new Label();
            LbNWI = new Label();
            label5 = new Label();
            label6 = new Label();
            tbCusName = new TextBox();
            tbOldWater = new TextBox();
            tbNewWater = new TextBox();
            label1 = new Label();
            label3 = new Label();
            tbConsumed = new TextBox();
            btnCalculator = new Button();
            btnPrint = new Button();
            btnExit = new Button();
            tbTotalBill = new TextBox();
            tbBill = new TextBox();
            tbPrice = new TextBox();
            lvBills = new ListView();
            btnAdd = new Button();
            btnEdit = new Button();
            tbPhone = new TextBox();
            label4 = new Label();
            btnDelete = new Button();
            rtbPrintWaterBill = new RichTextBox();
            SuspendLayout();
            // 
            // LbWaterBIll
            // 
            LbWaterBIll.AutoSize = true;
            LbWaterBIll.BackColor = SystemColors.ButtonHighlight;
            LbWaterBIll.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbWaterBIll.ForeColor = SystemColors.MenuHighlight;
            LbWaterBIll.Location = new Point(504, 9);
            LbWaterBIll.Name = "LbWaterBIll";
            LbWaterBIll.Size = new Size(501, 57);
            LbWaterBIll.TabIndex = 0;
            LbWaterBIll.Text = "CALCULATE WATER BILL";
            // 
            // cbbCusType
            // 
            cbbCusType.FormattingEnabled = true;
            cbbCusType.Items.AddRange(new object[] { "House hold customer", "Adminnistrative agencies, public services", "Production unit", "Business services" });
            cbbCusType.Location = new Point(341, 175);
            cbbCusType.Margin = new Padding(2, 1, 2, 1);
            cbbCusType.Name = "cbbCusType";
            cbbCusType.Size = new Size(157, 25);
            cbbCusType.TabIndex = 1;
            // 
            // LbCustomerName
            // 
            LbCustomerName.AutoSize = true;
            LbCustomerName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LbCustomerName.ForeColor = Color.Blue;
            LbCustomerName.Location = new Point(214, 133);
            LbCustomerName.Margin = new Padding(2, 0, 2, 0);
            LbCustomerName.Name = "LbCustomerName";
            LbCustomerName.Size = new Size(123, 20);
            LbCustomerName.TabIndex = 2;
            LbCustomerName.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(214, 175);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 3;
            label2.Text = "Customer Type";
            // 
            // LbOWI
            // 
            LbOWI.AutoSize = true;
            LbOWI.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LbOWI.ForeColor = Color.Blue;
            LbOWI.Location = new Point(199, 261);
            LbOWI.Margin = new Padding(2, 0, 2, 0);
            LbOWI.Name = "LbOWI";
            LbOWI.Size = new Size(161, 20);
            LbOWI.TabIndex = 4;
            LbOWI.Text = "Old Water Index (m3)";
            // 
            // LbNWI
            // 
            LbNWI.AutoSize = true;
            LbNWI.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LbNWI.ForeColor = Color.Blue;
            LbNWI.Location = new Point(393, 261);
            LbNWI.Margin = new Padding(2, 0, 2, 0);
            LbNWI.Name = "LbNWI";
            LbNWI.Size = new Size(169, 20);
            LbNWI.TabIndex = 5;
            LbNWI.Text = "New Water Index (m3)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(934, 133);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 6;
            label5.Text = "Price (VNĐ)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(934, 175);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 7;
            label6.Text = "Bill + ENV (10%)";
            // 
            // tbCusName
            // 
            tbCusName.Location = new Point(341, 132);
            tbCusName.Margin = new Padding(2, 1, 2, 1);
            tbCusName.Name = "tbCusName";
            tbCusName.Size = new Size(157, 25);
            tbCusName.TabIndex = 0;
            // 
            // tbOldWater
            // 
            tbOldWater.Location = new Point(227, 290);
            tbOldWater.Margin = new Padding(2, 1, 2, 1);
            tbOldWater.Name = "tbOldWater";
            tbOldWater.Size = new Size(101, 25);
            tbOldWater.TabIndex = 3;
            // 
            // tbNewWater
            // 
            tbNewWater.Location = new Point(424, 290);
            tbNewWater.Margin = new Padding(2, 1, 2, 1);
            tbNewWater.Name = "tbNewWater";
            tbNewWater.Size = new Size(101, 25);
            tbNewWater.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(934, 213);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 11;
            label1.Text = "Total Bill + VAT (10%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(214, 333);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(206, 20);
            label3.TabIndex = 12;
            label3.Text = "Number of water consumed";
            // 
            // tbConsumed
            // 
            tbConsumed.Location = new Point(424, 332);
            tbConsumed.Margin = new Padding(2, 1, 2, 1);
            tbConsumed.Name = "tbConsumed";
            tbConsumed.Size = new Size(101, 25);
            tbConsumed.TabIndex = 13;
            // 
            // btnCalculator
            // 
            btnCalculator.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCalculator.Location = new Point(241, 440);
            btnCalculator.Margin = new Padding(2, 1, 2, 1);
            btnCalculator.Name = "btnCalculator";
            btnCalculator.Size = new Size(82, 37);
            btnCalculator.TabIndex = 5;
            btnCalculator.Text = "Calculate";
            btnCalculator.UseVisualStyleBackColor = true;
            btnCalculator.Click += btnCalculator_Click;
            btnCalculator.MouseEnter += btnCalculator_MouseEnter;
            btnCalculator.MouseLeave += btnCalculator_MouseLeave;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrint.Location = new Point(989, 440);
            btnPrint.Margin = new Padding(2, 1, 2, 1);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(82, 37);
            btnPrint.TabIndex = 9;
            btnPrint.Text = "Print ";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            btnPrint.MouseEnter += btnPrint_MouseEnter;
            btnPrint.MouseLeave += btnPrint_MouseLeave;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1182, 440);
            btnExit.Margin = new Padding(2, 1, 2, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 37);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btnExit_MouseEnter;
            btnExit.MouseLeave += btnExit_MouseLeave;
            // 
            // tbTotalBill
            // 
            tbTotalBill.Location = new Point(1097, 212);
            tbTotalBill.Margin = new Padding(2, 1, 2, 1);
            tbTotalBill.Name = "tbTotalBill";
            tbTotalBill.Size = new Size(156, 25);
            tbTotalBill.TabIndex = 20;
            // 
            // tbBill
            // 
            tbBill.Location = new Point(1097, 174);
            tbBill.Margin = new Padding(2, 1, 2, 1);
            tbBill.Name = "tbBill";
            tbBill.Size = new Size(156, 25);
            tbBill.TabIndex = 19;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(1097, 133);
            tbPrice.Margin = new Padding(2, 1, 2, 1);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(156, 25);
            tbPrice.TabIndex = 18;
            // 
            // lvBills
            // 
            lvBills.FullRowSelect = true;
            lvBills.Location = new Point(0, 513);
            lvBills.Margin = new Padding(2, 1, 2, 1);
            lvBills.Name = "lvBills";
            lvBills.Size = new Size(1500, 269);
            lvBills.TabIndex = 22;
            lvBills.UseCompatibleStateImageBehavior = false;
            lvBills.View = View.SmallIcon;
            lvBills.SelectedIndexChanged += lvBills_SelectedIndexChanged_1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(432, 440);
            btnAdd.Margin = new Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 37);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            btnAdd.MouseEnter += btnAdd_MouseEnter;
            btnAdd.MouseLeave += btnAdd_MouseLeave;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEdit.Location = new Point(615, 440);
            btnEdit.Margin = new Padding(2, 1, 2, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 37);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            btnEdit.MouseEnter += btnEdit_MouseEnter;
            btnEdit.MouseLeave += btnEdit_MouseLeave;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(341, 215);
            tbPhone.Margin = new Padding(2, 1, 2, 1);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(156, 25);
            tbPhone.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(214, 217);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 25;
            label4.Text = "Customer Phone";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(797, 440);
            btnDelete.Margin = new Padding(2, 1, 2, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 37);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += btnDelete_MouseEnter;
            btnDelete.MouseLeave += btnDelete_MouseLeave;
            // 
            // rtbPrintWaterBill
            // 
            rtbPrintWaterBill.Location = new Point(934, 261);
            rtbPrintWaterBill.Name = "rtbPrintWaterBill";
            rtbPrintWaterBill.Size = new Size(369, 175);
            rtbPrintWaterBill.TabIndex = 26;
            rtbPrintWaterBill.Text = "";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1496, 780);
            Controls.Add(rtbPrintWaterBill);
            Controls.Add(btnDelete);
            Controls.Add(tbPhone);
            Controls.Add(label4);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lvBills);
            Controls.Add(tbTotalBill);
            Controls.Add(tbBill);
            Controls.Add(tbPrice);
            Controls.Add(btnExit);
            Controls.Add(btnPrint);
            Controls.Add(btnCalculator);
            Controls.Add(tbConsumed);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(tbNewWater);
            Controls.Add(tbOldWater);
            Controls.Add(tbCusName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(LbNWI);
            Controls.Add(LbOWI);
            Controls.Add(label2);
            Controls.Add(LbCustomerName);
            Controls.Add(cbbCusType);
            Controls.Add(LbWaterBIll);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 1, 3, 1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculate Water Bill";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbWaterBIll;
        private ComboBox cbbCusType;
        private Label LbCustomerName;
        private Label label2;
        private Label LbOWI;
        private Label LbNWI;
        private Label label5;
        private Label label6;
        private TextBox tbCusName;
        private TextBox tbOldWater;
        private TextBox tbNewWater;
        private Label label1;
        private Label label3;
        private TextBox tbConsumed;
        private Button btnCalculator;
        private Button btnPrint;
        private Button btnExit;
        private TextBox tbPrintWaterBill;
        private TextBox tbTotalBill;
        private TextBox tbBill;
        private TextBox tbPrice;
        private ListView lvBills;
        private Button btnAdd;
        private Button btnEdit;
        private TextBox tbPhone;
        private Label label4;
        private Button btnDelete;
        private RichTextBox rtbPrintWaterBill;
    }
}
