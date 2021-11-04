
namespace OnlineShop
{
    partial class Home
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
            this.searchBox = new System.Windows.Forms.ComboBox();
            this.searchItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pan_Search = new System.Windows.Forms.Panel();
            this.pic_Back = new System.Windows.Forms.PictureBox();
            this.btn_TV = new System.Windows.Forms.Button();
            this.btn_Android = new System.Windows.Forms.Button();
            this.btn_Apple = new System.Windows.Forms.Button();
            this.btn_Laptop = new System.Windows.Forms.Button();
            this.pic_Search = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Discount = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Item = new System.Windows.Forms.Button();
            this.pic_Cart = new System.Windows.Forms.PictureBox();
            this.pan_Item = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.newItems = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pan_Discount = new System.Windows.Forms.FlowLayoutPanel();
            this.pan_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Search)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cart)).BeginInit();
            this.pan_Item.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchBox.FormattingEnabled = true;
            this.searchBox.Location = new System.Drawing.Point(36, 30);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(325, 24);
            this.searchBox.TabIndex = 0;
            // 
            // searchItems
            // 
            this.searchItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchItems.AutoScroll = true;
            this.searchItems.Location = new System.Drawing.Point(0, 90);
            this.searchItems.Margin = new System.Windows.Forms.Padding(4);
            this.searchItems.Name = "searchItems";
            this.searchItems.Size = new System.Drawing.Size(1116, 462);
            this.searchItems.TabIndex = 1;
            // 
            // pan_Search
            // 
            this.pan_Search.Controls.Add(this.pic_Back);
            this.pan_Search.Controls.Add(this.btn_TV);
            this.pan_Search.Controls.Add(this.btn_Android);
            this.pan_Search.Controls.Add(this.btn_Apple);
            this.pan_Search.Controls.Add(this.btn_Laptop);
            this.pan_Search.Controls.Add(this.pic_Search);
            this.pan_Search.Controls.Add(this.searchItems);
            this.pan_Search.Controls.Add(this.searchBox);
            this.pan_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Search.Location = new System.Drawing.Point(0, 0);
            this.pan_Search.Margin = new System.Windows.Forms.Padding(4);
            this.pan_Search.Name = "pan_Search";
            this.pan_Search.Size = new System.Drawing.Size(1116, 613);
            this.pan_Search.TabIndex = 3;
            // 
            // pic_Back
            // 
            this.pic_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Back.BackColor = System.Drawing.SystemColors.Control;
            this.pic_Back.Image = global::OnlineShop.Properties.Resources.back;
            this.pic_Back.Location = new System.Drawing.Point(1029, 20);
            this.pic_Back.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Back.Name = "pic_Back";
            this.pic_Back.Size = new System.Drawing.Size(61, 36);
            this.pic_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Back.TabIndex = 2;
            this.pic_Back.TabStop = false;
            this.pic_Back.Visible = false;
            this.pic_Back.Click += new System.EventHandler(this.pic_Back_Click);
            // 
            // btn_TV
            // 
            this.btn_TV.FlatAppearance.BorderSize = 0;
            this.btn_TV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TV.Location = new System.Drawing.Point(580, 270);
            this.btn_TV.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TV.Name = "btn_TV";
            this.btn_TV.Size = new System.Drawing.Size(87, 80);
            this.btn_TV.TabIndex = 8;
            this.btn_TV.Text = "Item";
            this.btn_TV.UseVisualStyleBackColor = true;
            this.btn_TV.Click += new System.EventHandler(this.btn_TV_Click);
            // 
            // btn_Android
            // 
            this.btn_Android.FlatAppearance.BorderSize = 0;
            this.btn_Android.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Android.Location = new System.Drawing.Point(463, 270);
            this.btn_Android.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Android.Name = "btn_Android";
            this.btn_Android.Size = new System.Drawing.Size(87, 80);
            this.btn_Android.TabIndex = 7;
            this.btn_Android.Text = "Item";
            this.btn_Android.UseVisualStyleBackColor = true;
            this.btn_Android.Click += new System.EventHandler(this.btn_Android_Click);
            // 
            // btn_Apple
            // 
            this.btn_Apple.FlatAppearance.BorderSize = 0;
            this.btn_Apple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apple.Location = new System.Drawing.Point(580, 165);
            this.btn_Apple.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Apple.Name = "btn_Apple";
            this.btn_Apple.Size = new System.Drawing.Size(87, 80);
            this.btn_Apple.TabIndex = 9;
            this.btn_Apple.Text = "Item";
            this.btn_Apple.UseVisualStyleBackColor = true;
            this.btn_Apple.Click += new System.EventHandler(this.btn_Apple_Click);
            // 
            // btn_Laptop
            // 
            this.btn_Laptop.FlatAppearance.BorderSize = 0;
            this.btn_Laptop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Laptop.Location = new System.Drawing.Point(463, 165);
            this.btn_Laptop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Laptop.Name = "btn_Laptop";
            this.btn_Laptop.Size = new System.Drawing.Size(87, 80);
            this.btn_Laptop.TabIndex = 6;
            this.btn_Laptop.Text = "Item";
            this.btn_Laptop.UseVisualStyleBackColor = true;
            this.btn_Laptop.Click += new System.EventHandler(this.btn_Laptop_Click);
            // 
            // pic_Search
            // 
            this.pic_Search.Image = global::OnlineShop.Properties.Resources.search;
            this.pic_Search.Location = new System.Drawing.Point(371, 18);
            this.pic_Search.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Search.Name = "pic_Search";
            this.pic_Search.Size = new System.Drawing.Size(40, 37);
            this.pic_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Search.TabIndex = 3;
            this.pic_Search.TabStop = false;
            this.pic_Search.Click += new System.EventHandler(this.pic_Search_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Discount, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Search, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Item, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pic_Cart, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1116, 62);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btn_Discount
            // 
            this.btn_Discount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Discount.FlatAppearance.BorderSize = 0;
            this.btn_Discount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Discount.Location = new System.Drawing.Point(420, 4);
            this.btn_Discount.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Discount.Name = "btn_Discount";
            this.btn_Discount.Size = new System.Drawing.Size(341, 54);
            this.btn_Discount.TabIndex = 6;
            this.btn_Discount.Text = "Discount";
            this.btn_Discount.UseVisualStyleBackColor = true;
            this.btn_Discount.Click += new System.EventHandler(this.btn_Discount_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Location = new System.Drawing.Point(769, 4);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(343, 54);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Item
            // 
            this.btn_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Item.FlatAppearance.BorderSize = 0;
            this.btn_Item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Item.Location = new System.Drawing.Point(71, 4);
            this.btn_Item.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Item.Name = "btn_Item";
            this.btn_Item.Size = new System.Drawing.Size(341, 54);
            this.btn_Item.TabIndex = 5;
            this.btn_Item.Text = "Item";
            this.btn_Item.UseVisualStyleBackColor = true;
            this.btn_Item.Click += new System.EventHandler(this.btn_Item_Click);
            // 
            // pic_Cart
            // 
            this.pic_Cart.BackColor = System.Drawing.Color.Transparent;
            this.pic_Cart.Image = global::OnlineShop.Properties.Resources.shopping_cart;
            this.pic_Cart.Location = new System.Drawing.Point(4, 4);
            this.pic_Cart.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Cart.Name = "pic_Cart";
            this.pic_Cart.Size = new System.Drawing.Size(59, 54);
            this.pic_Cart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Cart.TabIndex = 0;
            this.pic_Cart.TabStop = false;
            this.pic_Cart.Click += new System.EventHandler(this.pic_Cart_Click);
            // 
            // pan_Item
            // 
            this.pan_Item.AutoScroll = true;
            this.pan_Item.Controls.Add(this.flowLayoutPanel3);
            this.pan_Item.Controls.Add(this.label2);
            this.pan_Item.Controls.Add(this.newItems);
            this.pan_Item.Controls.Add(this.label1);
            this.pan_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Item.Location = new System.Drawing.Point(0, 62);
            this.pan_Item.Margin = new System.Windows.Forms.Padding(4);
            this.pan_Item.Name = "pan_Item";
            this.pan_Item.Size = new System.Drawing.Size(1116, 551);
            this.pan_Item.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(17, 314);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1099, 209);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // newItems
            // 
            this.newItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newItems.AutoScroll = true;
            this.newItems.Location = new System.Drawing.Point(17, 44);
            this.newItems.Margin = new System.Windows.Forms.Padding(4);
            this.newItems.Name = "newItems";
            this.newItems.Size = new System.Drawing.Size(1099, 209);
            this.newItems.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "New";
            // 
            // pan_Discount
            // 
            this.pan_Discount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Discount.Location = new System.Drawing.Point(0, 0);
            this.pan_Discount.Margin = new System.Windows.Forms.Padding(4);
            this.pan_Discount.Name = "pan_Discount";
            this.pan_Discount.Size = new System.Drawing.Size(1116, 613);
            this.pan_Discount.TabIndex = 6;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pan_Item);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pan_Search);
            this.Controls.Add(this.pan_Discount);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1116, 613);
            this.Load += new System.EventHandler(this.Home_Load);
            this.pan_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Search)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cart)).EndInit();
            this.pan_Item.ResumeLayout(false);
            this.pan_Item.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox searchBox;
        private System.Windows.Forms.FlowLayoutPanel searchItems;
        private System.Windows.Forms.PictureBox pic_Back;
        private System.Windows.Forms.Panel pan_Search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Discount;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.PictureBox pic_Cart;
        private System.Windows.Forms.Button btn_Item;
        private System.Windows.Forms.Panel pan_Item;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel newItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pan_Discount;
        private System.Windows.Forms.PictureBox pic_Search;
        private System.Windows.Forms.Button btn_Laptop;
        private System.Windows.Forms.Button btn_TV;
        private System.Windows.Forms.Button btn_Android;
        private System.Windows.Forms.Button btn_Apple;
    }
}
