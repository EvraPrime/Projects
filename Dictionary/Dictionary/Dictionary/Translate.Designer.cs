
namespace Dictionary
{
    partial class Translate
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
            this.rtbFrom = new System.Windows.Forms.RichTextBox();
            this.rtbTo = new System.Windows.Forms.RichTextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbFrom
            // 
            this.rtbFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbFrom.Location = new System.Drawing.Point(2, 2);
            this.rtbFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbFrom.Name = "rtbFrom";
            this.rtbFrom.Size = new System.Drawing.Size(304, 163);
            this.rtbFrom.TabIndex = 0;
            this.rtbFrom.Text = "";
            // 
            // rtbTo
            // 
            this.rtbTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTo.Location = new System.Drawing.Point(310, 2);
            this.rtbTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbTo.Name = "rtbTo";
            this.rtbTo.ReadOnly = true;
            this.rtbTo.Size = new System.Drawing.Size(304, 163);
            this.rtbTo.TabIndex = 1;
            this.rtbTo.Text = "";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(272, 29);
            this.btnTranslate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(69, 36);
            this.btnTranslate.TabIndex = 2;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Dictionary.Properties.Resources.volume_up_interface_symbol;
            this.pictureBox1.Location = new System.Drawing.Point(554, 169);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dictionary.Properties.Resources.volume_up_interface_symbol;
            this.pictureBox2.Location = new System.Drawing.Point(2, 169);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rtbFrom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtbTo, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 113);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.71053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.28947F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 234);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // Translate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnTranslate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Translate";
            this.Size = new System.Drawing.Size(636, 401);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbFrom;
        private System.Windows.Forms.RichTextBox rtbTo;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
