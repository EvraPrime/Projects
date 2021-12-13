
namespace Dictionary
{
    partial class History
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
            this.pan_Content = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pan_Content
            // 
            this.pan_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Content.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pan_Content.Location = new System.Drawing.Point(0, 0);
            this.pan_Content.Name = "pan_Content";
            this.pan_Content.Padding = new System.Windows.Forms.Padding(10);
            this.pan_Content.Size = new System.Drawing.Size(863, 454);
            this.pan_Content.TabIndex = 0;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pan_Content);
            this.Name = "History";
            this.Size = new System.Drawing.Size(863, 454);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pan_Content;
    }
}
