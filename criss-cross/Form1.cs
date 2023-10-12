using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace criss_cross
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Int32 a = 0;
        Int32 b = 0;
        private void Checkwin()
        {
            if (button00.Text == "X" && button01.Text == "X" && button02.Text == "X" && button03.Text=="X" || button00.Text == "X" && button10.Text == "X" && button20.Text == "X" && button30.Text == "X" || button00.Text == "X" && button11.Text == "X" && button22.Text == "X" && button33.Text == "X" || button02.Text == "X" && button12.Text == "X" && button22.Text == "X" && button32.Text == "X" || button01.Text == "X" && button11.Text == "X" && button21.Text == "X" && button31.Text == "X" || button10.Text == "X" && button11.Text == "X" && button12.Text == "X" && button13.Text == "X" || button30.Text == "X" && button21.Text == "X" && button12.Text == "X" && button03.Text == "X" || button20.Text == "X" && button21.Text == "X" && button22.Text == "X" && button23.Text == "X" || button03.Text == "X" && button13.Text == "X" && button23.Text == "X" && button33.Text == "X" || button30.Text == "X" && button31.Text == "X" && button32.Text == "X" && button33.Text == "X")
            {
                MessageBox.Show("X - WIN");
                a = a + 1;
                string shex1 = Convert.ToString(a);
                CountXWin.Text = shex1;
                fillZeros();
                turnx = true;
            }
            if (button00.Text == "O" && button01.Text == "O" && button02.Text == "O" && button03.Text == "O" || button00.Text == "O" && button10.Text == "O" && button20.Text == "O" && button30.Text == "O" || button00.Text == "O" && button11.Text == "O" && button22.Text == "O" && button33.Text == "O" || button02.Text == "O" && button12.Text == "O" && button22.Text == "O" && button32.Text == "O" || button01.Text == "O" && button11.Text == "O" && button21.Text == "O" && button31.Text == "O" || button10.Text == "O" && button11.Text == "O" && button12.Text == "O" && button13.Text == "O" || button30.Text == "O" && button21.Text == "O" && button12.Text == "O" && button03.Text == "O" || button20.Text == "O" && button21.Text == "O" && button22.Text == "O" && button23.Text == "O" || button03.Text == "O" && button13.Text == "O" && button23.Text == "O" && button33.Text == "O" || button30.Text == "O" && button31.Text == "O" && button32.Text == "O" && button33.Text == "O")
            {
                MessageBox.Show("O - WIN");
                b = b + 1;
                string shex = Convert.ToString(b);
                CountOWin.Text = shex;
                fillZeros();
                turnx = true;
            }
            else
            {
                bool isFull = true;
                foreach (var button in this.Controls.OfType<Button>())
                {
                    if (button.Text == "")
                    {
                        isFull = false;
                    }
                }
                if (isFull)
                {
                    MessageBox.Show("nobody win");
                    fillZeros();
                    turnx = true;
                }
            }
        }
        public void fillZeros()
        {
            button00.Text = "";
            button01.Text = "";
            button02.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button20.Text = "";
            button21.Text = "";
            button22.Text = "";
        }
        bool turnx;

        private void Form1_Load(object sender, EventArgs e)
        {
            turnx = true;
            fillZeros();
            CountOWin.Text = "";
            CountXWin.Text = "";
            foreach (var item in this.Controls)
            {
                if (item is Button) 
                {
                    ((Button)item).Click += CommonBtn_Click; 
                }
            }
        }
        private void CommonBtn_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "")
            {
                if (turnx == true)
                {
                    ((Button)sender).ForeColor = Color.Blue;
                    ((Button)sender).Text = "X";
                    turnx = false;
                }
                else
                {
                    ((Button)sender).ForeColor = Color.Red;
                    ((Button)sender).Text = "O";
                    turnx = true;
                }
            }
            Checkwin();
        }
        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void обнулитьСчетToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CountOWin.Text = "";
            CountXWin.Text = "";
            a = 0;
            b = 0;
        }
        private void выключитьЦветToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is Button)
                {
                    ((Button)item).ForeColor = Color.Black;
                }
            }
        }

    }
}
