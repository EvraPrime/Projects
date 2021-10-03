
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
            this.lbl_Home = new System.Windows.Forms.Label();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.lbl_Activity = new System.Windows.Forms.Label();
            this.pic_Home = new System.Windows.Forms.PictureBox();
            this.pic_Activity = new System.Windows.Forms.PictureBox();
            this.pic_Message = new System.Windows.Forms.PictureBox();
            this.pic_Account = new System.Windows.Forms.PictureBox();
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
            this.pan_Control.Location = new System.Drawing.Point(0, 652);
            this.pan_Control.Name = "pan_Control";
            this.pan_Control.RowCount = 2;
            this.pan_Control.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pan_Control.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.pan_Control.Size = new System.Drawing.Size(569, 94);
            this.pan_Control.TabIndex = 1;
            // 
            // lbl_Home
            // 
            this.lbl_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Home.AutoSize = true;
            this.lbl_Home.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.ForeColor = System.Drawing.Color.Black;
            this.lbl_Home.Location = new System.Drawing.Point(46, 71);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(49, 23);
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
            this.lbl_Account.Location = new System.Drawing.Point(464, 71);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(66, 23);
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
            this.lbl_Message.Location = new System.Drawing.Point(319, 71);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(72, 23);
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
            this.lbl_Activity.Location = new System.Drawing.Point(183, 71);
            this.lbl_Activity.Name = "lbl_Activity";
            this.lbl_Activity.Size = new System.Drawing.Size(60, 23);
            this.lbl_Activity.TabIndex = 10;
            this.lbl_Activity.Text = "Activity";
            this.lbl_Activity.Click += new System.EventHandler(this.lbl_Activity_Click);
            // 
            // pic_Home
            // 
            this.pic_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pic_Home.BackColor = System.Drawing.Color.Transparent;
            this.pic_Home.Image = ((System.Drawing.Image)(resources.GetObject("pic_Home.Image")));
            this.pic_Home.Location = new System.Drawing.Point(25, 3);
            this.pic_Home.Name = "pic_Home";
            this.pic_Home.Size = new System.Drawing.Size(91, 65);
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
            this.pic_Activity.Location = new System.Drawing.Point(167, 3);
            this.pic_Activity.Name = "pic_Activity";
            this.pic_Activity.Size = new System.Drawing.Size(91, 65);
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
            this.pic_Message.Location = new System.Drawing.Point(309, 3);
            this.pic_Message.Name = "pic_Message";
            this.pic_Message.Size = new System.Drawing.Size(91, 65);
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
            this.pic_Account.Location = new System.Drawing.Point(452, 3);
            this.pic_Account.Name = "pic_Account";
            this.pic_Account.Size = new System.Drawing.Size(91, 65);
            this.pic_Account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Account.TabIndex = 7;
            this.pic_Account.TabStop = false;
            this.pic_Account.Click += new System.EventHandler(this.pic_Account_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(569, 746);
            this.Controls.Add(this.pan_Control);
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
    }
}

