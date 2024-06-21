using Calculator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinFormsApp1
{

    public partial class Form20 : Form
    {

        bool test = false;

        Dictionary<int, Card> Deck = new Dictionary<int, Card>();
        List<Card> CheckCard = new List<Card>();
        int cnt = 0;

        public async void TwoCardSelect()
        {
            if (test == true)
            {
                if (CheckCard[0].Check == CheckCard[1].Check)
                {
                    //맞춤
                    ++cnt;
                    lb_cnt.Text = cnt.ToString();
                }
                else
                {
                    Thread.Sleep(500);
                    CheckCard[0].Hide = true;
                    CheckCard[1].Hide = true;
                    CheckCard[0].bt.Image = CheckCard[0].Backimg;
                    CheckCard[1].bt.Image = CheckCard[1].Backimg;
                }

                CheckCard.Remove(CheckCard[0]);
                CheckCard.Remove(CheckCard[0]);
                CheckCard.Clear();
                test = false;
            }

            if (CheckCard.Count == 2)
            {
                test = true;
            }
        }


        public void Check_Card(Button bt)
        {

            string temp = bt.Text;
            int idx = bt.Text.Length - 1;
            char t = temp[idx];
            int num = Convert.ToInt32(new string(t, 1));
            if (Deck[num].Hide == true)
            {
                Deck[num].bt.Image = Deck[num].Topimg;
                Deck[num].Hide = false;
                CheckCard.Add(Deck[num]);
            }
            else
            {
                //이미 뒤집힌경우
            }
        }

        public void SwapCardPos(Card p1, Card p2)
        {
            Point temp = p2.bt.Location;
            p2.bt.Location = p1.bt.Location;
            p1.bt.Location = temp;
        }


        public Form20()
        {
            InitializeComponent();

            Card CARD1 = new Card();
            CARD1.Backimg = Resources.cback;
            CARD1.Topimg = Resources.c1;
            CARD1.Check = 1;
            CARD1.bt = card1;
            Deck.Add(1, CARD1);

            Card CARD2 = new Card();
            CARD2.Backimg = Resources.cback;
            CARD2.Topimg = Resources.c1;
            CARD2.Check = 1;
            CARD2.bt = card2;
            Deck.Add(2, CARD2);


            Card CARD3 = new Card();
            CARD3.Backimg = Resources.cback;
            CARD3.Topimg = Resources.c2;
            CARD3.Check = 2;
            CARD3.bt = card3;
            Deck.Add(3, CARD3);

            Card CARD4 = new Card();
            CARD4.Backimg = Resources.cback;
            CARD4.Topimg = Resources.c2;
            CARD4.Check = 2;
            CARD4.bt = card4;
            Deck.Add(4, CARD4);

            Card CARD5 = new Card();
            CARD5.Backimg = Resources.cback;
            CARD5.Topimg = Resources.c3;
            CARD5.Check = 3;
            CARD5.bt = card5;
            Deck.Add(5, CARD5);

            Card CARD6 = new Card();
            CARD6.Backimg = Resources.cback;
            CARD6.Topimg = Resources.c3;
            CARD6.Check = 3;
            CARD6.bt = card6;
            Deck.Add(6, CARD6);

            Card CARD7 = new Card();
            CARD7.Backimg = Resources.cback;
            CARD7.Topimg = Resources.c4;
            CARD7.Check = 4;
            CARD7.bt = card7;
            Deck.Add(7, CARD7);

            Card CARD8 = new Card();
            CARD8.Backimg = Resources.cback;
            CARD8.Topimg = Resources.c4;
            CARD8.Check = 4;
            CARD8.bt = card8;
            Deck.Add(8, CARD8);


            //카드 위치 섞기

            List<int> ints = new List<int>();
            Random random = new Random();
            bool bcheck = true;
            bool bcheck2 = true;
            while (bcheck)
            {
                int idx = random.Next(0, 8);
                foreach (int i in ints)
                {
                    if (idx == i)
                    {
                        bcheck2 = false;
                    }
                }

                if (bcheck2 == false)
                {
                    bcheck2 = true;
                    continue;
                }

                ints.Add(idx + 1);
                if (ints.Count == 8)
                    bcheck = false;
            }

            SwapCardPos(Deck[ints[0]], Deck[ints[1]]);
            SwapCardPos(Deck[ints[2]], Deck[ints[3]]);
            SwapCardPos(Deck[ints[4]], Deck[ints[5]]);
            SwapCardPos(Deck[ints[6]], Deck[ints[7]]);

        }

        private void card1_Click(object sender, EventArgs e)
        {
            Check_Card((Button)sender);
        }

        private void card2_Click(object sender, EventArgs e)
        {
            Check_Card((Button)sender);
        }

        private void card3_Click(object sender, EventArgs e)
        {
            Check_Card((Button)sender);
        }

        private void card4_Click(object sender, EventArgs e)
        {
            Check_Card((Button)sender);
        }

        private void card5_Click(object sender, EventArgs e)
        {
            Check_Card((Button)sender);
        }

        private void card6_Click(object sender, EventArgs e)
        {
            Check_Card((Button)sender);
        }

        private void card7_Click(object sender, EventArgs e)
        {
            Check_Card((Button)sender);
        }

        private void card8_Click(object sender, EventArgs e)
        {
            Check_Card((Button)sender);
        }


        private void Form20_Paint(object sender, PaintEventArgs e)
        {
            TwoCardSelect();
            if (cnt == 4)
            {
                MessageBox.Show("Clear!!!");
                Thread.Sleep(1000);
                Close();
            }
        }
    }


    public class Card
    {
        public Button bt;

        public bool Hide { get; set; }
        public int Check { get; set; }
        public System.Drawing.Image Topimg { get; set; }
        public System.Drawing.Image Backimg { get; set; }


        public Card() { Hide = true; }
        public Card(int c, System.Drawing.Image ipath, System.Drawing.Image backpath)
        {
            Check = c;
            Hide = true;
            Backimg = backpath;
            Topimg = ipath;
        }

    }

}
