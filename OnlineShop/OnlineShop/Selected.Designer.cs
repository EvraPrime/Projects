
namespace OnlineShop
{
    partial class Selected
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
            this.num_Amount = new System.Windows.Forms.NumericUpDown();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.pic_Item = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // num_Amount
            // 
            this.num_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_Amount.Location = new System.Drawing.Point(614, 66);
            this.num_Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Amount.Name = "num_Amount";
            this.num_Amount.Size = new System.Drawing.Size(51, 22);
            this.num_Amount.TabIndex = 12;
            this.num_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Amount.ValueChanged += new System.EventHandler(this.num_Amount_ValueChanged);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(218, 91);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(40, 17);
            this.lbl_Price.TabIndex = 11;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(213, 32);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(45, 17);
            this.lbl_Name.TabIndex = 10;
            this.lbl_Name.Text = "Name";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(697, 56);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(50, 40);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "button1";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // pic_Item
            // 
            this.pic_Item.Location = new System.Drawing.Point(12, 14);
            this.pic_Item.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Item.Name = "pic_Item";
            this.pic_Item.Size = new System.Drawing.Size(183, 135);
            this.pic_Item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Item.TabIndex = 9;
            this.pic_Item.TabStop = false;
            // 
            // Selected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.num_Amount);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.pic_Item);
            this.Name = "Selected";
            this.Size = new System.Drawing.Size(773, 165);
            ((System.ComponentModel.ISupportInitialize)(this.num_Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_Amount;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.PictureBox pic_Item;
        private System.Windows.Forms.Button btn_Delete;
    }
}
