
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Ship = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Sum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectedItems
            // 
            this.selectedItems.AutoScroll = true;
            this.selectedItems.Location = new System.Drawing.Point(0, 157);
            this.selectedItems.Name = "selectedItems";
            this.selectedItems.Size = new System.Drawing.Size(824, 247);
            this.selectedItems.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(458, 124);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(46, 17);
            this.lbl_Address.TabIndex = 3;
            this.lbl_Address.Text = "label2";
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = global::OnlineShop.Properties.Resources.Exit;
            this.btn_Close.Location = new System.Drawing.Point(771, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(53, 37);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(458, 64);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(46, 17);
            this.lbl_Name.TabIndex = 5;
            this.lbl_Name.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(458, 93);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(46, 17);
            this.lbl_Phone.TabIndex = 7;
            this.lbl_Phone.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cart";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 38);
            this.panel1.TabIndex = 9;
            // 
            // lbl_Ship
            // 
            this.lbl_Ship.AutoSize = true;
            this.lbl_Ship.Location = new System.Drawing.Point(458, 421);
            this.lbl_Ship.Name = "lbl_Ship";
            this.lbl_Ship.Size = new System.Drawing.Size(48, 17);
            this.lbl_Ship.TabIndex = 11;
            this.lbl_Ship.Text = "10000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address";
            // 
            // lbl_Sum
            // 
            this.lbl_Sum.AutoSize = true;
            this.lbl_Sum.Location = new System.Drawing.Point(458, 469);
            this.lbl_Sum.Name = "lbl_Sum";
            this.lbl_Sum.Size = new System.Drawing.Size(46, 17);
            this.lbl_Sum.TabIndex = 13;
            this.lbl_Sum.Text = "label2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Address";
            // 
            // btn_Pay
            // 
            this.btn_Pay.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Pay.FlatAppearance.BorderSize = 0;
            this.btn_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pay.Location = new System.Drawing.Point(87, 558);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(629, 48);
            this.btn_Pay.TabIndex = 14;
            this.btn_Pay.Text = "button1";
            this.btn_Pay.UseVisualStyleBackColor = false;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(824, 625);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.lbl_Sum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_Ship);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel selectedItems;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Ship;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Sum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Pay;
    }
}