
namespace OnlineShop
{
    partial class Cart
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
            this.selectedItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_P = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_N = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_A = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.lbl_Ship = new System.Windows.Forms.Label();
            this.lbl_F = new System.Windows.Forms.Label();
            this.lbl_Sum = new System.Windows.Forms.Label();
            this.lbl_T = new System.Windows.Forms.Label();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Change = new System.Windows.Forms.Label();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.cmb_Discount = new System.Windows.Forms.ComboBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectedItems
            // 
            this.selectedItems.AutoScroll = true;
            this.selectedItems.Location = new System.Drawing.Point(0, 117);
            this.selectedItems.Name = "selectedItems";
            this.selectedItems.Size = new System.Drawing.Size(700, 226);
            this.selectedItems.TabIndex = 0;
            // 
            // lbl_P
            // 
            this.lbl_P.AutoSize = true;
            this.lbl_P.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P.Location = new System.Drawing.Point(152, 45);
            this.lbl_P.Name = "lbl_P";
            this.lbl_P.Size = new System.Drawing.Size(155, 22);
            this.lbl_P.TabIndex = 2;
            this.lbl_P.Text = "Phone Number:";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(327, 74);
            this.lbl_Address.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(65, 22);
            this.lbl_Address.TabIndex = 3;
            this.lbl_Address.Text = "label2";
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = global::OnlineShop.Properties.Resources.Exit;
            this.btn_Close.Location = new System.Drawing.Point(639, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(61, 38);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(327, 14);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(65, 22);
            this.lbl_Name.TabIndex = 5;
            this.lbl_Name.Text = "label2";
            // 
            // lbl_N
            // 
            this.lbl_N.AutoSize = true;
            this.lbl_N.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_N.Location = new System.Drawing.Point(152, 16);
            this.lbl_N.Name = "lbl_N";
            this.lbl_N.Size = new System.Drawing.Size(69, 22);
            this.lbl_N.TabIndex = 4;
            this.lbl_N.Text = "Name:";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.Location = new System.Drawing.Point(327, 44);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(65, 22);
            this.lbl_Phone.TabIndex = 7;
            this.lbl_Phone.Text = "label2";
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_A.Location = new System.Drawing.Point(152, 74);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(95, 22);
            this.lbl_A.TabIndex = 6;
            this.lbl_A.Text = "Address:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(29, 8);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(50, 24);
            this.lbl_Title.TabIndex = 8;
            this.lbl_Title.Text = "Cart";
            // 
            // topPanel
            // 
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.btn_Close);
            this.topPanel.Controls.Add(this.lbl_Title);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(702, 38);
            this.topPanel.TabIndex = 9;
            // 
            // lbl_Ship
            // 
            this.lbl_Ship.AutoSize = true;
            this.lbl_Ship.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ship.Location = new System.Drawing.Point(327, 356);
            this.lbl_Ship.Name = "lbl_Ship";
            this.lbl_Ship.Size = new System.Drawing.Size(65, 22);
            this.lbl_Ship.TabIndex = 11;
            this.lbl_Ship.Text = "10000";
            // 
            // lbl_F
            // 
            this.lbl_F.AutoSize = true;
            this.lbl_F.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_F.Location = new System.Drawing.Point(150, 361);
            this.lbl_F.Name = "lbl_F";
            this.lbl_F.Size = new System.Drawing.Size(139, 22);
            this.lbl_F.TabIndex = 10;
            this.lbl_F.Text = "Shipping Fee:";
            // 
            // lbl_Sum
            // 
            this.lbl_Sum.AutoSize = true;
            this.lbl_Sum.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sum.Location = new System.Drawing.Point(327, 399);
            this.lbl_Sum.Name = "lbl_Sum";
            this.lbl_Sum.Size = new System.Drawing.Size(65, 22);
            this.lbl_Sum.TabIndex = 13;
            this.lbl_Sum.Text = "label2";
            // 
            // lbl_T
            // 
            this.lbl_T.AutoSize = true;
            this.lbl_T.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_T.Location = new System.Drawing.Point(150, 405);
            this.lbl_T.Name = "lbl_T";
            this.lbl_T.Size = new System.Drawing.Size(63, 22);
            this.lbl_T.TabIndex = 12;
            this.lbl_T.Text = "Total:";
            // 
            // btn_Pay
            // 
            this.btn_Pay.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Pay.FlatAppearance.BorderSize = 0;
            this.btn_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pay.Location = new System.Drawing.Point(33, 497);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(629, 48);
            this.btn_Pay.TabIndex = 14;
            this.btn_Pay.Text = "Pay Order";
            this.btn_Pay.UseVisualStyleBackColor = false;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_Change);
            this.panel1.Controls.Add(this.lbl_Discount);
            this.panel1.Controls.Add(this.cmb_Discount);
            this.panel1.Controls.Add(this.btn_Pay);
            this.panel1.Controls.Add(this.lbl_Sum);
            this.panel1.Controls.Add(this.selectedItems);
            this.panel1.Controls.Add(this.lbl_T);
            this.panel1.Controls.Add(this.lbl_Ship);
            this.panel1.Controls.Add(this.lbl_F);
            this.panel1.Controls.Add(this.lbl_Phone);
            this.panel1.Controls.Add(this.lbl_A);
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Controls.Add(this.lbl_N);
            this.panel1.Controls.Add(this.lbl_Address);
            this.panel1.Controls.Add(this.lbl_P);
            this.panel1.Controls.Add(this.txt_Address);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 587);
            this.panel1.TabIndex = 15;
            // 
            // lbl_Change
            // 
            this.lbl_Change.AutoSize = true;
            this.lbl_Change.ForeColor = System.Drawing.Color.Green;
            this.lbl_Change.Location = new System.Drawing.Point(580, 74);
            this.lbl_Change.Name = "lbl_Change";
            this.lbl_Change.Size = new System.Drawing.Size(82, 22);
            this.lbl_Change.TabIndex = 17;
            this.lbl_Change.Text = "Change";
            this.lbl_Change.Click += new System.EventHandler(this.lbl_Change_Click);
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(150, 449);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(39, 22);
            this.lbl_Discount.TabIndex = 16;
            this.lbl_Discount.Text = "N/a";
            // 
            // cmb_Discount
            // 
            this.cmb_Discount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Discount.FormattingEnabled = true;
            this.cmb_Discount.Items.AddRange(new object[] {
            ""});
            this.cmb_Discount.Location = new System.Drawing.Point(331, 442);
            this.cmb_Discount.Name = "cmb_Discount";
            this.cmb_Discount.Size = new System.Drawing.Size(142, 29);
            this.cmb_Discount.TabIndex = 15;
            this.cmb_Discount.SelectedIndexChanged += new System.EventHandler(this.cmb_Discount_SelectedIndexChanged);
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(331, 71);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(243, 29);
            this.txt_Address.TabIndex = 18;
            this.txt_Address.Visible = false;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel selectedItems;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_P;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_N;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lbl_Ship;
        private System.Windows.Forms.Label lbl_F;
        private System.Windows.Forms.Label lbl_Sum;
        private System.Windows.Forms.Label lbl_T;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_Discount;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_Change;
        private System.Windows.Forms.TextBox txt_Address;
    }
}