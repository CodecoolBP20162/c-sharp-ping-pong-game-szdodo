using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer t;
        int Score = 0;
        int SpeedLeft = 2;
        int SpeedTop = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartGame();
        }  
        
        private void StartGame()
        {
            Ball.Location=new Point(350, 150);
            t = new System.Windows.Forms.Timer();
            t.Interval = 10;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            Ball.Left += SpeedLeft;
            Ball.Top += SpeedTop;
            CollisionWithFloor();
            CollisionWithBat();
            CollisionWithTable();
        }

        private void Form1_KeyDown(object   sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (!Bat.Bounds.IntersectsWith(LeftBorder.Bounds))
                    {
                        Bat.Left -= 10;
                    }
                    break;
                case Keys.Right:
                    if (!Bat.Bounds.IntersectsWith(RightBorder.Bounds))
                    {
                        Bat.Left += 10;
                    }
                    break;
                case Keys.Escape:
                    Form1.ActiveForm.Close();
                    break;
                case Keys.Space:
                    if (t.Enabled)
                    {
                        t.Enabled = false;
                    }
                    else
                    {
                        t.Enabled = true;
                    }
                    break;
            }
        }

        private void CollisionWithFloor()
        {
            if (Floor.Bounds.IntersectsWith(Ball.Bounds))
            {
                t.Stop();
                //restart
                DialogResult result = MessageBox.Show("\tGame Over\n\tYour score: "+Score+"\n\tDo you want to starte a new game?", "Ping Ping", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    StartGame();
                }
                else if (result == DialogResult.No)
                {
                    Form1.ActiveForm.Close();
                }
            }
        }

        private void CollisionWithBat()
        {
            if (Bat.Bounds.IntersectsWith(Ball.Bounds))
            {
                Score += 1;
                ScoreLabel2.Text = Score.ToString();
                SpeedLeft += 1;
                SpeedTop += 1;
                SpeedTop = -SpeedTop;
            }
        }

        private void CollisionWithTable()
        {
            if (Ceiling.Bounds.IntersectsWith(Ball.Bounds))
            {
                SpeedTop = -SpeedTop;
            }
            if (RightBorder.Bounds.IntersectsWith(Ball.Bounds))
            {
                SpeedLeft = -SpeedLeft;
            }
            if (LeftBorder.Bounds.IntersectsWith(Ball.Bounds))
            {
                SpeedLeft = -SpeedLeft;
            }
        }
    }
}
