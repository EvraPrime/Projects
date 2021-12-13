
namespace Dictionary
{
    partial class Favourite
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Translate = new System.Windows.Forms.Button();
            this.pan_Search = new System.Windows.Forms.FlowLayoutPanel();
            this.pan_Translate = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 68);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Search, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Translate, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(870, 68);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(0, 0);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(435, 68);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Tra từ";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Translate
            // 
            this.btn_Translate.BackColor = System.Drawing.Color.Transparent;
            this.btn_Translate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Translate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Translate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Translate.Location = new System.Drawing.Point(435, 0);
            this.btn_Translate.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Translate.Name = "btn_Translate";
            this.btn_Translate.Size = new System.Drawing.Size(435, 68);
            this.btn_Translate.TabIndex = 1;
            this.btn_Translate.Text = "Dịch từ";
            this.btn_Translate.UseVisualStyleBackColor = false;
            this.btn_Translate.Click += new System.EventHandler(this.btn_Translate_Click);
            // 
            // pan_Search
            // 
            this.pan_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Search.Location = new System.Drawing.Point(5, 5);
            this.pan_Search.Margin = new System.Windows.Forms.Padding(5);
            this.pan_Search.Name = "pan_Search";
            this.pan_Search.Padding = new System.Windows.Forms.Padding(5);
            this.pan_Search.Size = new System.Drawing.Size(860, 404);
            this.pan_Search.TabIndex = 1;
            // 
            // pan_Translate
            // 
            this.pan_Translate.AutoSize = true;
            this.pan_Translate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Translate.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pan_Translate.Location = new System.Drawing.Point(5, 5);
            this.pan_Translate.Margin = new System.Windows.Forms.Padding(5);
            this.pan_Translate.Name = "pan_Translate";
            this.pan_Translate.Padding = new System.Windows.Forms.Padding(5);
            this.pan_Translate.Size = new System.Drawing.Size(860, 404);
            this.pan_Translate.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pan_Search);
            this.panel2.Controls.Add(this.pan_Translate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(870, 414);
            this.panel2.TabIndex = 2;
            // 
            // Favourite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Favourite";
            this.Size = new System.Drawing.Size(870, 482);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Translate;
        private System.Windows.Forms.FlowLayoutPanel pan_Search;
        private System.Windows.Forms.FlowLayoutPanel pan_Translate;
        private System.Windows.Forms.Panel panel2;
    }
}
