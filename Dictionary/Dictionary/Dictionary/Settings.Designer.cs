
namespace Dictionary
{
    partial class Settings
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
            this.pic_Red = new System.Windows.Forms.PictureBox();
            this.pic_Yellow = new System.Windows.Forms.PictureBox();
            this.pic_Cyan = new System.Windows.Forms.PictureBox();
            this.pic_Green = new System.Windows.Forms.PictureBox();
            this.pic_Purple = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cyan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Purple)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Red
            // 
            this.pic_Red.BackColor = System.Drawing.Color.Red;
            this.pic_Red.Location = new System.Drawing.Point(84, 78);
            this.pic_Red.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_Red.Name = "pic_Red";
            this.pic_Red.Size = new System.Drawing.Size(67, 62);
            this.pic_Red.TabIndex = 0;
            this.pic_Red.TabStop = false;
            this.pic_Red.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_Yellow
            // 
            this.pic_Yellow.BackColor = System.Drawing.Color.Yellow;
            this.pic_Yellow.Location = new System.Drawing.Point(377, 78);
            this.pic_Yellow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_Yellow.Name = "pic_Yellow";
            this.pic_Yellow.Size = new System.Drawing.Size(67, 62);
            this.pic_Yellow.TabIndex = 1;
            this.pic_Yellow.TabStop = false;
            this.pic_Yellow.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_Cyan
            // 
            this.pic_Cyan.BackColor = System.Drawing.Color.Cyan;
            this.pic_Cyan.Location = new System.Drawing.Point(231, 78);
            this.pic_Cyan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_Cyan.Name = "pic_Cyan";
            this.pic_Cyan.Size = new System.Drawing.Size(67, 62);
            this.pic_Cyan.TabIndex = 2;
            this.pic_Cyan.TabStop = false;
            this.pic_Cyan.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_Green
            // 
            this.pic_Green.BackColor = System.Drawing.Color.Lime;
            this.pic_Green.Location = new System.Drawing.Point(524, 78);
            this.pic_Green.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_Green.Name = "pic_Green";
            this.pic_Green.Size = new System.Drawing.Size(67, 62);
            this.pic_Green.TabIndex = 3;
            this.pic_Green.TabStop = false;
            this.pic_Green.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_Purple
            // 
            this.pic_Purple.BackColor = System.Drawing.Color.Purple;
            this.pic_Purple.Location = new System.Drawing.Point(671, 78);
            this.pic_Purple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_Purple.Name = "pic_Purple";
            this.pic_Purple.Size = new System.Drawing.Size(67, 62);
            this.pic_Purple.TabIndex = 4;
            this.pic_Purple.TabStop = false;
            this.pic_Purple.Click += new System.EventHandler(this.pic_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_Purple);
            this.Controls.Add(this.pic_Green);
            this.Controls.Add(this.pic_Cyan);
            this.Controls.Add(this.pic_Yellow);
            this.Controls.Add(this.pic_Red);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(893, 439);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cyan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Purple)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Red;
        private System.Windows.Forms.PictureBox pic_Yellow;
        private System.Windows.Forms.PictureBox pic_Cyan;
        private System.Windows.Forms.PictureBox pic_Green;
        private System.Windows.Forms.PictureBox pic_Purple;
    }
}
