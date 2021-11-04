
namespace OnlineShop
{
    partial class Order
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Ship = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.selectedItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Sum = new System.Windows.Forms.Label();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.cmb_Discount = new System.Windows.Forms.ComboBox();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.btn_Close);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(704, 38);
            this.topPanel.TabIndex = 10;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = global::OnlineShop.Properties.Resources.Exit;
            this.btn_Close.Location = new System.Drawing.Point(638, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(64, 37);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Order";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_Discount);
            this.panel2.Controls.Add(this.cmb_Discount);
            this.panel2.Controls.Add(this.btn_Pay);
            this.panel2.Controls.Add(this.lbl_Sum);
            this.panel2.Controls.Add(this.selectedItems);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lbl_Ship);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbl_Phone);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbl_Name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_Address);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 605);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phone Number:";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(388, 75);
            this.lbl_Address.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(65, 22);
            this.lbl_Address.TabIndex = 3;
            this.lbl_Address.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(388, 15);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(65, 22);
            this.lbl_Name.TabIndex = 5;
            this.lbl_Name.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address:";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.Location = new System.Drawing.Point(388, 45);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(65, 22);
            this.lbl_Phone.TabIndex = 7;
            this.lbl_Phone.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Shipping Fee:";
            // 
            // lbl_Ship
            // 
            this.lbl_Ship.AutoSize = true;
            this.lbl_Ship.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ship.Location = new System.Drawing.Point(388, 370);
            this.lbl_Ship.Name = "lbl_Ship";
            this.lbl_Ship.Size = new System.Drawing.Size(65, 22);
            this.lbl_Ship.TabIndex = 11;
            this.lbl_Ship.Text = "10000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(150, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total:";
            // 
            // selectedItems
            // 
            this.selectedItems.AutoScroll = true;
            this.selectedItems.Location = new System.Drawing.Point(0, 117);
            this.selectedItems.Name = "selectedItems";
            this.selectedItems.Size = new System.Drawing.Size(700, 226);
            this.selectedItems.TabIndex = 0;
            // 
            // lbl_Sum
            // 
            this.lbl_Sum.AutoSize = true;
            this.lbl_Sum.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sum.Location = new System.Drawing.Point(388, 413);
            this.lbl_Sum.Name = "lbl_Sum";
            this.lbl_Sum.Size = new System.Drawing.Size(65, 22);
            this.lbl_Sum.TabIndex = 13;
            this.lbl_Sum.Text = "label2";
            // 
            // btn_Pay
            // 
            this.btn_Pay.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Pay.FlatAppearance.BorderSize = 0;
            this.btn_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pay.Location = new System.Drawing.Point(37, 517);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(629, 48);
            this.btn_Pay.TabIndex = 14;
            this.btn_Pay.Text = "Pay Order";
            this.btn_Pay.UseVisualStyleBackColor = false;
            // 
            // cmb_Discount
            // 
            this.cmb_Discount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Discount.FormattingEnabled = true;
            this.cmb_Discount.Items.AddRange(new object[] {
            ""});
            this.cmb_Discount.Location = new System.Drawing.Point(392, 456);
            this.cmb_Discount.Name = "cmb_Discount";
            this.cmb_Discount.Size = new System.Drawing.Size(121, 29);
            this.cmb_Discount.TabIndex = 15;
            this.cmb_Discount.SelectedIndexChanged += new System.EventHandler(this.cmb_Discount_SelectedIndexChanged);
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(150, 459);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(39, 22);
            this.lbl_Discount.TabIndex = 16;
            this.lbl_Discount.Text = "N/a";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.ComboBox cmb_Discount;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Label lbl_Sum;
        private System.Windows.Forms.FlowLayoutPanel selectedItems;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Ship;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label label1;
    }
}