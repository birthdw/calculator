using Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;




namespace WinFormsApp1
{
    public partial class bt_bat : Form
    {
        string p1;
        string p2;
        int pcnt = 0;
        bool checkP = true;
        public bt_bat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pcnt == 0)
            {
                if (txt_Ans.Text.Length != 4)
                    return;
                p1 = txt_Ans.Text;
                txt_Ans.Text = "";
                Player.Text = "p2 Num";
            }
            else if (pcnt == 1)
            {
                if (txt_Ans.Text.Length != 4)
                    return;
                p2 = txt_Ans.Text;
                txt_Ans.Visible = false;
                Player.Text = "입력완료";
                Player.Visible = false;
                button1.Visible = false;

                timer1.Start();


            }
            ++pcnt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int strcnt = 0;
            int ballcnt = 0;
            if (txt_bat.Text.Length != 4)
            {
                MessageBox.Show("번호 다시 입력");
                return;
            }

            if (checkP == true)  //p1
            {
                string bat = txt_bat.Text;

                for (int i = 0; i < bat.Length; ++i)
                {
                    for (int k = 0; k < bat.Length; ++k)
                    {
                        if (k == i)
                        {
                            if (bat[i] == p2[k])
                            {
                                ++strcnt;
                            }
                        }
                        else if (bat[i] == p2[k])
                        {
                            ++ballcnt;
                        }
                    }
                }

                if (strcnt == 0 && ballcnt == 0)
                {
                    p1list.Items.Add(bat + "out");
                }

                if (strcnt == 4)
                {
                    p1list.Items.Add(bat + "homerun");
                    MessageBox.Show(string.Format("Player1 의 승리 ! p1:{0}  p2:{1}", p1, p2));
                    Close();
                    return;
                }

                progressBar1.Value = 0;
                p1list.Items.Add(bat + " " + strcnt.ToString() + "strike " + ballcnt.ToString() + "ball");

            }
            else             //p2
            {
                string bat = txt_bat.Text;

                for (int i = 0; i < bat.Length; ++i)
                {
                    for (int k = 0; k < bat.Length; ++k)
                    {
                        if (k == i)
                        {
                            if (bat[i] == p1[k])
                            {
                                ++strcnt;
                            }
                        }
                        else if (bat[i] == p1[k])
                        {
                            ++ballcnt;
                        }
                    }

                }

                if (strcnt == 0 && ballcnt == 0)
                {
                    p2list.Items.Add(bat + "out");
                }

                if (strcnt == 4)
                {
                    timer1.Stop();
                    p2list.Items.Add(bat + "homerun");
                    MessageBox.Show(string.Format("Player2 의 승리 ! p1:{0}  p2:{1}", p1, p2));
                    Close();
                    return;
                }

                p2list.Items.Add(bat + " " + strcnt.ToString() + "strike " + ballcnt.ToString() + "ball");
                progressBar1.Value = 0;
            }

            txt_bat.Text = "";
            checkP = !checkP;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == 7)
            {
                progressBar1.Value = 0;
                if (checkP==true)
                {
                    checkP = false;
                    p1list.Items.Add("시간초과");
                }
                else
                {
                    checkP = true;
                    p2list.Items.Add("시간초과");
                }

            }

        }
    }
}
