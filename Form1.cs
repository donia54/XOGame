using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XOProject.Properties;

namespace XOProject
{
    public partial class frmXOGame : Form
    {
        int cnt = 0;
        public frmXOGame()
        {
            InitializeComponent();
        }

        public bool CheckWin(PictureBox P1, PictureBox P2, PictureBox P3)
        {
            if(P1.Tag.ToString()!="?" && P1.Tag==P2.Tag && P1.Tag==P3.Tag)
            {
                P1.BackColor = Color.Yellow;
                P2.BackColor = Color.Yellow;
                P3.BackColor = Color.Yellow;
               return true;
            }
            else
            {
                return false;
            }
        }

        void EndOfGame()
        {
            lbTurn.Text = "Game Over";
            MessageBox.Show("Game Over", ":)))", MessageBoxButtons.OK);
            pbX0Y0.Enabled = false;
            pbX0Y1.Enabled = false;
            pbX0Y2.Enabled = false;
            pbX1Y0.Enabled = false; 
            pbX1Y1.Enabled = false;
            pbX1Y2.Enabled = false;
            pbX2Y0.Enabled = false; 
            pbX2Y1.Enabled = false;
            pbX2Y2.Enabled = false;

        }

        void WhoWin()
        {
            cnt++;
            if (CheckWin(pbX0Y0, pbX0Y1, pbX0Y2))
            {
                if (pbX0Y0.Tag.ToString() == "x") lbWinner.Text = "Player1";
                else lbWinner.Text = "Player2";
                EndOfGame();
                return;
            }
            if (CheckWin(pbX1Y0, pbX1Y1, pbX1Y2))
            {
                if (pbX1Y1.Tag.ToString() == "x") lbWinner.Text = "Player1";
                else lbWinner.Text = "Player2";
                EndOfGame();
                return;
            }
            if (CheckWin(pbX2Y0, pbX2Y1, pbX2Y2))
            {
                if (pbX2Y2.Tag.ToString() == "x") lbWinner.Text = "Player1";
                else lbWinner.Text = "Player2";
                EndOfGame();
                return;
            }
            if (CheckWin(pbX0Y0, pbX1Y0, pbX2Y0))
            {
                if (pbX0Y0.Tag.ToString() == "x") lbWinner.Text = "Player1";
                else lbWinner.Text = "Player2";
                EndOfGame();
                return;
            }
            if (CheckWin(pbX0Y1, pbX1Y1, pbX2Y1))
            {
                if (pbX1Y1.Tag.ToString() == "x") lbWinner.Text = "Player1";
                else lbWinner.Text = "Player2";
                EndOfGame();
                return;
            }
            if (CheckWin(pbX0Y2, pbX1Y2, pbX2Y2))
            {
                if (pbX2Y1.Tag.ToString() == "x") lbWinner.Text = "Player1";
                else lbWinner.Text = "Player2";
                EndOfGame();
                return;
            }
            if (CheckWin(pbX0Y0, pbX1Y1, pbX2Y2))
            {
                if (pbX0Y0.Tag.ToString() == "x") lbWinner.Text = "Player1";
                else lbWinner.Text = "Player2";
                EndOfGame();
                return;
            }
            if (CheckWin(pbX0Y2, pbX1Y1, pbX2Y0))
            {
                if (pbX1Y1.Tag.ToString() == "x") lbWinner.Text = "Player1";
                else lbWinner.Text = "Player2";
                EndOfGame();
                return;
            }

            if (cnt > 9||cnt==9)
            {
                
                    lbWinner.Text = "Draw";
                EndOfGame();
            }

        }
        void UpdateImage(PictureBox P)
        {
            if (P.Tag.ToString() == "?")
            {
                if (lbTurn.Text =="Player1")
                {
                    P.Image = Resources.X;
                    P.Tag = "x";
                    lbTurn.Text = "Player2";
                }
                else
                {
                    P.Image = Resources.O;
                    P.Tag = "o";
                    lbTurn.Text = "Player1";
                }
                WhoWin();
            }
            else
            {
                MessageBox.Show("Wrong Choice", "NOPPP",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        private void frmXOGame_Paint(object sender, PaintEventArgs e)
        {
            Color Color = Color.White;
            Pen Pen = new Pen(Color);
            Pen.Width = 10;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap= System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 250, 170 ,670, 170);
            e.Graphics.DrawLine(Pen, 250, 270, 670, 270);
            e.Graphics.DrawLine(Pen, 380, 70, 380, 370);
            e.Graphics.DrawLine(Pen, 540, 70, 540, 370);

        }


        private void Picture_Click(object sender, EventArgs e)
        {
            UpdateImage((PictureBox)sender);
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            lbTurn.Text = "Player1";
            lbWinner.Text = "In Progress";
            pbX0Y0.Enabled = true;
            pbX0Y1.Enabled = true;
            pbX0Y2.Enabled = true;
            pbX1Y0.Enabled = true;
            pbX1Y1.Enabled = true;
            pbX1Y2.Enabled = true;
            pbX2Y0.Enabled = true;
            pbX2Y1.Enabled = true;
            pbX2Y2.Enabled = true;

            pbX0Y0.Tag = "?";
            pbX0Y1.Tag = "?";
            pbX0Y2.Tag = "?";
            pbX1Y0.Tag = "?";
            pbX1Y1.Tag = "?";
            pbX1Y2.Tag = "?";
            pbX2Y0.Tag = "?";
            pbX2Y1.Tag = "?";
            pbX2Y2.Tag = "?";

            pbX0Y0.Image = Resources.question_mark_96;
            pbX0Y1.Image = Resources.question_mark_96;
            pbX0Y2.Image = Resources.question_mark_96;
            pbX1Y0.Image = Resources.question_mark_96;
            pbX1Y1.Image = Resources.question_mark_96;
            pbX1Y2.Image = Resources.question_mark_96;
            pbX2Y0.Image = Resources.question_mark_96;
            pbX2Y1.Image = Resources.question_mark_96;
            pbX2Y2.Image = Resources.question_mark_96;

            pbX0Y0.BackColor = Color.Black;
            pbX0Y1.BackColor = Color.Black;
            pbX0Y2.BackColor = Color.Black;
            pbX1Y0.BackColor = Color.Black;
            pbX1Y1.BackColor = Color.Black;
            pbX1Y2.BackColor = Color.Black;
            pbX2Y0.BackColor = Color.Black;
            pbX2Y1.BackColor = Color.Black;
            pbX2Y2.BackColor= Color.Black;

            cnt = 0;

        }
    }
}
