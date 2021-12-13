
namespace Dictionary.Control
{
    partial class TranslateView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbFrom = new System.Windows.Forms.RichTextBox();
            this.rtbTo = new System.Windows.Forms.RichTextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pic_Speak = new System.Windows.Forms.PictureBox();
            this.pic_Favourite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Speak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Favourite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiếng Việt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiếng Anh";
            // 
            // rtbFrom
            // 
            this.rtbFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbFrom.Location = new System.Drawing.Point(19, 36);
            this.rtbFrom.Margin = new System.Windows.Forms.Padding(10);
            this.rtbFrom.Name = "rtbFrom";
            this.rtbFrom.ReadOnly = true;
            this.rtbFrom.Size = new System.Drawing.Size(626, 163);
            this.rtbFrom.TabIndex = 3;
            this.rtbFrom.Text = "";
            // 
            // rtbTo
            // 
            this.rtbTo.Location = new System.Drawing.Point(19, 243);
            this.rtbTo.Margin = new System.Windows.Forms.Padding(10);
            this.rtbTo.Name = "rtbTo";
            this.rtbTo.ReadOnly = true;
            this.rtbTo.Size = new System.Drawing.Size(626, 168);
            this.rtbTo.TabIndex = 4;
            this.rtbTo.Text = "";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Image = global::Dictionary.Properties.Resources.close__1_;
            this.btn_Exit.Location = new System.Drawing.Point(675, 1);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(54, 34);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pic_Speak
            // 
            this.pic_Speak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Speak.BackColor = System.Drawing.Color.Transparent;
            this.pic_Speak.Image = global::Dictionary.Properties.Resources.volume_up_interface_symbol;
            this.pic_Speak.Location = new System.Drawing.Point(658, 291);
            this.pic_Speak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_Speak.Name = "pic_Speak";
            this.pic_Speak.Size = new System.Drawing.Size(30, 30);
            this.pic_Speak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Speak.TabIndex = 6;
            this.pic_Speak.TabStop = false;
            this.pic_Speak.Click += new System.EventHandler(this.pic_Speak_Click);
            // 
            // pic_Favourite
            // 
            this.pic_Favourite.BackColor = System.Drawing.Color.Transparent;
            this.pic_Favourite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Favourite.Image = global::Dictionary.Properties.Resources.star;
            this.pic_Favourite.Location = new System.Drawing.Point(658, 243);
            this.pic_Favourite.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Favourite.Name = "pic_Favourite";
            this.pic_Favourite.Size = new System.Drawing.Size(33, 30);
            this.pic_Favourite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Favourite.TabIndex = 12;
            this.pic_Favourite.TabStop = false;
            this.pic_Favourite.Click += new System.EventHandler(this.pic_Favourite_Click);
            // 
            // TranslateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 448);
            this.Controls.Add(this.pic_Favourite);
            this.Controls.Add(this.pic_Speak);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.rtbTo);
            this.Controls.Add(this.rtbFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TranslateView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TranslateView";
            this.Load += new System.EventHandler(this.TranslateView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Speak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Favourite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbFrom;
        private System.Windows.Forms.RichTextBox rtbTo;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox pic_Speak;
        private System.Windows.Forms.PictureBox pic_Favourite;
    }
}