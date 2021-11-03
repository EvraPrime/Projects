
namespace OnlineShop
{
    partial class Item
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
            this.pic_Item = new System.Windows.Forms.PictureBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Item
            // 
            this.pic_Item.Location = new System.Drawing.Point(3, 3);
            this.pic_Item.Name = "pic_Item";
            this.pic_Item.Size = new System.Drawing.Size(133, 85);
            this.pic_Item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Item.TabIndex = 0;
            this.pic_Item.TabStop = false;
            this.pic_Item.Click += new System.EventHandler(this.Item_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(28, 91);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.Click += new System.EventHandler(this.Item_Click);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(32, 116);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(31, 13);
            this.lbl_Price.TabIndex = 2;
            this.lbl_Price.Text = "Price";
            this.lbl_Price.Click += new System.EventHandler(this.Item_Click);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(71, 134);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(35, 13);
            this.lbl_Date.TabIndex = 3;
            this.lbl_Date.Text = "label1";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.pic_Item);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(139, 147);
            this.Load += new System.EventHandler(this.Item_Load);
            this.Click += new System.EventHandler(this.Item_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Item;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Date;
    }
}
