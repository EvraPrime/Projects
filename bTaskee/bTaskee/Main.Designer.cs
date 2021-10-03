
namespace bTaskee
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
            this.pan_Control = new System.Windows.Forms.TableLayoutPanel();
            this.pic_Home = new System.Windows.Forms.PictureBox();
            this.pic_Activity = new System.Windows.Forms.PictureBox();
            this.pic_Message = new System.Windows.Forms.PictureBox();
            this.pic_Account = new System.Windows.Forms.PictureBox();
            this.lbl_Home = new System.Windows.Forms.Label();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.lbl_Activity = new System.Windows.Forms.Label();
            this.home1 = new bTaskee.Home();
            this.activity1 = new bTaskee.Activity();
            this.message1 = new bTaskee.Message();
            this.account1 = new bTaskee.Account();
            this.pan_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Activity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Message)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Account)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_Control
            // 
            this.pan_Control.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pan_Control.ColumnCount = 4;
            this.pan_Control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pan_Control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pan_Control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pan_Control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pan_Control.Controls.Add(this.pic_Home, 0, 0);
            this.pan_Control.Controls.Add(this.pic_Activity, 1, 0);
            this.pan_Control.Controls.Add(this.pic_Message, 2, 0);
            this.pan_Control.Controls.Add(this.pic_Account, 3, 0);
            this.pan_Control.Controls.Add(this.lbl_Home, 0, 1);
            this.pan_Control.Controls.Add(this.lbl_Account, 3, 1);
            this.pan_Control.Controls.Add(this.lbl_Message, 2, 1);
            this.pan_Control.Controls.Add(this.lbl_Activity, 1, 1);
            this.pan_Control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_Control.Location = new System.Drawing.Point(0, 525);
            this.pan_Control.Margin = new System.Windows.Forms.Padding(2);
            this.pan_Control.Name = "pan_Control";
            this.pan_Control.RowCount = 2;
            this.pan_Control.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pan_Control.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.pan_Control.Size = new System.Drawing.Size(324, 76);
            this.pan_Control.TabIndex = 1;
            // 
            // pic_Home
            // 
            this.pic_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pic_Home.BackColor = System.Drawing.Color.Transparent;
            this.pic_Home.Image = ((System.Drawing.Image)(resources.GetObject("pic_Home.Image")));
            this.pic_Home.Location = new System.Drawing.Point(6, 2);
            this.pic_Home.Margin = new System.Windows.Forms.Padding(2);
            this.pic_Home.Name = "pic_Home";
            this.pic_Home.Size = new System.Drawing.Size(68, 53);
            this.pic_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Home.TabIndex = 4;
            this.pic_Home.TabStop = false;
            this.pic_Home.Click += new System.EventHandler(this.pic_Home_Click);
            // 
            // pic_Activity
            // 
            this.pic_Activity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pic_Activity.BackColor = System.Drawing.Color.Transparent;
            this.pic_Activity.Image = global::bTaskee.Properties.Resources.activity;
            this.pic_Activity.Location = new System.Drawing.Point(87, 2);
            this.pic_Activity.Margin = new System.Windows.Forms.Padding(2);
            this.pic_Activity.Name = "pic_Activity";
            this.pic_Activity.Size = new System.Drawing.Size(68, 53);
            this.pic_Activity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Activity.TabIndex = 5;
            this.pic_Activity.TabStop = false;
            this.pic_Activity.Click += new System.EventHandler(this.pic_Activity_Click);
            // 
            // pic_Message
            // 
            this.pic_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pic_Message.BackColor = System.Drawing.Color.Transparent;
            this.pic_Message.Image = global::bTaskee.Properties.Resources.bell;
            this.pic_Message.Location = new System.Drawing.Point(168, 2);
            this.pic_Message.Margin = new System.Windows.Forms.Padding(2);
            this.pic_Message.Name = "pic_Message";
            this.pic_Message.Size = new System.Drawing.Size(68, 53);
            this.pic_Message.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Message.TabIndex = 6;
            this.pic_Message.TabStop = false;
            this.pic_Message.Click += new System.EventHandler(this.pic_Message_Click);
            // 
            // pic_Account
            // 
            this.pic_Account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pic_Account.BackColor = System.Drawing.Color.Transparent;
            this.pic_Account.Image = global::bTaskee.Properties.Resources.user;
            this.pic_Account.Location = new System.Drawing.Point(249, 2);
            this.pic_Account.Margin = new System.Windows.Forms.Padding(2);
            this.pic_Account.Name = "pic_Account";
            this.pic_Account.Size = new System.Drawing.Size(68, 53);
            this.pic_Account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Account.TabIndex = 7;
            this.pic_Account.TabStop = false;
            this.pic_Account.Click += new System.EventHandler(this.pic_Account_Click);
            // 
            // lbl_Home
            // 
            this.lbl_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Home.AutoSize = true;
            this.lbl_Home.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.ForeColor = System.Drawing.Color.Black;
            this.lbl_Home.Location = new System.Drawing.Point(21, 57);
            this.lbl_Home.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(39, 19);
            this.lbl_Home.TabIndex = 2;
            this.lbl_Home.Text = "Home";
            this.lbl_Home.Click += new System.EventHandler(this.lbl_Home_Click);
            // 
            // lbl_Account
            // 
            this.lbl_Account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Account.ForeColor = System.Drawing.Color.Black;
            this.lbl_Account.Location = new System.Drawing.Point(256, 57);
            this.lbl_Account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(54, 19);
            this.lbl_Account.TabIndex = 8;
            this.lbl_Account.Text = "Account";
            this.lbl_Account.Click += new System.EventHandler(this.lbl_Account_Click);
            // 
            // lbl_Message
            // 
            this.lbl_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.ForeColor = System.Drawing.Color.Black;
            this.lbl_Message.Location = new System.Drawing.Point(174, 57);
            this.lbl_Message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(57, 19);
            this.lbl_Message.TabIndex = 9;
            this.lbl_Message.Text = "Message";
            this.lbl_Message.Click += new System.EventHandler(this.lbl_Message_Click);
            // 
            // lbl_Activity
            // 
            this.lbl_Activity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Activity.AutoSize = true;
            this.lbl_Activity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Activity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Activity.ForeColor = System.Drawing.Color.Black;
            this.lbl_Activity.Location = new System.Drawing.Point(97, 57);
            this.lbl_Activity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Activity.Name = "lbl_Activity";
            this.lbl_Activity.Size = new System.Drawing.Size(49, 19);
            this.lbl_Activity.TabIndex = 10;
            this.lbl_Activity.Text = "Activity";
            this.lbl_Activity.Click += new System.EventHandler(this.lbl_Activity_Click);
            // 
            // home1
            // 
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Margin = new System.Windows.Forms.Padding(0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(324, 601);
            this.home1.TabIndex = 5;
            // 
            // activity1
            // 
            this.activity1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activity1.Location = new System.Drawing.Point(0, 0);
            this.activity1.Name = "activity1";
            this.activity1.Size = new System.Drawing.Size(324, 601);
            this.activity1.TabIndex = 4;
            // 
            // message1
            // 
            this.message1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.message1.Location = new System.Drawing.Point(0, 0);
            this.message1.Margin = new System.Windows.Forms.Padding(2);
            this.message1.Name = "message1";
            this.message1.Size = new System.Drawing.Size(324, 601);
            this.message1.TabIndex = 2;
            // 
            // account1
            // 
            this.account1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.account1.Location = new System.Drawing.Point(0, 0);
            this.account1.Name = "account1";
            this.account1.Size = new System.Drawing.Size(324, 601);
            this.account1.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(324, 601);
            this.Controls.Add(this.pan_Control);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.activity1);
            this.Controls.Add(this.message1);
            this.Controls.Add(this.account1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(340, 640);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bTaskee";
            this.pan_Control.ResumeLayout(false);
            this.pan_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Activity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Message)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Account)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pan_Control;
        private System.Windows.Forms.Label lbl_Home;
        private System.Windows.Forms.PictureBox pic_Home;
        private System.Windows.Forms.PictureBox pic_Activity;
        private System.Windows.Forms.PictureBox pic_Message;
        private System.Windows.Forms.PictureBox pic_Account;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Label lbl_Activity;
        private Message message1;
        private Account account1;
        private Activity activity1;
        private Home home1;
    }
}

