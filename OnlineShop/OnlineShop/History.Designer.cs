
namespace OnlineShop
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
            this.topPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Delivery = new System.Windows.Forms.Button();
            this.btn_Success = new System.Windows.Forms.Button();
            this.btn_Ordering = new System.Windows.Forms.Button();
            this.orderItems = new System.Windows.Forms.FlowLayoutPanel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topPanel.ColumnCount = 3;
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.topPanel.Controls.Add(this.btn_Delivery, 1, 0);
            this.topPanel.Controls.Add(this.btn_Success, 2, 0);
            this.topPanel.Controls.Add(this.btn_Ordering, 0, 0);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.RowCount = 1;
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topPanel.Size = new System.Drawing.Size(1113, 60);
            this.topPanel.TabIndex = 5;
            // 
            // btn_Delivery
            // 
            this.btn_Delivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Delivery.FlatAppearance.BorderSize = 0;
            this.btn_Delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delivery.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delivery.Location = new System.Drawing.Point(375, 4);
            this.btn_Delivery.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delivery.Name = "btn_Delivery";
            this.btn_Delivery.Size = new System.Drawing.Size(363, 52);
            this.btn_Delivery.TabIndex = 6;
            this.btn_Delivery.Text = "Delivery";
            this.btn_Delivery.UseVisualStyleBackColor = true;
            this.btn_Delivery.Click += new System.EventHandler(this.btn_Delivery_Click);
            // 
            // btn_Success
            // 
            this.btn_Success.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Success.FlatAppearance.BorderSize = 0;
            this.btn_Success.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Success.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Success.Location = new System.Drawing.Point(746, 4);
            this.btn_Success.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Success.Name = "btn_Success";
            this.btn_Success.Size = new System.Drawing.Size(363, 52);
            this.btn_Success.TabIndex = 7;
            this.btn_Success.Text = "Success";
            this.btn_Success.UseVisualStyleBackColor = true;
            this.btn_Success.Click += new System.EventHandler(this.btn_Success_Click);
            // 
            // btn_Ordering
            // 
            this.btn_Ordering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Ordering.FlatAppearance.BorderSize = 0;
            this.btn_Ordering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ordering.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ordering.Location = new System.Drawing.Point(4, 4);
            this.btn_Ordering.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ordering.Name = "btn_Ordering";
            this.btn_Ordering.Size = new System.Drawing.Size(363, 52);
            this.btn_Ordering.TabIndex = 5;
            this.btn_Ordering.Text = "Ordering";
            this.btn_Ordering.UseVisualStyleBackColor = true;
            this.btn_Ordering.Click += new System.EventHandler(this.btn_Ordering_Click);
            // 
            // orderItems
            // 
            this.orderItems.BackColor = System.Drawing.Color.White;
            this.orderItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderItems.Location = new System.Drawing.Point(0, 60);
            this.orderItems.Name = "orderItems";
            this.orderItems.Padding = new System.Windows.Forms.Padding(5);
            this.orderItems.Size = new System.Drawing.Size(1113, 496);
            this.orderItems.TabIndex = 6;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderItems);
            this.Controls.Add(this.topPanel);
            this.Name = "History";
            this.Size = new System.Drawing.Size(1113, 556);
            this.Load += new System.EventHandler(this.History_Load);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topPanel;
        private System.Windows.Forms.Button btn_Delivery;
        private System.Windows.Forms.Button btn_Success;
        private System.Windows.Forms.Button btn_Ordering;
        private System.Windows.Forms.FlowLayoutPanel orderItems;
    }
}
