
namespace Dictionary
{
    partial class Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_CountDown = new System.Windows.Forms.Label();
            this.lbl_StartTime = new System.Windows.Forms.Label();
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_P = new System.Windows.Forms.Label();
            this.lbl_Point = new System.Windows.Forms.Label();
            this.lbl_Lives = new System.Windows.Forms.Label();
            this.lbl_L = new System.Windows.Forms.Label();
            this.btn_HighScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(363, 337);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 36);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Transparent;
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(420, 185);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(193, 167);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "START";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbl_CountDown
            // 
            this.lbl_CountDown.AutoSize = true;
            this.lbl_CountDown.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CountDown.Location = new System.Drawing.Point(825, 49);
            this.lbl_CountDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CountDown.Name = "lbl_CountDown";
            this.lbl_CountDown.Size = new System.Drawing.Size(41, 29);
            this.lbl_CountDown.TabIndex = 3;
            this.lbl_CountDown.Text = "10";
            // 
            // lbl_StartTime
            // 
            this.lbl_StartTime.AutoSize = true;
            this.lbl_StartTime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_StartTime.Font = new System.Drawing.Font("Mistral", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartTime.Location = new System.Drawing.Point(459, 207);
            this.lbl_StartTime.Name = "lbl_StartTime";
            this.lbl_StartTime.Size = new System.Drawing.Size(76, 101);
            this.lbl_StartTime.TabIndex = 4;
            this.lbl_StartTime.Text = "1";
            // 
            // startTimer
            // 
            this.startTimer.Interval = 1000;
            this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
            // 
            // lbl_P
            // 
            this.lbl_P.AutoSize = true;
            this.lbl_P.BackColor = System.Drawing.Color.Transparent;
            this.lbl_P.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P.Location = new System.Drawing.Point(24, 33);
            this.lbl_P.Name = "lbl_P";
            this.lbl_P.Size = new System.Drawing.Size(56, 19);
            this.lbl_P.TabIndex = 5;
            this.lbl_P.Text = "Point:";
            // 
            // lbl_Point
            // 
            this.lbl_Point.AutoSize = true;
            this.lbl_Point.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Point.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Point.Location = new System.Drawing.Point(87, 33);
            this.lbl_Point.Name = "lbl_Point";
            this.lbl_Point.Size = new System.Drawing.Size(18, 19);
            this.lbl_Point.TabIndex = 6;
            this.lbl_Point.Text = "0";
            // 
            // lbl_Lives
            // 
            this.lbl_Lives.AutoSize = true;
            this.lbl_Lives.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Lives.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lives.Location = new System.Drawing.Point(87, 80);
            this.lbl_Lives.Name = "lbl_Lives";
            this.lbl_Lives.Size = new System.Drawing.Size(18, 19);
            this.lbl_Lives.TabIndex = 8;
            this.lbl_Lives.Text = "3";
            // 
            // lbl_L
            // 
            this.lbl_L.AutoSize = true;
            this.lbl_L.BackColor = System.Drawing.Color.Transparent;
            this.lbl_L.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_L.Location = new System.Drawing.Point(24, 80);
            this.lbl_L.Name = "lbl_L";
            this.lbl_L.Size = new System.Drawing.Size(56, 19);
            this.lbl_L.TabIndex = 7;
            this.lbl_L.Text = "Lives:";
            // 
            // btn_HighScore
            // 
            this.btn_HighScore.FlatAppearance.BorderSize = 0;
            this.btn_HighScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HighScore.Location = new System.Drawing.Point(444, 465);
            this.btn_HighScore.Name = "btn_HighScore";
            this.btn_HighScore.Size = new System.Drawing.Size(148, 39);
            this.btn_HighScore.TabIndex = 9;
            this.btn_HighScore.Text = "Bảng xếp hạng";
            this.btn_HighScore.UseVisualStyleBackColor = true;
            this.btn_HighScore.Click += new System.EventHandler(this.btn_HighScore_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_HighScore);
            this.Controls.Add(this.lbl_Lives);
            this.Controls.Add(this.lbl_L);
            this.Controls.Add(this.lbl_Point);
            this.Controls.Add(this.lbl_P);
            this.Controls.Add(this.lbl_StartTime);
            this.Controls.Add(this.lbl_CountDown);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(1057, 542);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl_CountDown;
        private System.Windows.Forms.Label lbl_StartTime;
        private System.Windows.Forms.Timer startTimer;
        private System.Windows.Forms.Label lbl_P;
        private System.Windows.Forms.Label lbl_Point;
        private System.Windows.Forms.Label lbl_Lives;
        private System.Windows.Forms.Label lbl_L;
        private System.Windows.Forms.Button btn_HighScore;
    }
}
