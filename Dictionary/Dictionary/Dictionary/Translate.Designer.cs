
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbFrom = new System.Windows.Forms.RichTextBox();
            this.rtbTo = new System.Windows.Forms.RichTextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtbTo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtbFrom, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1074, 500);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // rtbFrom
            // 
            this.rtbFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbFrom.Location = new System.Drawing.Point(3, 45);
            this.rtbFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbFrom.Name = "rtbFrom";
            this.rtbFrom.Size = new System.Drawing.Size(496, 453);
            this.rtbFrom.TabIndex = 0;
            this.rtbFrom.Text = "";
            // 
            // rtbTo
            // 
            this.rtbTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTo.Location = new System.Drawing.Point(505, 45);
            this.rtbTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbTo.Name = "rtbTo";
            this.rtbTo.ReadOnly = true;
            this.rtbTo.Size = new System.Drawing.Size(496, 453);
            this.rtbTo.TabIndex = 1;
            this.rtbTo.Text = "";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(3, 6);
            this.btnTranslate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(30, 44);
            this.btnTranslate.TabIndex = 2;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Dictionary.Properties.Resources.volume_up_interface_symbol;
            this.pictureBox1.Location = new System.Drawing.Point(19, 76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnTranslate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1007, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 451);
            this.panel1.TabIndex = 7;
            // 
            // Translate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Translate";
            this.Size = new System.Drawing.Size(1074, 500);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.RichTextBox rtbTo;
        private System.Windows.Forms.RichTextBox rtbFrom;
    }
}
