
namespace OnlineShop
{
    partial class OrderItem
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
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.pic_Order = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(135, 26);
            this.lbl_ID.MaximumSize = new System.Drawing.Size(770, 50);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(78, 22);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "vsdvsd";
            // 
            // lbl_Total
            // 
            this.lbl_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(896, 26);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(65, 22);
            this.lbl_Total.TabIndex = 1;
            this.lbl_Total.Text = "label2";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(135, 77);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(65, 22);
            this.lbl_Address.TabIndex = 2;
            this.lbl_Address.Text = "label3";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(896, 77);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(65, 22);
            this.lbl_Date.TabIndex = 5;
            this.lbl_Date.Text = "label5";
            // 
            // pic_Order
            // 
            this.pic_Order.Location = new System.Drawing.Point(29, 15);
            this.pic_Order.Name = "pic_Order";
            this.pic_Order.Size = new System.Drawing.Size(100, 100);
            this.pic_Order.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Order.TabIndex = 3;
            this.pic_Order.TabStop = false;
            this.pic_Order.Click += new System.EventHandler(this.OrderItem_Click);
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.pic_Order);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_ID);
            this.Name = "OrderItem";
            this.Size = new System.Drawing.Size(1054, 144);
            this.Load += new System.EventHandler(this.OrderItem_Load);
            this.Click += new System.EventHandler(this.OrderItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.PictureBox pic_Order;
        private System.Windows.Forms.Label lbl_Date;
    }
}
