
namespace bTaskee
{
    partial class Account
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Profile = new System.Windows.Forms.Label();
            this.pic_Profile = new bTaskee.OvalPictureBox(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pic_Profile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_Profile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 94);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(103, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "View profile >";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Profile
            // 
            this.lbl_Profile.AutoSize = true;
            this.lbl_Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Profile.Location = new System.Drawing.Point(103, 26);
            this.lbl_Profile.Name = "lbl_Profile";
            this.lbl_Profile.Size = new System.Drawing.Size(111, 17);
            this.lbl_Profile.TabIndex = 1;
            this.lbl_Profile.Text = "Nguyen Van A";
            this.lbl_Profile.Click += new System.EventHandler(this.lbl_Profile_Click);
            // 
            // pic_Profile
            // 
            this.pic_Profile.BackColor = System.Drawing.Color.White;
            this.pic_Profile.Image = global::bTaskee.Properties.Resources.profile_pic;
            this.pic_Profile.Location = new System.Drawing.Point(28, 21);
            this.pic_Profile.Name = "pic_Profile";
            this.pic_Profile.Size = new System.Drawing.Size(50, 50);
            this.pic_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Profile.TabIndex = 3;
            this.pic_Profile.TabStop = false;
            this.pic_Profile.Click += new System.EventHandler(this.pic_Profile_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Account";
            this.Size = new System.Drawing.Size(291, 447);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Profile;
        private System.Windows.Forms.Label label1;
        private OvalPictureBox pic_Profile;
    }
}
