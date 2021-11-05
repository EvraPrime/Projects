
namespace OnlineShop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Statis = new System.Windows.Forms.Button();
            this.pic_Settings = new System.Windows.Forms.PictureBox();
            this.lbl_Settings = new System.Windows.Forms.Label();
            this.btn_History = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.home = new OnlineShop.Home();
            this.settings = new OnlineShop.Settings();
            this.history = new OnlineShop.History();
            this.statis = new OnlineShop.Statis();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(237, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 37);
            this.panel1.TabIndex = 3;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = global::OnlineShop.Properties.Resources.Exit;
            this.btn_Close.Location = new System.Drawing.Point(1042, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(54, 37);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.btn_Statis);
            this.panel2.Controls.Add(this.pic_Settings);
            this.panel2.Controls.Add(this.lbl_Settings);
            this.panel2.Controls.Add(this.btn_History);
            this.panel2.Controls.Add(this.btn_Home);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 615);
            this.panel2.TabIndex = 4;
            // 
            // btn_Statis
            // 
            this.btn_Statis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Statis.BackColor = System.Drawing.Color.White;
            this.btn_Statis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Statis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Statis.Image = global::OnlineShop.Properties.Resources.bar_graph;
            this.btn_Statis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Statis.Location = new System.Drawing.Point(0, 355);
            this.btn_Statis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Statis.Name = "btn_Statis";
            this.btn_Statis.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Statis.Size = new System.Drawing.Size(237, 50);
            this.btn_Statis.TabIndex = 7;
            this.btn_Statis.Text = "Statis";
            this.btn_Statis.UseVisualStyleBackColor = false;
            this.btn_Statis.Click += new System.EventHandler(this.btn_Statis_Click);
            // 
            // pic_Settings
            // 
            this.pic_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_Settings.BackColor = System.Drawing.Color.Transparent;
            this.pic_Settings.Image = global::OnlineShop.Properties.Resources.gear;
            this.pic_Settings.Location = new System.Drawing.Point(13, 547);
            this.pic_Settings.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Settings.Name = "pic_Settings";
            this.pic_Settings.Size = new System.Drawing.Size(53, 49);
            this.pic_Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Settings.TabIndex = 6;
            this.pic_Settings.TabStop = false;
            this.pic_Settings.Click += new System.EventHandler(this.pic_Settings_Click);
            // 
            // lbl_Settings
            // 
            this.lbl_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Settings.AutoSize = true;
            this.lbl_Settings.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Settings.Location = new System.Drawing.Point(83, 560);
            this.lbl_Settings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Settings.Name = "lbl_Settings";
            this.lbl_Settings.Size = new System.Drawing.Size(88, 24);
            this.lbl_Settings.TabIndex = 5;
            this.lbl_Settings.Text = "Settings";
            this.lbl_Settings.Click += new System.EventHandler(this.pic_Settings_Click);
            // 
            // btn_History
            // 
            this.btn_History.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_History.BackColor = System.Drawing.Color.White;
            this.btn_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_History.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_History.Image = global::OnlineShop.Properties.Resources.to_do_list;
            this.btn_History.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_History.Location = new System.Drawing.Point(0, 287);
            this.btn_History.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_History.Name = "btn_History";
            this.btn_History.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_History.Size = new System.Drawing.Size(237, 50);
            this.btn_History.TabIndex = 4;
            this.btn_History.Text = "History";
            this.btn_History.UseVisualStyleBackColor = false;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Home.BackColor = System.Drawing.Color.White;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Image = global::OnlineShop.Properties.Resources.home;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(0, 219);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Home.Size = new System.Drawing.Size(237, 50);
            this.btn_Home.TabIndex = 2;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "FaTech";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OnlineShop.Properties.Resources.fast_delivery;
            this.pictureBox1.Location = new System.Drawing.Point(40, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // home
            // 
            this.home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home.Location = new System.Drawing.Point(237, 37);
            this.home.Margin = new System.Windows.Forms.Padding(5);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(1096, 578);
            this.home.TabIndex = 6;
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.White;
            this.settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings.Location = new System.Drawing.Point(0, 0);
            this.settings.Margin = new System.Windows.Forms.Padding(5);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(1333, 615);
            this.settings.TabIndex = 5;
            // 
            // history
            // 
            this.history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history.Location = new System.Drawing.Point(0, 0);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(1333, 615);
            this.history.TabIndex = 7;
            // 
            // statis
            // 
            this.statis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statis.Location = new System.Drawing.Point(0, 0);
            this.statis.Name = "statis";
            this.statis.Size = new System.Drawing.Size(1333, 615);
            this.statis.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 615);
            this.Controls.Add(this.home);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.history);
            this.Controls.Add(this.statis);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_Settings;
        private System.Windows.Forms.Label lbl_Settings;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.Button btn_Home;
        private Settings settings;
        private Home home;
        private System.Windows.Forms.Button btn_Statis;
        private History history;
        private Statis statis;
    }
}

