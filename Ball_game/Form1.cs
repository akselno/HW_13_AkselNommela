using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private DateTime startTime;
        private int secondsToWait = 3;
        private int redBallX, redBallY;
        private int redBallDiameter;
        private int redBallXSpeed, redBallYSpeed;
        private int rectangleX, rectangleY;
        private int rectangleWidthAndHeight = 20;
        private int bonusBallX, bonusBallY;
        private int bonusBallDiameter = 20;
        private int lives, score;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer_startCountdown.Start();
            startTime = DateTime.Now;

            score = 0;
            lives = 3;
            
            label_gameOver.Visible = false;
            label_congratulations.Visible = false;
            label_topScoresText.Visible = false;
            label_top3Scores.Visible = false;
            label_startCountdown.Visible = true;
            label_getReady.Visible = true;
            redBallDiameter = int.Parse(textBox_size.Text);
            int speed = int.Parse(textBox_speed.Text);
            redBallXSpeed = speed;
            redBallYSpeed = speed;
            redBallX = rnd.Next(0, (int)(pictureBox1.Width - 1.5*redBallDiameter));
            redBallY = rnd.Next(0, (int)(pictureBox1.Height - 1.5*redBallDiameter));
            rectangleX = rnd.Next(0, (int)(pictureBox1.Width - 1.5*rectangleWidthAndHeight));
            rectangleY = rnd.Next(0, (int)(pictureBox1.Height - 1.5*rectangleWidthAndHeight));
            //lisasin 1.5X, et ei tekiks ohtu, et kohe alguses nö. ääre sisse edasi-tagasi põrkuma jääb

            button_start.Enabled = false;
            textBox_speed.Enabled = false;
            textBox_size.Enabled = false;
        }

        private void timer_startCountdown_Tick(object sender, EventArgs e)
        {
            //kui vajutada "play again", siis alustab timer 1 sek. pealt

            if (secondsToWait > 1)
            {
                secondsToWait--;
                label_startCountdown.Text = secondsToWait.ToString();
            }
            else
            {
                timer_startCountdown.Stop();
                label_startCountdown.Visible = false;
                label_getReady.Visible = false;
                if (CheckIfRectangleAndRedBallAreSeparate() == false) //see tegelt ei toimi. jääb näitama
                                                                      //kuidas ruut punase ringi sees ja lihtsalt seisab
                {
                    secondsToWait = 2;
                }
                else
                {
                    timer_redBall.Start();
                    timer_bonusBall.Start();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer_bonusBall_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - startTime;
            double threeSecondsAsDouble = span.TotalSeconds;
            int threeSeconds = Convert.ToInt32(threeSecondsAsDouble);
            if (threeSeconds % 3 == 0)
            {
                bonusBallX = rnd.Next(0, (int)(ClientSize.Width - 1.5*bonusBallDiameter));
                bonusBallY = rnd.Next(0, (int)(ClientSize.Height - 1.5*bonusBallDiameter));
            }
            else
            {
                bonusBallX = -40;
                bonusBallY = -40;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //vahel sõidab pictureBoxist osaliselt-, vahel täielikult välja.

            if (e.KeyCode == Keys.Up)
            {
                if (rectangleY > 0)
                {
                    rectangleY -= 30;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (rectangleY + rectangleWidthAndHeight < pictureBox1.Height)
                {
                    rectangleY += 30;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (rectangleX + rectangleWidthAndHeight < pictureBox1.Width)
                {
                    rectangleX += 30;
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (rectangleX > 0)
                {
                    rectangleX -= 30;
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(new SolidBrush(Color.Red), redBallX, redBallY,
                redBallDiameter, redBallDiameter);
            e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255))), 
                bonusBallX, bonusBallY,bonusBallDiameter, bonusBallDiameter);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), rectangleX, rectangleY,
                rectangleWidthAndHeight, rectangleWidthAndHeight);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer_redBall_Tick(object sender, EventArgs e)
        {
            redBallX += redBallXSpeed;
            if (redBallX >= pictureBox1.Width - redBallDiameter)
            {
                redBallXSpeed = -redBallXSpeed;
            }
            else if (redBallX <= 0)
            {
                redBallXSpeed = -redBallXSpeed;
            }

            redBallY += redBallYSpeed;
            if (redBallY >= pictureBox1.Height - redBallDiameter)
            {
                redBallYSpeed = -redBallYSpeed;
            }
            else if (redBallY <= 0)
            {
                redBallYSpeed = -redBallYSpeed;
            }

            if (new Rectangle(rectangleX, rectangleY, rectangleWidthAndHeight, rectangleWidthAndHeight)
                 .IntersectsWith(new Rectangle(redBallX, redBallY, redBallDiameter, redBallDiameter)))
            {
                redBallXSpeed = -redBallXSpeed;
                redBallYSpeed = -redBallYSpeed;
                lives--;
                label_lives.Text = lives.ToString();
            }

            if (lives == 0)
            {
                label_gameOver.Visible = true;
                timer_redBall.Stop();
                timer_bonusBall.Stop();
                EndGame();
                button_start.Text = "Play again!";
                button_start.Enabled = true;
                label_top3Scores.Visible = true;
            }

            pictureBox1.Invalidate();
        }

        private bool CheckIfRectangleAndRedBallAreSeparate()
        {
            if (new Rectangle(rectangleX, rectangleY, rectangleWidthAndHeight, rectangleWidthAndHeight)
                 .IntersectsWith(new Rectangle(redBallX, redBallY, redBallDiameter, redBallDiameter)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void EndGame()
        {
            string fileName = "score.txt";
            int maxScore = 0;

            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    maxScore = int.Parse(reader.ReadToEnd());
                }
            }

            if (score > maxScore)
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(score);
                    label_congratulations.Text = $"Congratulations!\n{score} is the new max score!";
                    label_congratulations.Visible = true;
                }
            }

            textBox_speed.Enabled = true;
            textBox_size.Enabled = true;
        }
    }
}
