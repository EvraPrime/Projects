
namespace OnlineShop
{
    partial class Discount
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Code = new System.Windows.Forms.Label();
            this.lbl_ExDate = new System.Windows.Forms.Label();
            this.lbl_ReDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(110, 17);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(65, 22);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "label1";
            // 
            // lbl_Code
            // 
            this.lbl_Code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Code.AutoSize = true;
            this.lbl_Code.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Code.Location = new System.Drawing.Point(837, 37);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(65, 22);
            this.lbl_Code.TabIndex = 2;
            this.lbl_Code.Text = "label2";
            // 
            // lbl_ExDate
            // 
            this.lbl_ExDate.AutoSize = true;
            this.lbl_ExDate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExDate.Location = new System.Drawing.Point(110, 70);
            this.lbl_ExDate.Name = "lbl_ExDate";
            this.lbl_ExDate.Size = new System.Drawing.Size(65, 22);
            this.lbl_ExDate.TabIndex = 3;
            this.lbl_ExDate.Text = "label3";
            // 
            // lbl_ReDate
            // 
            this.lbl_ReDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ReDate.AutoSize = true;
            this.lbl_ReDate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReDate.Location = new System.Drawing.Point(883, 92);
            this.lbl_ReDate.Name = "lbl_ReDate";
            this.lbl_ReDate.Size = new System.Drawing.Size(46, 16);
            this.lbl_ReDate.TabIndex = 4;
            this.lbl_ReDate.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OnlineShop.Properties.Resources.tag;
            this.pictureBox1.Location = new System.Drawing.Point(18, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_ReDate);
            this.Controls.Add(this.lbl_ExDate);
            this.Controls.Add(this.lbl_Code);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Discount";
            this.Size = new System.Drawing.Size(976, 108);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Code;
        private System.Windows.Forms.Label lbl_ExDate;
        private System.Windows.Forms.Label lbl_ReDate;
    }
}
