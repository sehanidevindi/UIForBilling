
namespace UIForBilling
{
    partial class total
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.quantity = new System.Windows.Forms.TextBox();
            this.enterItemCode = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.customerMobile = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.Label();
            this.newInvoice = new System.Windows.Forms.Button();
            this.salesReturn = new System.Windows.Forms.Button();
            this.saveToDraft = new System.Windows.Forms.Button();
            this.itemName = new System.Windows.Forms.Label();
            this.unitPrice = new System.Windows.Forms.Label();
            this.itemCategory = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.TextBox();
            this.subTotal = new System.Windows.Forms.Label();
            this.total1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printSave = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.totalDiscount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.caption = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 16);
            this.tableLayoutPanel1.Controls.Add(this.label2, 5, 16);
            this.tableLayoutPanel1.Controls.Add(this.totalDiscount, 4, 14);
            this.tableLayoutPanel1.Controls.Add(this.label1, 5, 14);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.itemName, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.itemCategory, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.subTotal, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.unitPrice, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.total1, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label11, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.customerMobile, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.customerName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.address, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.save, 6, 10);
            this.tableLayoutPanel1.Controls.Add(this.print, 6, 9);
            this.tableLayoutPanel1.Controls.Add(this.printSave, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.clear, 6, 11);
            this.tableLayoutPanel1.Controls.Add(this.enterItemCode, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.quantity, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.discount, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.caption, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveToDraft, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.salesReturn, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.newInvoice, 6, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 17;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.quantity.Location = new System.Drawing.Point(124, 85);
            this.quantity.Margin = new System.Windows.Forms.Padding(4);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(112, 20);
            this.quantity.TabIndex = 7;
            this.quantity.Text = "Quantity";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // enterItemCode
            // 
            this.enterItemCode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterItemCode.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.enterItemCode.Location = new System.Drawing.Point(4, 85);
            this.enterItemCode.Margin = new System.Windows.Forms.Padding(4);
            this.enterItemCode.Name = "enterItemCode";
            this.enterItemCode.Size = new System.Drawing.Size(112, 20);
            this.enterItemCode.TabIndex = 6;
            this.enterItemCode.Text = "Enter Item Code";
            this.enterItemCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // address
            // 
            this.address.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.SetColumnSpan(this.address, 2);
            this.address.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(486, 33);
            this.address.Margin = new System.Windows.Forms.Padding(6);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(188, 15);
            this.address.TabIndex = 2;
            this.address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.address.Click += new System.EventHandler(this.label1_Click);
            // 
            // customerMobile
            // 
            this.customerMobile.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerMobile.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.customerMobile.Location = new System.Drawing.Point(4, 31);
            this.customerMobile.Margin = new System.Windows.Forms.Padding(4);
            this.customerMobile.Name = "customerMobile";
            this.customerMobile.Size = new System.Drawing.Size(112, 20);
            this.customerMobile.TabIndex = 0;
            this.customerMobile.Text = "Enter Customer Mobile";
            this.customerMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customerName
            // 
            this.customerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerName.AutoSize = true;
            this.customerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.customerName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.Location = new System.Drawing.Point(246, 33);
            this.customerName.Margin = new System.Windows.Forms.Padding(6);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(108, 15);
            this.customerName.TabIndex = 1;
            this.customerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newInvoice
            // 
            this.newInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.newInvoice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newInvoice.Location = new System.Drawing.Point(698, 56);
            this.newInvoice.Margin = new System.Windows.Forms.Padding(18, 2, 18, 2);
            this.newInvoice.Name = "newInvoice";
            this.newInvoice.Size = new System.Drawing.Size(84, 23);
            this.newInvoice.TabIndex = 3;
            this.newInvoice.Text = "New Invoice";
            this.newInvoice.UseVisualStyleBackColor = false;
            this.newInvoice.Click += new System.EventHandler(this.button1_Click);
            // 
            // salesReturn
            // 
            this.salesReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salesReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.salesReturn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salesReturn.Location = new System.Drawing.Point(698, 83);
            this.salesReturn.Margin = new System.Windows.Forms.Padding(18, 2, 18, 2);
            this.salesReturn.Name = "salesReturn";
            this.salesReturn.Size = new System.Drawing.Size(84, 23);
            this.salesReturn.TabIndex = 4;
            this.salesReturn.Text = "Sales Return";
            this.salesReturn.UseVisualStyleBackColor = false;
            // 
            // saveToDraft
            // 
            this.saveToDraft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveToDraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.saveToDraft.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToDraft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveToDraft.Location = new System.Drawing.Point(698, 110);
            this.saveToDraft.Margin = new System.Windows.Forms.Padding(18, 2, 18, 2);
            this.saveToDraft.Name = "saveToDraft";
            this.saveToDraft.Size = new System.Drawing.Size(84, 23);
            this.saveToDraft.TabIndex = 5;
            this.saveToDraft.Text = "Save to Draft";
            this.saveToDraft.UseVisualStyleBackColor = false;
            this.saveToDraft.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // itemName
            // 
            this.itemName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemName.AutoSize = true;
            this.itemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.itemName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(6, 168);
            this.itemName.Margin = new System.Windows.Forms.Padding(6);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(108, 15);
            this.itemName.TabIndex = 8;
            this.itemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unitPrice
            // 
            this.unitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitPrice.AutoSize = true;
            this.unitPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.unitPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrice.Location = new System.Drawing.Point(366, 168);
            this.unitPrice.Margin = new System.Windows.Forms.Padding(6);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(108, 15);
            this.unitPrice.TabIndex = 9;
            this.unitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemCategory
            // 
            this.itemCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemCategory.AutoSize = true;
            this.itemCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.itemCategory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCategory.Location = new System.Drawing.Point(126, 168);
            this.itemCategory.Margin = new System.Windows.Forms.Padding(6);
            this.itemCategory.Name = "itemCategory";
            this.itemCategory.Size = new System.Drawing.Size(108, 15);
            this.itemCategory.TabIndex = 10;
            this.itemCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // discount
            // 
            this.discount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.discount.Location = new System.Drawing.Point(244, 85);
            this.discount.Margin = new System.Windows.Forms.Padding(4);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(112, 20);
            this.discount.TabIndex = 11;
            this.discount.Text = "Discount";
            this.discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // subTotal
            // 
            this.subTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subTotal.AutoSize = true;
            this.subTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.subTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal.Location = new System.Drawing.Point(246, 168);
            this.subTotal.Margin = new System.Windows.Forms.Padding(6);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(108, 15);
            this.subTotal.TabIndex = 12;
            this.subTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total1
            // 
            this.total1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.total1.AutoSize = true;
            this.total1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.total1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total1.Location = new System.Drawing.Point(486, 168);
            this.total1.Margin = new System.Windows.Forms.Padding(6);
            this.total1.Name = "total1";
            this.total1.Size = new System.Drawing.Size(108, 15);
            this.total1.TabIndex = 13;
            this.total1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LineID,
            this.ItemCode,
            this.Item,
            this.price,
            this.QTY,
            this.Disc,
            this.Sub_Total});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 6);
            this.dataGridView1.Location = new System.Drawing.Point(3, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 6);
            this.dataGridView1.Size = new System.Drawing.Size(634, 144);
            this.dataGridView1.TabIndex = 14;
            // 
            // LineID
            // 
            this.LineID.HeaderText = "LINE ID";
            this.LineID.Name = "LineID";
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "ITEM CODE";
            this.ItemCode.Name = "ItemCode";
            // 
            // Item
            // 
            this.Item.HeaderText = "ITEM NAME";
            this.Item.Name = "Item";
            // 
            // price
            // 
            this.price.HeaderText = "UNIT PRICE";
            this.price.Name = "price";
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            // 
            // Disc
            // 
            this.Disc.HeaderText = "DISCOUNT";
            this.Disc.Name = "Disc";
            // 
            // Sub_Total
            // 
            this.Sub_Total.HeaderText = "SUB TOTAL";
            this.Sub_Total.Name = "Sub_Total";
            // 
            // printSave
            // 
            this.printSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.printSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printSave.ForeColor = System.Drawing.Color.White;
            this.printSave.Location = new System.Drawing.Point(698, 218);
            this.printSave.Margin = new System.Windows.Forms.Padding(18, 2, 18, 2);
            this.printSave.Name = "printSave";
            this.printSave.Size = new System.Drawing.Size(84, 23);
            this.printSave.TabIndex = 15;
            this.printSave.Text = "Print & Save";
            this.printSave.UseVisualStyleBackColor = false;
            // 
            // print
            // 
            this.print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.print.BackColor = System.Drawing.Color.DodgerBlue;
            this.print.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.ForeColor = System.Drawing.Color.White;
            this.print.Location = new System.Drawing.Point(698, 245);
            this.print.Margin = new System.Windows.Forms.Padding(18, 2, 18, 2);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(84, 23);
            this.print.TabIndex = 16;
            this.print.Text = "Print Only";
            this.print.UseVisualStyleBackColor = false;
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save.BackColor = System.Drawing.Color.DodgerBlue;
            this.save.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(698, 272);
            this.save.Margin = new System.Windows.Forms.Padding(18, 2, 18, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(84, 23);
            this.save.TabIndex = 18;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.BackColor = System.Drawing.Color.DodgerBlue;
            this.clear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(698, 299);
            this.clear.Margin = new System.Windows.Forms.Padding(18, 2, 18, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(84, 23);
            this.clear.TabIndex = 17;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            // 
            // totalDiscount
            // 
            this.totalDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalDiscount.AutoSize = true;
            this.totalDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.totalDiscount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDiscount.ForeColor = System.Drawing.Color.White;
            this.totalDiscount.Location = new System.Drawing.Point(486, 384);
            this.totalDiscount.Margin = new System.Windows.Forms.Padding(6);
            this.totalDiscount.Name = "totalDiscount";
            this.totalDiscount.Size = new System.Drawing.Size(108, 15);
            this.totalDiscount.TabIndex = 19;
            this.totalDiscount.Text = "Total Discount:";
            this.totalDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(486, 431);
            this.label4.Margin = new System.Windows.Forms.Padding(6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Total:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(606, 384);
            this.label1.Margin = new System.Windows.Forms.Padding(6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "800.00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(606, 431);
            this.label2.Margin = new System.Windows.Forms.Padding(6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "3000.00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 23;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(366, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Address:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(126, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Customer:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Item Name:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(126, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Category:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(246, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Sub Total:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(366, 141);
            this.label10.Margin = new System.Windows.Forms.Padding(6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Unit Price:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(486, 141);
            this.label11.Margin = new System.Windows.Forms.Padding(6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "Total:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // caption
            // 
            this.caption.AutoSize = true;
            this.caption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.SetColumnSpan(this.caption, 4);
            this.caption.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.caption.Location = new System.Drawing.Point(241, 1);
            this.caption.Margin = new System.Windows.Forms.Padding(1);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(297, 25);
            this.caption.TabIndex = 31;
            this.caption.Text = "Quadrate Tech Solutions";
            this.caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "total";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox customerMobile;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Button newInvoice;
        private System.Windows.Forms.Button salesReturn;
        private System.Windows.Forms.Button saveToDraft;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox enterItemCode;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label unitPrice;
        private System.Windows.Forms.Label itemCategory;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label total1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Total;
        private System.Windows.Forms.Button printSave;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label totalDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label caption;
    }
}

