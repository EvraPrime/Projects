
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
            this.btn_TV = new System.Windows.Forms.Button();
            this.btn_Android = new System.Windows.Forms.Button();
            this.pic_Back = new System.Windows.Forms.PictureBox();
            this.btn_Apple = new System.Windows.Forms.Button();
            this.pic_Search = new System.Windows.Forms.PictureBox();
            this.btn_Laptop = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Discount = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Item = new System.Windows.Forms.Button();
            this.pic_Cart = new System.Windows.Forms.PictureBox();
            this.pan_Item = new System.Windows.Forms.Panel();
            this.appleItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_S = new System.Windows.Forms.Label();
            this.newItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_New = new System.Windows.Forms.Label();
            this.pan_Discount = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pan_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Search)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cart)).BeginInit();
            this.pan_Item.SuspendLayout();
            this.pan_Discount.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.FormattingEnabled = true;
            this.searchBox.Location = new System.Drawing.Point(130, 30);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(598, 29);
            this.searchBox.TabIndex = 0;
            // 
            // searchItems
            // 
            this.searchItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchItems.AutoScroll = true;
            this.searchItems.Location = new System.Drawing.Point(0, 187);
            this.searchItems.Margin = new System.Windows.Forms.Padding(4);
            this.searchItems.Name = "searchItems";
            this.searchItems.Size = new System.Drawing.Size(1116, 425);
            this.searchItems.TabIndex = 1;
            // 
            // pan_Search
            // 
            this.pan_Search.BackColor = System.Drawing.Color.White;
            this.pan_Search.Controls.Add(this.btn_TV);
            this.pan_Search.Controls.Add(this.btn_Android);
            this.pan_Search.Controls.Add(this.pic_Back);
            this.pan_Search.Controls.Add(this.btn_Apple);
            this.pan_Search.Controls.Add(this.pic_Search);
            this.pan_Search.Controls.Add(this.btn_Laptop);
            this.pan_Search.Controls.Add(this.searchItems);
            this.pan_Search.Controls.Add(this.searchBox);
            this.pan_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Search.Location = new System.Drawing.Point(0, 0);
            this.pan_Search.Margin = new System.Windows.Forms.Padding(4);
            this.pan_Search.Name = "pan_Search";
            this.pan_Search.Size = new System.Drawing.Size(1116, 613);
            this.pan_Search.TabIndex = 3;
            // 
            // btn_TV
            // 
            this.btn_TV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_TV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TV.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TV.Image = global::OnlineShop.Properties.Resources.watch_tv;
            this.btn_TV.Location = new System.Drawing.Point(586, 181);
            this.btn_TV.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TV.Name = "btn_TV";
            this.btn_TV.Size = new System.Drawing.Size(120, 120);
            this.btn_TV.TabIndex = 8;
            this.btn_TV.Text = "TV";
            this.btn_TV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_TV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_TV.UseVisualStyleBackColor = true;
            this.btn_TV.Click += new System.EventHandler(this.btn_TV_Click);
            // 
            // btn_Android
            // 
            this.btn_Android.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Android.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Android.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Android.Image = global::OnlineShop.Properties.Resources.android;
            this.btn_Android.Location = new System.Drawing.Point(767, 181);
            this.btn_Android.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Android.Name = "btn_Android";
            this.btn_Android.Size = new System.Drawing.Size(120, 120);
            this.btn_Android.TabIndex = 7;
            this.btn_Android.Text = "Android";
            this.btn_Android.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Android.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Android.UseVisualStyleBackColor = true;
            this.btn_Android.Click += new System.EventHandler(this.btn_Android_Click);
            // 
            // pic_Back
            // 
            this.pic_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Back.BackColor = System.Drawing.Color.Transparent;
            this.pic_Back.Image = global::OnlineShop.Properties.Resources.back;
            this.pic_Back.Location = new System.Drawing.Point(1035, 23);
            this.pic_Back.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Back.Name = "pic_Back";
            this.pic_Back.Size = new System.Drawing.Size(61, 36);
            this.pic_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Back.TabIndex = 2;
            this.pic_Back.TabStop = false;
            this.pic_Back.Visible = false;
            this.pic_Back.Click += new System.EventHandler(this.pic_Back_Click);
            // 
            // btn_Apple
            // 
            this.btn_Apple.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Apple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apple.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Apple.Image = global::OnlineShop.Properties.Resources.apple_black_logo;
            this.btn_Apple.Location = new System.Drawing.Point(224, 181);
            this.btn_Apple.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Apple.Name = "btn_Apple";
            this.btn_Apple.Size = new System.Drawing.Size(120, 120);
            this.btn_Apple.TabIndex = 9;
            this.btn_Apple.Text = "Apple";
            this.btn_Apple.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Apple.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Apple.UseVisualStyleBackColor = true;
            this.btn_Apple.Click += new System.EventHandler(this.btn_Apple_Click);
            // 
            // pic_Search
            // 
            this.pic_Search.Image = global::OnlineShop.Properties.Resources.search;
            this.pic_Search.Location = new System.Drawing.Point(755, 21);
            this.pic_Search.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Search.Name = "pic_Search";
            this.pic_Search.Size = new System.Drawing.Size(45, 45);
            this.pic_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Search.TabIndex = 3;
            this.pic_Search.TabStop = false;
            this.pic_Search.Click += new System.EventHandler(this.pic_Search_Click);
            // 
            // btn_Laptop
            // 
            this.btn_Laptop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Laptop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Laptop.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Laptop.Image = global::OnlineShop.Properties.Resources.laptop;
            this.btn_Laptop.Location = new System.Drawing.Point(405, 181);
            this.btn_Laptop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Laptop.Name = "btn_Laptop";
            this.btn_Laptop.Size = new System.Drawing.Size(120, 120);
            this.btn_Laptop.TabIndex = 6;
            this.btn_Laptop.Text = "Laptop";
            this.btn_Laptop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Laptop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Laptop.UseVisualStyleBackColor = true;
            this.btn_Laptop.Click += new System.EventHandler(this.btn_Laptop_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topPanel.ColumnCount = 4;
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.topPanel.Controls.Add(this.btn_Discount, 2, 0);
            this.topPanel.Controls.Add(this.btn_Search, 3, 0);
            this.topPanel.Controls.Add(this.btn_Item, 1, 0);
            this.topPanel.Controls.Add(this.pic_Cart, 0, 0);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.RowCount = 1;
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topPanel.Size = new System.Drawing.Size(1116, 60);
            this.topPanel.TabIndex = 4;
            // 
            // btn_Discount
            // 
            this.btn_Discount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Discount.FlatAppearance.BorderSize = 0;
            this.btn_Discount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Discount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Discount.Location = new System.Drawing.Point(420, 4);
            this.btn_Discount.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Discount.Name = "btn_Discount";
            this.btn_Discount.Size = new System.Drawing.Size(341, 52);
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
            this.btn_Search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(769, 4);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(343, 52);
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
            this.btn_Item.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Item.Location = new System.Drawing.Point(71, 4);
            this.btn_Item.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Item.Name = "btn_Item";
            this.btn_Item.Size = new System.Drawing.Size(341, 52);
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
            this.pic_Cart.Size = new System.Drawing.Size(59, 52);
            this.pic_Cart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Cart.TabIndex = 0;
            this.pic_Cart.TabStop = false;
            this.pic_Cart.Click += new System.EventHandler(this.pic_Cart_Click);
            // 
            // pan_Item
            // 
            this.pan_Item.AutoScroll = true;
            this.pan_Item.BackColor = System.Drawing.Color.White;
            this.pan_Item.Controls.Add(this.appleItems);
            this.pan_Item.Controls.Add(this.lbl_S);
            this.pan_Item.Controls.Add(this.newItems);
            this.pan_Item.Controls.Add(this.lbl_New);
            this.pan_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Item.Location = new System.Drawing.Point(0, 60);
            this.pan_Item.Margin = new System.Windows.Forms.Padding(4);
            this.pan_Item.Name = "pan_Item";
            this.pan_Item.Size = new System.Drawing.Size(1116, 553);
            this.pan_Item.TabIndex = 5;
            // 
            // appleItems
            // 
            this.appleItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appleItems.AutoScroll = true;
            this.appleItems.Location = new System.Drawing.Point(17, 296);
            this.appleItems.Margin = new System.Windows.Forms.Padding(4);
            this.appleItems.Name = "appleItems";
            this.appleItems.Size = new System.Drawing.Size(1079, 209);
            this.appleItems.TabIndex = 3;
            // 
            // lbl_S
            // 
            this.lbl_S.AutoSize = true;
            this.lbl_S.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_S.Location = new System.Drawing.Point(32, 270);
            this.lbl_S.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_S.Name = "lbl_S";
            this.lbl_S.Size = new System.Drawing.Size(63, 22);
            this.lbl_S.TabIndex = 2;
            this.lbl_S.Text = "Apple";
            // 
            // newItems
            // 
            this.newItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newItems.AutoScroll = true;
            this.newItems.Location = new System.Drawing.Point(17, 44);
            this.newItems.Margin = new System.Windows.Forms.Padding(4);
            this.newItems.Name = "newItems";
            this.newItems.Size = new System.Drawing.Size(1079, 209);
            this.newItems.TabIndex = 1;
            // 
            // lbl_New
            // 
            this.lbl_New.AutoSize = true;
            this.lbl_New.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_New.Location = new System.Drawing.Point(32, 18);
            this.lbl_New.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_New.Name = "lbl_New";
            this.lbl_New.Size = new System.Drawing.Size(49, 22);
            this.lbl_New.TabIndex = 0;
            this.lbl_New.Text = "New";
            // 
            // pan_Discount
            // 
            this.pan_Discount.AutoScroll = true;
            this.pan_Discount.Controls.Add(this.flowLayoutPanel1);
            this.pan_Discount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Discount.Location = new System.Drawing.Point(0, 0);
            this.pan_Discount.Margin = new System.Windows.Forms.Padding(4);
            this.pan_Discount.Name = "pan_Discount";
            this.pan_Discount.Padding = new System.Windows.Forms.Padding(5);
            this.pan_Discount.Size = new System.Drawing.Size(1116, 613);
            this.pan_Discount.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(679, 0);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pan_Item);
            this.Controls.Add(this.topPanel);
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
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cart)).EndInit();
            this.pan_Item.ResumeLayout(false);
            this.pan_Item.PerformLayout();
            this.pan_Discount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox searchBox;
        private System.Windows.Forms.FlowLayoutPanel searchItems;
        private System.Windows.Forms.PictureBox pic_Back;
        private System.Windows.Forms.Panel pan_Search;
        private System.Windows.Forms.TableLayoutPanel topPanel;
        private System.Windows.Forms.Button btn_Discount;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.PictureBox pic_Cart;
        private System.Windows.Forms.Button btn_Item;
        private System.Windows.Forms.Panel pan_Item;
        private System.Windows.Forms.FlowLayoutPanel appleItems;
        private System.Windows.Forms.Label lbl_S;
        private System.Windows.Forms.FlowLayoutPanel newItems;
        private System.Windows.Forms.Label lbl_New;
        private System.Windows.Forms.FlowLayoutPanel pan_Discount;
        private System.Windows.Forms.PictureBox pic_Search;
        private System.Windows.Forms.Button btn_Laptop;
        private System.Windows.Forms.Button btn_TV;
        private System.Windows.Forms.Button btn_Android;
        private System.Windows.Forms.Button btn_Apple;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
