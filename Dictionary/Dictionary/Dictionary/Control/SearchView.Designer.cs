
namespace Dictionary.Control
{
    partial class SearchView
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pan_View = new System.Windows.Forms.Panel();
            this.pic_Favourite = new System.Windows.Forms.PictureBox();
            this.pan_Content = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Word = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pan_View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Favourite)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Image = global::Dictionary.Properties.Resources.close__1_;
            this.btn_Exit.Location = new System.Drawing.Point(1011, 0);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(69, 42);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Word);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 42);
            this.panel1.TabIndex = 5;
            // 
            // pan_View
            // 
            this.pan_View.AutoScroll = true;
            this.pan_View.BackColor = System.Drawing.Color.DarkGray;
            this.pan_View.Controls.Add(this.pic_Favourite);
            this.pan_View.Controls.Add(this.pan_Content);
            this.pan_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_View.Location = new System.Drawing.Point(0, 42);
            this.pan_View.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_View.Name = "pan_View";
            this.pan_View.Padding = new System.Windows.Forms.Padding(11, 10, 11, 50);
            this.pan_View.Size = new System.Drawing.Size(1080, 577);
            this.pan_View.TabIndex = 6;
            // 
            // pic_Favourite
            // 
            this.pic_Favourite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Favourite.BackColor = System.Drawing.Color.Transparent;
            this.pic_Favourite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Favourite.Image = global::Dictionary.Properties.Resources.star;
            this.pic_Favourite.Location = new System.Drawing.Point(1040, 10);
            this.pic_Favourite.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Favourite.Name = "pic_Favourite";
            this.pic_Favourite.Size = new System.Drawing.Size(26, 24);
            this.pic_Favourite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Favourite.TabIndex = 3;
            this.pic_Favourite.TabStop = false;
            // 
            // pan_Content
            // 
            this.pan_Content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_Content.AutoSize = true;
            this.pan_Content.BackColor = System.Drawing.Color.Transparent;
            this.pan_Content.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pan_Content.Location = new System.Drawing.Point(13, 41);
            this.pan_Content.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_Content.Name = "pan_Content";
            this.pan_Content.Size = new System.Drawing.Size(1054, 444);
            this.pan_Content.TabIndex = 2;
            // 
            // lbl_Word
            // 
            this.lbl_Word.AutoSize = true;
            this.lbl_Word.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Word.Location = new System.Drawing.Point(13, 13);
            this.lbl_Word.Name = "lbl_Word";
            this.lbl_Word.Size = new System.Drawing.Size(54, 19);
            this.lbl_Word.TabIndex = 5;
            this.lbl_Word.Text = "label1";
            // 
            // SearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 619);
            this.Controls.Add(this.pan_View);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pan_View.ResumeLayout(false);
            this.pan_View.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Favourite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pan_View;
        private System.Windows.Forms.PictureBox pic_Favourite;
        private System.Windows.Forms.FlowLayoutPanel pan_Content;
        private System.Windows.Forms.Label lbl_Word;
    }
}