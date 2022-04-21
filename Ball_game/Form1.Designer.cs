namespace Ball_game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer_redBall = new System.Windows.Forms.Timer(this.components);
            this.timer_bonusBall = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_size = new System.Windows.Forms.TextBox();
            this.textBox_speed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_lives = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.label_gameOver = new System.Windows.Forms.Label();
            this.label_congratulations = new System.Windows.Forms.Label();
            this.label_topScoresText = new System.Windows.Forms.Label();
            this.label_top3Scores = new System.Windows.Forms.Label();
            this.timer_startCountdown = new System.Windows.Forms.Timer(this.components);
            this.label_startCountdown = new System.Windows.Forms.Label();
            this.label_getReady = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_redBall
            // 
            this.timer_redBall.Interval = 20;
            this.timer_redBall.Tick += new System.EventHandler(this.timer_redBall_Tick);
            // 
            // timer_bonusBall
            // 
            this.timer_bonusBall.Interval = 1000;
            this.timer_bonusBall.Tick += new System.EventHandler(this.timer_bonusBall_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(658, 448);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // textBox_size
            // 
            this.textBox_size.Location = new System.Drawing.Point(674, 36);
            this.textBox_size.Name = "textBox_size";
            this.textBox_size.Size = new System.Drawing.Size(60, 22);
            this.textBox_size.TabIndex = 1;
            this.textBox_size.Text = "40";
            this.textBox_size.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_speed
            // 
            this.textBox_speed.Location = new System.Drawing.Point(674, 105);
            this.textBox_speed.Name = "textBox_speed";
            this.textBox_speed.Size = new System.Drawing.Size(60, 22);
            this.textBox_speed.TabIndex = 2;
            this.textBox_speed.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(671, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Red ball size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(671, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Red ball speed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(659, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lives left:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_lives
            // 
            this.label_lives.AutoSize = true;
            this.label_lives.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label_lives.Location = new System.Drawing.Point(689, 251);
            this.label_lives.Name = "label_lives";
            this.label_lives.Size = new System.Drawing.Size(78, 90);
            this.label_lives.TabIndex = 6;
            this.label_lives.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(660, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Score:";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label_score.Location = new System.Drawing.Point(661, 405);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(20, 23);
            this.label_score.TabIndex = 8;
            this.label_score.Text = "0";
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Lime;
            this.button_start.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_start.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button_start.Location = new System.Drawing.Point(665, 148);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(123, 46);
            this.button_start.TabIndex = 9;
            this.button_start.Text = "Play!";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_gameOver
            // 
            this.label_gameOver.AutoSize = true;
            this.label_gameOver.BackColor = System.Drawing.Color.Cyan;
            this.label_gameOver.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label_gameOver.ForeColor = System.Drawing.Color.Red;
            this.label_gameOver.Location = new System.Drawing.Point(106, 25);
            this.label_gameOver.Name = "label_gameOver";
            this.label_gameOver.Size = new System.Drawing.Size(441, 90);
            this.label_gameOver.TabIndex = 10;
            this.label_gameOver.Text = "Game over!";
            this.label_gameOver.Visible = false;
            // 
            // label_congratulations
            // 
            this.label_congratulations.AutoSize = true;
            this.label_congratulations.BackColor = System.Drawing.Color.Cyan;
            this.label_congratulations.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label_congratulations.Location = new System.Drawing.Point(49, 148);
            this.label_congratulations.Name = "label_congratulations";
            this.label_congratulations.Size = new System.Drawing.Size(236, 37);
            this.label_congratulations.TabIndex = 11;
            this.label_congratulations.Text = "Congratulations!";
            this.label_congratulations.Visible = false;
            // 
            // label_topScoresText
            // 
            this.label_topScoresText.AutoSize = true;
            this.label_topScoresText.BackColor = System.Drawing.Color.Cyan;
            this.label_topScoresText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label_topScoresText.Location = new System.Drawing.Point(257, 251);
            this.label_topScoresText.Name = "label_topScoresText";
            this.label_topScoresText.Size = new System.Drawing.Size(148, 22);
            this.label_topScoresText.TabIndex = 12;
            this.label_topScoresText.Text = "Top 3 scores are:";
            this.label_topScoresText.Visible = false;
            // 
            // label_top3Scores
            // 
            this.label_top3Scores.AutoSize = true;
            this.label_top3Scores.BackColor = System.Drawing.Color.Cyan;
            this.label_top3Scores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label_top3Scores.Location = new System.Drawing.Point(257, 307);
            this.label_top3Scores.Name = "label_top3Scores";
            this.label_top3Scores.Size = new System.Drawing.Size(106, 22);
            this.label_top3Scores.TabIndex = 13;
            this.label_top3Scores.Text = "top 3 scores";
            this.label_top3Scores.Visible = false;
            // 
            // timer_startCountdown
            // 
            this.timer_startCountdown.Interval = 1000;
            this.timer_startCountdown.Tick += new System.EventHandler(this.timer_startCountdown_Tick);
            // 
            // label_startCountdown
            // 
            this.label_startCountdown.AutoSize = true;
            this.label_startCountdown.BackColor = System.Drawing.Color.Cyan;
            this.label_startCountdown.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label_startCountdown.ForeColor = System.Drawing.Color.Red;
            this.label_startCountdown.Location = new System.Drawing.Point(288, 148);
            this.label_startCountdown.Name = "label_startCountdown";
            this.label_startCountdown.Size = new System.Drawing.Size(117, 135);
            this.label_startCountdown.TabIndex = 14;
            this.label_startCountdown.Text = "3";
            this.label_startCountdown.Visible = false;
            // 
            // label_getReady
            // 
            this.label_getReady.AutoSize = true;
            this.label_getReady.BackColor = System.Drawing.Color.Cyan;
            this.label_getReady.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label_getReady.Location = new System.Drawing.Point(243, 105);
            this.label_getReady.Name = "label_getReady";
            this.label_getReady.Size = new System.Drawing.Size(199, 49);
            this.label_getReady.TabIndex = 15;
            this.label_getReady.Text = "Get ready!";
            this.label_getReady.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_getReady);
            this.Controls.Add(this.label_startCountdown);
            this.Controls.Add(this.label_top3Scores);
            this.Controls.Add(this.label_topScoresText);
            this.Controls.Add(this.label_congratulations);
            this.Controls.Add(this.label_gameOver);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_lives);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_speed);
            this.Controls.Add(this.textBox_size);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_redBall;
        private System.Windows.Forms.Timer timer_bonusBall;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_size;
        private System.Windows.Forms.TextBox textBox_speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_lives;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_gameOver;
        private System.Windows.Forms.Label label_congratulations;
        private System.Windows.Forms.Label label_topScoresText;
        private System.Windows.Forms.Label label_top3Scores;
        private System.Windows.Forms.Timer timer_startCountdown;
        private System.Windows.Forms.Label label_startCountdown;
        private System.Windows.Forms.Label label_getReady;
    }
}

