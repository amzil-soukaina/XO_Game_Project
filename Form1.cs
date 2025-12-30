using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Project.Properties;

namespace Tic_Tac_Toe_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte Counter = 1;

        enum enPlayer
        {
            Player1,
            Player2
        }

        enPlayer Player = enPlayer.Player1;
        void MainPhotoInPcBoxes()
        {
            pcBox1.Image = Resources.question_mark_96;
            pcBox2.Image = Resources.question_mark_96;
            pcBox3.Image = Resources.question_mark_96;
            pcBox4.Image = Resources.question_mark_96;
            pcBox5.Image = Resources.question_mark_96;
            pcBox6.Image = Resources.question_mark_96;
            pcBox7.Image = Resources.question_mark_96;
            pcBox8.Image = Resources.question_mark_96;
            pcBox9.Image = Resources.question_mark_96;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);
            Pen Pen = new Pen(White);
            Pen.Width = 10;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 950, 100, 950, 600);
            e.Graphics.DrawLine(Pen, 700, 100, 700, 600);
            e.Graphics.DrawLine(Pen, 450, 100, 450, 600);

            e.Graphics.DrawLine(Pen, 450, 250, 1190, 250);
            e.Graphics.DrawLine(Pen, 450, 400, 1190, 400);

        }


        void PlayGame(PictureBox pcBox)
        {
            if(pcBox.Tag == null)
            {
                switch(Player)
                {
                    case enPlayer.Player1:

                        pcBox.Image = Resources.X;
                        pcBox.Tag = "X";
                        Player = enPlayer.Player2;
                        lblPlayer.Text = "Player 2";
                        StopChangePcBoxOnClick(pcBox);
                        break;

                    case enPlayer.Player2:

                        pcBox.Image = Resources.O;
                        pcBox.Tag = "O";
                        Player = enPlayer.Player1;
                        lblPlayer.Text = "Player 1";
                        StopChangePcBoxOnClick(pcBox);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK);
                return;
            }
        }
        void StopChangePcBoxOnClick(PictureBox pcBox)
        {

            if (SameLines())
                return;

            if(Counter == 9)
            {
                lblInProgress.Text = "Draw";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void pcBox1_Click(object sender, EventArgs e)
        {
            PlayGame(pcBox1);
            Counter++;
        }

        private void pcBox2_Click(object sender, EventArgs e)
        {
            PlayGame(pcBox2);
            Counter++;

        }

        private void pcBox3_Click(object sender, EventArgs e)
        {
            PlayGame(pcBox3);
            Counter++;

        }

        private void pcBox4_Click(object sender, EventArgs e)
        {
            PlayGame(pcBox4);
            Counter++;

        }

        private void pcBox5_Click(object sender, EventArgs e)
        {
            PlayGame(pcBox5);
            Counter++;

        }

        private void pcBox6_Click(object sender, EventArgs e)
        {
            PlayGame(pcBox6);
            Counter++;

        }

        private void pcBox7_Click(object sender, EventArgs e)
        {
            PlayGame(pcBox7);
            Counter++;

        }

        private void pcBox8_Click(object sender, EventArgs e)
        {
            PlayGame(pcBox8);
            Counter++;

        }

        private void pcBox9_Click(object sender, EventArgs e)
        {
            PlayGame(pcBox9);
            Counter++;

        }

        void lblanMessageBox(PictureBox Box1, PictureBox Box2, PictureBox Box3)
        {
            lblInProgress.Text = lblPlayer.Text;// Probleme Here
            lblPlayer.Text = "Game Over";
            Box1.BackColor = Color.FromArgb(0, 192, 192);
            Box2.BackColor = Color.FromArgb(0, 192, 192);
            Box3.BackColor = Color.FromArgb(0, 192, 192);
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        bool SameLines()
        {
            if(pcBox1.Tag != null && pcBox2.Tag != null && pcBox3.Tag != null)
            {
                if (pcBox1.Tag.Equals(pcBox2.Tag) && pcBox2.Tag.Equals(pcBox3.Tag))
                {
                    lblanMessageBox(pcBox1, pcBox2, pcBox3);
                    pcBoxesEnabled();
                    return true;
                }

            }
            if (pcBox1.Tag != null && pcBox4.Tag != null && pcBox7.Tag != null)
            {
                if (pcBox1.Tag.Equals(pcBox4.Tag) && pcBox4.Tag.Equals(pcBox7.Tag))
                {
                    lblanMessageBox(pcBox1, pcBox4, pcBox7);
                    pcBoxesEnabled();
                    return true;

                }
            }

            if (pcBox4.Tag != null && pcBox5.Tag != null && pcBox6.Tag != null)
            {
                if (pcBox4.Tag.Equals(pcBox5.Tag) && pcBox5.Tag.Equals(pcBox6.Tag))
                {
                    lblanMessageBox(pcBox4, pcBox5, pcBox6);
                    pcBoxesEnabled();

                    return true;
                }
            }

            if (pcBox7.Tag != null && pcBox8.Tag != null && pcBox9.Tag != null)
            {
                if (pcBox7.Tag.Equals(pcBox8.Tag) && pcBox8.Tag.Equals(pcBox9.Tag))
                {
                    lblanMessageBox(pcBox7, pcBox8, pcBox9);
                    pcBoxesEnabled();

                    return true;
                }
            }

            if (pcBox2.Tag != null && pcBox5.Tag != null && pcBox8.Tag != null)
            {
                if (pcBox2.Tag.Equals(pcBox5.Tag) && pcBox5.Tag.Equals(pcBox8.Tag))
                {
                    lblanMessageBox(pcBox2, pcBox5, pcBox8);
                    pcBoxesEnabled();

                    return true;
                }
            }

            if (pcBox3.Tag != null && pcBox6.Tag != null && pcBox9.Tag != null)
            {
                if (pcBox3.Tag.Equals(pcBox6.Tag) && pcBox6.Tag.Equals(pcBox9.Tag))
                {
                    lblanMessageBox(pcBox3, pcBox6, pcBox9);
                    pcBoxesEnabled();

                    return true;
                }
            }

            if (pcBox3.Tag != null && pcBox5.Tag != null && pcBox7.Tag != null)
            {
                if (pcBox3.Tag.Equals(pcBox5.Tag) && pcBox5.Tag.Equals(pcBox7.Tag))
                {
                    lblanMessageBox(pcBox3, pcBox5, pcBox7);
                    pcBoxesEnabled();

                    return true;
                }
            }

            if (pcBox1.Tag != null && pcBox5.Tag != null && pcBox9.Tag != null)
            {
                if (pcBox1.Tag.Equals(pcBox5.Tag) && pcBox5.Tag.Equals(pcBox9.Tag))
                {
                    lblanMessageBox(pcBox1, pcBox5, pcBox9);
                    pcBoxesEnabled();
                    return true;
                }
            }
            return false;
        }

        void pcBoxesEnabled()
        {
            pcBox1.Enabled = false;
            pcBox2.Enabled = false;
            pcBox3.Enabled = false;
            pcBox4.Enabled = false;
            pcBox5.Enabled = false;
            pcBox6.Enabled = false;
            pcBox7.Enabled = false;
            pcBox8.Enabled = false;
            pcBox9.Enabled = false;
        }
        void pcBoxesReset()
        {
            pcBox1.Tag = null;
            pcBox2.Tag = null;
            pcBox3.Tag = null;
            pcBox4.Tag = null;
            pcBox5.Tag = null;
            pcBox6.Tag = null;
            pcBox7.Tag = null;
            pcBox8.Tag = null;
            pcBox9.Tag = null;

            //Reset BackColor
            pcBox1.BackColor = Color.Black;
            pcBox2.BackColor = Color.Black;
            pcBox3.BackColor = Color.Black;
            pcBox4.BackColor = Color.Black;
            pcBox5.BackColor = Color.Black;
            pcBox6.BackColor = Color.Black;
            pcBox7.BackColor = Color.Black;
            pcBox8.BackColor = Color.Black;
            pcBox9.BackColor = Color.Black;

            //Reset pcBoxes Enabaled
            pcBox1.Enabled = true;
            pcBox2.Enabled = true;
            pcBox3.Enabled = true;
            pcBox4.Enabled = true;
            pcBox5.Enabled = true;
            pcBox6.Enabled = true;
            pcBox7.Enabled = true;
            pcBox8.Enabled = true;
            pcBox9.Enabled = true;

            //Reset Playerlbl
            lblPlayer.Text = "Player 1";
            lblInProgress.Text = "In Progress";

            //Reset Counter
            Counter = 1;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MainPhotoInPcBoxes();
            pcBoxesReset();

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            MainPhotoInPcBoxes();
            pcBoxesReset();

        }

    }
}
