
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGame = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panContent = new System.Windows.Forms.Panel();
            this.translate = new Dictionary.Translate();
            this.search = new Dictionary.Search();
            this.game = new Dictionary.Game();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 41);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(844, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGame);
            this.panel2.Controls.Add(this.btnTranslate);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 490);
            this.panel2.TabIndex = 1;
            // 
            // btnGame
            // 
            this.btnGame.Location = new System.Drawing.Point(32, 338);
            this.btnGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(94, 41);
            this.btnGame.TabIndex = 3;
            this.btnGame.Text = "Game";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(32, 272);
            this.btnTranslate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(94, 41);
            this.btnTranslate.TabIndex = 2;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(32, 208);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 41);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dictionary.Properties.Resources.dictionary;
            this.pictureBox1.Location = new System.Drawing.Point(32, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panContent
            // 
            this.panContent.AutoSize = true;
            this.panContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panContent.Controls.Add(this.translate);
            this.panContent.Controls.Add(this.search);
            this.panContent.Controls.Add(this.game);
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(150, 41);
            this.panContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(794, 490);
            this.panContent.TabIndex = 2;
            // 
            // translate
            // 
            this.translate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.translate.Location = new System.Drawing.Point(0, 0);
            this.translate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.translate.Name = "translate";
            this.translate.Size = new System.Drawing.Size(792, 488);
            this.translate.TabIndex = 1;
            // 
            // search
            // 
            this.search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search.Location = new System.Drawing.Point(0, 0);
            this.search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(792, 488);
            this.search.TabIndex = 0;
            // 
            // game
            // 
            this.game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.game.Location = new System.Drawing.Point(0, 0);
            this.game.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(792, 488);
            this.game.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 531);
            this.Controls.Add(this.panContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panContent;
        private Search search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnSearch;
        private Translate translate;
        private Game game;
    }
}

