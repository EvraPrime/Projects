
namespace Dictionary.Control
{
    partial class HistoryItem
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
            this.lbl_Act = new System.Windows.Forms.Label();
            this.lbl_Word = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Act
            // 
            this.lbl_Act.AutoSize = true;
            this.lbl_Act.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Act.Location = new System.Drawing.Point(23, 20);
            this.lbl_Act.Name = "lbl_Act";
            this.lbl_Act.Size = new System.Drawing.Size(46, 17);
            this.lbl_Act.TabIndex = 0;
            this.lbl_Act.Text = "label1";
            // 
            // lbl_Word
            // 
            this.lbl_Word.AutoSize = true;
            this.lbl_Word.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Word.Location = new System.Drawing.Point(102, 19);
            this.lbl_Word.Name = "lbl_Word";
            this.lbl_Word.Size = new System.Drawing.Size(46, 17);
            this.lbl_Word.TabIndex = 1;
            this.lbl_Word.Text = "label2";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Location = new System.Drawing.Point(709, 43);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(46, 17);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "label3";
            // 
            // HistoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Word);
            this.Controls.Add(this.lbl_Act);
            this.Name = "HistoryItem";
            this.Size = new System.Drawing.Size(922, 65);
            this.Click += new System.EventHandler(this.HistoryItem_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Act;
        private System.Windows.Forms.Label lbl_Word;
        private System.Windows.Forms.Label lbl_Date;
    }
}
