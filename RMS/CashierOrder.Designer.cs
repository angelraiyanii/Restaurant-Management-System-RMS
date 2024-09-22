
namespace RMS
{
    partial class CashierOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cashierOrder_menuTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cashierOrder_ProductType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cashierOrder_productID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cashierOrder_productName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cashierOrder_productPrice = new System.Windows.Forms.Label();
            this.cashierOrder_AddBtn = new System.Windows.Forms.Button();
            this.cashierOrder_RemoveBtn = new System.Windows.Forms.Button();
            this.cashierOrder_ClearBtn = new System.Windows.Forms.Button();
            this.cashierOrder_OrderTable = new System.Windows.Forms.DataGridView();
            this.cashierOrder_OrderPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cashierOrder_OrderAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cashierOrder_orderChange = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cashierOrder_PayBtn = new System.Windows.Forms.Button();
            this.cashierOrder_ReceiptBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrder_menuTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrder_OrderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cashierOrder_menuTable);
            this.panel1.Location = new System.Drawing.Point(15, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 233);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cashierOrder_ClearBtn);
            this.panel2.Controls.Add(this.cashierOrder_RemoveBtn);
            this.panel2.Controls.Add(this.cashierOrder_AddBtn);
            this.panel2.Controls.Add(this.cashierOrder_productPrice);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cashierOrder_productName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cashierOrder_productID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cashierOrder_ProductType);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(15, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 233);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cashierOrder_ReceiptBtn);
            this.panel3.Controls.Add(this.cashierOrder_PayBtn);
            this.panel3.Controls.Add(this.cashierOrder_orderChange);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.cashierOrder_OrderAmount);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cashierOrder_OrderPrice);
            this.panel3.Controls.Add(this.cashierOrder_OrderTable);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(655, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 472);
            this.panel3.TabIndex = 1;
            // 
            // cashierOrder_menuTable
            // 
            this.cashierOrder_menuTable.AllowUserToAddRows = false;
            this.cashierOrder_menuTable.AllowUserToDeleteRows = false;
            this.cashierOrder_menuTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cashierOrder_menuTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cashierOrder_menuTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cashierOrder_menuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashierOrder_menuTable.EnableHeadersVisualStyles = false;
            this.cashierOrder_menuTable.Location = new System.Drawing.Point(0, 36);
            this.cashierOrder_menuTable.Name = "cashierOrder_menuTable";
            this.cashierOrder_menuTable.ReadOnly = true;
            this.cashierOrder_menuTable.RowHeadersVisible = false;
            this.cashierOrder_menuTable.Size = new System.Drawing.Size(631, 194);
            this.cashierOrder_menuTable.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            // 
            // cashierOrder_ProductType
            // 
            this.cashierOrder_ProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_ProductType.FormattingEnabled = true;
            this.cashierOrder_ProductType.Items.AddRange(new object[] {
            "Active ",
            "Inactive",
            "Approval"});
            this.cashierOrder_ProductType.Location = new System.Drawing.Point(131, 34);
            this.cashierOrder_ProductType.Name = "cashierOrder_ProductType";
            this.cashierOrder_ProductType.Size = new System.Drawing.Size(124, 24);
            this.cashierOrder_ProductType.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Type";
            // 
            // cashierOrder_productID
            // 
            this.cashierOrder_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_productID.FormattingEnabled = true;
            this.cashierOrder_productID.Items.AddRange(new object[] {
            "Active ",
            "Inactive",
            "Approval"});
            this.cashierOrder_productID.Location = new System.Drawing.Point(394, 33);
            this.cashierOrder_productID.Name = "cashierOrder_productID";
            this.cashierOrder_productID.Size = new System.Drawing.Size(124, 24);
            this.cashierOrder_productID.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Product ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Product Name";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(394, 77);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(124, 23);
            this.numericUpDown1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Quantity";
            // 
            // cashierOrder_productName
            // 
            this.cashierOrder_productName.AutoSize = true;
            this.cashierOrder_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_productName.Location = new System.Drawing.Point(128, 109);
            this.cashierOrder_productName.Name = "cashierOrder_productName";
            this.cashierOrder_productName.Size = new System.Drawing.Size(41, 17);
            this.cashierOrder_productName.TabIndex = 19;
            this.cashierOrder_productName.Text = "Drink";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Price ($)";
            // 
            // cashierOrder_productPrice
            // 
            this.cashierOrder_productPrice.AutoSize = true;
            this.cashierOrder_productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_productPrice.Location = new System.Drawing.Point(128, 77);
            this.cashierOrder_productPrice.Name = "cashierOrder_productPrice";
            this.cashierOrder_productPrice.Size = new System.Drawing.Size(32, 17);
            this.cashierOrder_productPrice.TabIndex = 21;
            this.cashierOrder_productPrice.Text = "100";
            // 
            // cashierOrder_AddBtn
            // 
            this.cashierOrder_AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cashierOrder_AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_AddBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_AddBtn.Location = new System.Drawing.Point(42, 183);
            this.cashierOrder_AddBtn.Name = "cashierOrder_AddBtn";
            this.cashierOrder_AddBtn.Size = new System.Drawing.Size(166, 37);
            this.cashierOrder_AddBtn.TabIndex = 27;
            this.cashierOrder_AddBtn.Text = "Add";
            this.cashierOrder_AddBtn.UseVisualStyleBackColor = false;
            // 
            // cashierOrder_RemoveBtn
            // 
            this.cashierOrder_RemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cashierOrder_RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_RemoveBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_RemoveBtn.Location = new System.Drawing.Point(214, 183);
            this.cashierOrder_RemoveBtn.Name = "cashierOrder_RemoveBtn";
            this.cashierOrder_RemoveBtn.Size = new System.Drawing.Size(166, 37);
            this.cashierOrder_RemoveBtn.TabIndex = 28;
            this.cashierOrder_RemoveBtn.Text = "Remove";
            this.cashierOrder_RemoveBtn.UseVisualStyleBackColor = false;
            // 
            // cashierOrder_ClearBtn
            // 
            this.cashierOrder_ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cashierOrder_ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_ClearBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_ClearBtn.Location = new System.Drawing.Point(386, 183);
            this.cashierOrder_ClearBtn.Name = "cashierOrder_ClearBtn";
            this.cashierOrder_ClearBtn.Size = new System.Drawing.Size(166, 37);
            this.cashierOrder_ClearBtn.TabIndex = 29;
            this.cashierOrder_ClearBtn.Text = "Clear";
            this.cashierOrder_ClearBtn.UseVisualStyleBackColor = false;
            // 
            // cashierOrder_OrderTable
            // 
            this.cashierOrder_OrderTable.AllowUserToAddRows = false;
            this.cashierOrder_OrderTable.AllowUserToDeleteRows = false;
            this.cashierOrder_OrderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cashierOrder_OrderTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cashierOrder_OrderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cashierOrder_OrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashierOrder_OrderTable.EnableHeadersVisualStyles = false;
            this.cashierOrder_OrderTable.Location = new System.Drawing.Point(11, 36);
            this.cashierOrder_OrderTable.Name = "cashierOrder_OrderTable";
            this.cashierOrder_OrderTable.ReadOnly = true;
            this.cashierOrder_OrderTable.RowHeadersVisible = false;
            this.cashierOrder_OrderTable.Size = new System.Drawing.Size(265, 209);
            this.cashierOrder_OrderTable.TabIndex = 4;
            // 
            // cashierOrder_OrderPrice
            // 
            this.cashierOrder_OrderPrice.AutoSize = true;
            this.cashierOrder_OrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_OrderPrice.Location = new System.Drawing.Point(135, 275);
            this.cashierOrder_OrderPrice.Name = "cashierOrder_OrderPrice";
            this.cashierOrder_OrderPrice.Size = new System.Drawing.Size(32, 17);
            this.cashierOrder_OrderPrice.TabIndex = 31;
            this.cashierOrder_OrderPrice.Text = "100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(57, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Price ($)";
            // 
            // cashierOrder_OrderAmount
            // 
            this.cashierOrder_OrderAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_OrderAmount.Location = new System.Drawing.Point(135, 301);
            this.cashierOrder_OrderAmount.Name = "cashierOrder_OrderAmount";
            this.cashierOrder_OrderAmount.Size = new System.Drawing.Size(116, 23);
            this.cashierOrder_OrderAmount.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Amount ($)";
            // 
            // cashierOrder_orderChange
            // 
            this.cashierOrder_orderChange.AutoSize = true;
            this.cashierOrder_orderChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_orderChange.Location = new System.Drawing.Point(135, 339);
            this.cashierOrder_orderChange.Name = "cashierOrder_orderChange";
            this.cashierOrder_orderChange.Size = new System.Drawing.Size(16, 17);
            this.cashierOrder_orderChange.TabIndex = 35;
            this.cashierOrder_orderChange.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(40, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Change ($)";
            // 
            // cashierOrder_PayBtn
            // 
            this.cashierOrder_PayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cashierOrder_PayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_PayBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_PayBtn.Location = new System.Drawing.Point(40, 371);
            this.cashierOrder_PayBtn.Name = "cashierOrder_PayBtn";
            this.cashierOrder_PayBtn.Size = new System.Drawing.Size(211, 37);
            this.cashierOrder_PayBtn.TabIndex = 36;
            this.cashierOrder_PayBtn.Text = "PAY";
            this.cashierOrder_PayBtn.UseVisualStyleBackColor = false;
            // 
            // cashierOrder_ReceiptBtn
            // 
            this.cashierOrder_ReceiptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cashierOrder_ReceiptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_ReceiptBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_ReceiptBtn.Location = new System.Drawing.Point(40, 422);
            this.cashierOrder_ReceiptBtn.Name = "cashierOrder_ReceiptBtn";
            this.cashierOrder_ReceiptBtn.Size = new System.Drawing.Size(211, 37);
            this.cashierOrder_ReceiptBtn.TabIndex = 37;
            this.cashierOrder_ReceiptBtn.Text = "RECEIPT";
            this.cashierOrder_ReceiptBtn.UseVisualStyleBackColor = false;
            // 
            // CashierOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CashierOrder";
            this.Size = new System.Drawing.Size(978, 496);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrder_menuTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrder_OrderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView cashierOrder_menuTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cashierOrder_ProductType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cashierOrder_productID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cashierOrder_productPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cashierOrder_productName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cashierOrder_ClearBtn;
        private System.Windows.Forms.Button cashierOrder_RemoveBtn;
        private System.Windows.Forms.Button cashierOrder_AddBtn;
        private System.Windows.Forms.Label cashierOrder_OrderPrice;
        private System.Windows.Forms.DataGridView cashierOrder_OrderTable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cashierOrder_ReceiptBtn;
        private System.Windows.Forms.Button cashierOrder_PayBtn;
        private System.Windows.Forms.Label cashierOrder_orderChange;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cashierOrder_OrderAmount;
        private System.Windows.Forms.Label label11;
    }
}
