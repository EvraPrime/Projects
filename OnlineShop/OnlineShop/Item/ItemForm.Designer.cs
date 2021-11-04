
namespace OnlineShop
{
    partial class ItemForm
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.pic_Item = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.num_Amount = new System.Windows.Forms.NumericUpDown();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Item)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = global::OnlineShop.Properties.Resources.Exit;
            this.btn_Close.Location = new System.Drawing.Point(704, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(53, 37);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(214, 301);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(35, 15);
            this.lbl_Date.TabIndex = 7;
            this.lbl_Date.Text = "Time";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(214, 264);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(40, 17);
            this.lbl_Price.TabIndex = 6;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(208, 233);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(45, 17);
            this.lbl_Name.TabIndex = 5;
            this.lbl_Name.Text = "Name";
            // 
            // pic_Item
            // 
            this.pic_Item.Location = new System.Drawing.Point(73, 16);
            this.pic_Item.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Item.Name = "pic_Item";
            this.pic_Item.Size = new System.Drawing.Size(289, 213);
            this.pic_Item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Item.TabIndex = 4;
            this.pic_Item.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 43);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.num_Amount);
            this.panel2.Controls.Add(this.lbl_Date);
            this.panel2.Controls.Add(this.lbl_Price);
            this.panel2.Controls.Add(this.lbl_Name);
            this.panel2.Controls.Add(this.pic_Item);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 518);
            this.panel2.TabIndex = 9;
            // 
            // num_Amount
            // 
            this.num_Amount.Location = new System.Drawing.Point(317, 409);
            this.num_Amount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Amount.Name = "num_Amount";
            this.num_Amount.Size = new System.Drawing.Size(120, 22);
            this.num_Amount.TabIndex = 8;
            this.num_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Save
            // 
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Location = new System.Drawing.Point(235, 447);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(312, 59);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Add to Cart";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Item)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.PictureBox pic_Item;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.NumericUpDown num_Amount;
    }
}