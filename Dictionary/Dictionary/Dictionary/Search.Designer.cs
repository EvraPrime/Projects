﻿
namespace Dictionary
{
    partial class Search
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
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.pan_Content = new System.Windows.Forms.FlowLayoutPanel();
            this.pan_View = new System.Windows.Forms.Panel();
            this.pic_Speak = new System.Windows.Forms.PictureBox();
            this.pic_Favourite = new System.Windows.Forms.PictureBox();
            this.pan_View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Speak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Favourite)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(74, 24);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(222, 23);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_txt_KeyDown);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(310, 20);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(81, 30);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // pan_Content
            // 
            this.pan_Content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_Content.AutoSize = true;
            this.pan_Content.BackColor = System.Drawing.Color.Transparent;
            this.pan_Content.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pan_Content.Location = new System.Drawing.Point(10, 33);
            this.pan_Content.Margin = new System.Windows.Forms.Padding(2);
            this.pan_Content.Name = "pan_Content";
            this.pan_Content.Size = new System.Drawing.Size(683, 361);
            this.pan_Content.TabIndex = 2;
            // 
            // pan_View
            // 
            this.pan_View.AutoScroll = true;
            this.pan_View.BackColor = System.Drawing.Color.DarkGray;
            this.pan_View.Controls.Add(this.pic_Favourite);
            this.pan_View.Controls.Add(this.pan_Content);
            this.pan_View.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_View.Location = new System.Drawing.Point(0, 113);
            this.pan_View.Margin = new System.Windows.Forms.Padding(2);
            this.pan_View.Name = "pan_View";
            this.pan_View.Padding = new System.Windows.Forms.Padding(8, 8, 8, 41);
            this.pan_View.Size = new System.Drawing.Size(703, 441);
            this.pan_View.TabIndex = 3;
            // 
            // pic_Speak
            // 
            this.pic_Speak.BackColor = System.Drawing.Color.Transparent;
            this.pic_Speak.Image = global::Dictionary.Properties.Resources.volume_up_interface_symbol;
            this.pic_Speak.Location = new System.Drawing.Point(10, 15);
            this.pic_Speak.Margin = new System.Windows.Forms.Padding(2);
            this.pic_Speak.Name = "pic_Speak";
            this.pic_Speak.Size = new System.Drawing.Size(60, 41);
            this.pic_Speak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Speak.TabIndex = 4;
            this.pic_Speak.TabStop = false;
            this.pic_Speak.Click += new System.EventHandler(this.pic_Speak_Click);
            // 
            // pic_Favourite
            // 
            this.pic_Favourite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Favourite.BackColor = System.Drawing.Color.Transparent;
            this.pic_Favourite.Location = new System.Drawing.Point(668, 5);
            this.pic_Favourite.Name = "pic_Favourite";
            this.pic_Favourite.Size = new System.Drawing.Size(25, 25);
            this.pic_Favourite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Favourite.TabIndex = 3;
            this.pic_Favourite.TabStop = false;
            this.pic_Favourite.Click += new System.EventHandler(this.pic_Favourite_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_Speak);
            this.Controls.Add(this.pan_View);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Search";
            this.Size = new System.Drawing.Size(703, 554);
            this.pan_View.ResumeLayout(false);
            this.pan_View.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Speak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Favourite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.FlowLayoutPanel pan_Content;
        private System.Windows.Forms.Panel pan_View;
        private System.Windows.Forms.PictureBox pic_Speak;
        private System.Windows.Forms.PictureBox pic_Favourite;
    }
}
