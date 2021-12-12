
namespace Dictionary
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pan_Navigation = new System.Windows.Forms.Panel();
            this.btn_Game = new System.Windows.Forms.Button();
            this.btn_Translate = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.pic_Image = new System.Windows.Forms.PictureBox();
            this.pan_Content = new System.Windows.Forms.Panel();
            this.translate = new Dictionary.Translate();
            this.search = new Dictionary.Search();
            this.game = new Dictionary.Game();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pan_Title = new System.Windows.Forms.Panel();
            this.pic_Icon = new System.Windows.Forms.PictureBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pan_Navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).BeginInit();
            this.pan_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_Navigation
            // 
            this.pan_Navigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pan_Navigation.Controls.Add(this.btn_Game);
            this.pan_Navigation.Controls.Add(this.btn_Translate);
            this.pan_Navigation.Controls.Add(this.btn_Search);
            this.pan_Navigation.Controls.Add(this.pic_Image);
            this.pan_Navigation.Location = new System.Drawing.Point(1, 32);
            this.pan_Navigation.Margin = new System.Windows.Forms.Padding(1, 24, 2, 1);
            this.pan_Navigation.Name = "pan_Navigation";
            this.pan_Navigation.Size = new System.Drawing.Size(156, 505);
            this.pan_Navigation.TabIndex = 1;
            // 
            // btn_Game
            // 
            this.btn_Game.Location = new System.Drawing.Point(32, 338);
            this.btn_Game.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Game.Name = "btn_Game";
            this.btn_Game.Size = new System.Drawing.Size(94, 41);
            this.btn_Game.TabIndex = 3;
            this.btn_Game.Text = "Game";
            this.btn_Game.UseVisualStyleBackColor = true;
            this.btn_Game.Click += new System.EventHandler(this.btn_Game_Click);
            // 
            // btn_Translate
            // 
            this.btn_Translate.Location = new System.Drawing.Point(32, 272);
            this.btn_Translate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Translate.Name = "btn_Translate";
            this.btn_Translate.Size = new System.Drawing.Size(94, 41);
            this.btn_Translate.TabIndex = 2;
            this.btn_Translate.Text = "Translate";
            this.btn_Translate.UseVisualStyleBackColor = true;
            this.btn_Translate.Click += new System.EventHandler(this.btn_Translate_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(8, 180);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(94, 41);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // pic_Image
            // 
            this.pic_Image.BackColor = System.Drawing.Color.Transparent;
            this.pic_Image.Image = global::Dictionary.Properties.Resources.dictionary;
            this.pic_Image.Location = new System.Drawing.Point(32, 21);
            this.pic_Image.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_Image.Name = "pic_Image";
            this.pic_Image.Size = new System.Drawing.Size(82, 76);
            this.pic_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Image.TabIndex = 0;
            this.pic_Image.TabStop = false;
            // 
            // pan_Content
            // 
            this.pan_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_Content.AutoScroll = true;
            this.pan_Content.AutoSize = true;
            this.pan_Content.Controls.Add(this.translate);
            this.pan_Content.Controls.Add(this.search);
            this.pan_Content.Controls.Add(this.game);
            this.pan_Content.Location = new System.Drawing.Point(157, 68);
            this.pan_Content.Margin = new System.Windows.Forms.Padding(0, 24, 1, 1);
            this.pan_Content.Name = "pan_Content";
            this.pan_Content.Size = new System.Drawing.Size(730, 468);
            this.pan_Content.TabIndex = 2;
            // 
            // translate
            // 
            this.translate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.translate.Location = new System.Drawing.Point(0, 0);
            this.translate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.translate.MinimumSize = new System.Drawing.Size(600, 406);
            this.translate.Name = "translate";
            this.translate.Size = new System.Drawing.Size(730, 468);
            this.translate.TabIndex = 3;
            // 
            // search
            // 
            this.search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search.Location = new System.Drawing.Point(0, 0);
            this.search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(730, 468);
            this.search.TabIndex = 0;
            // 
            // game
            // 
            this.game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.game.Location = new System.Drawing.Point(0, 0);
            this.game.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(730, 468);
            this.game.TabIndex = 2;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(836, -1);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(52, 34);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "button1";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pan_Title
            // 
            this.pan_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_Title.Location = new System.Drawing.Point(157, 32);
            this.pan_Title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pan_Title.Name = "pan_Title";
            this.pan_Title.Size = new System.Drawing.Size(730, 36);
            this.pan_Title.TabIndex = 4;
            // 
            // pic_Icon
            // 
            this.pic_Icon.BackColor = System.Drawing.Color.Transparent;
            this.pic_Icon.Image = global::Dictionary.Properties.Resources.dictionary;
            this.pic_Icon.Location = new System.Drawing.Point(5, 3);
            this.pic_Icon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_Icon.Name = "pic_Icon";
            this.pic_Icon.Size = new System.Drawing.Size(24, 26);
            this.pic_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Icon.TabIndex = 4;
            this.pic_Icon.TabStop = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Name.Location = new System.Drawing.Point(34, 8);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(123, 16);
            this.lbl_Name.TabIndex = 5;
            this.lbl_Name.Text = "Từ điển Anh-Việt";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(783, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(730, -1);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 537);
            this.Controls.Add(this.pan_Title);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.pic_Icon);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.pan_Content);
            this.Controls.Add(this.pan_Navigation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(904, 576);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pan_Navigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).EndInit();
            this.pan_Content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pan_Navigation;
        private System.Windows.Forms.Panel pan_Content;
        private Search search;
        private System.Windows.Forms.PictureBox pic_Image;
        private System.Windows.Forms.Button btn_Game;
        private System.Windows.Forms.Button btn_Translate;
        private System.Windows.Forms.Button btn_Search;
        private Game game;
        private System.Windows.Forms.Button btn_Exit;
        private Translate translate;
        private System.Windows.Forms.Panel pan_Title;
        private System.Windows.Forms.PictureBox pic_Icon;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

