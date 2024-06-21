using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;




namespace Calculator
{
    public partial class Form1 : Form
    {
        string remember = "";
        List<string> callist;
        int calidx = 0;
        bool bbracket = false;
        string ForSpecial = "";
        bool Rbswitch = false;

        public void textadd(double i)
        {
            string str = i.ToString();
            textBox1.Text += str;
        }

        public void textinsert(double i)
        {
            if (Rbswitch == true)
                Rtextinsert(i);

            string str = i.ToString();
            int line = textBox1.GetLineFromCharIndex(textBox1.SelectionStart);
            int column = textBox1.SelectionStart - textBox1.GetFirstCharIndexFromLine(line);
            textBox1.Text = textBox1.Text.Insert(column, str);
            textBox1.Select(textBox1.Text.Length, 0);
        }

        private int Factorial(int d)
        {
            if (d == 1)
                return 1;
            return d * Factorial(d - 1);
        }

        private string Factorial(string str)
        {
            int d = int.Parse(str);
            if (str == "1")
                return "1";
            return d.ToString() + "*" + (Factorial((d - 1).ToString()));
        }

        private double Power(string str)
        {
            string num = "";
            string power = "";
            int idx = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] == '^')
                {
                    idx = i;
                    break;
                }
                num += str[i];
            }
            for (int i = idx + 1; i < str.Length; ++i)
            {
                power += str[i];
            }

            double dnum = double.Parse(num);
            double dres = dnum;
            int dpower = int.Parse(power);

            for (int i = 0; i < dpower - 1; ++i)
            {
                dres *= dnum;
            }
            return dres;
        }

        private string Powerstr(string str)
        {
            string res = str;
            return res;
        }

        private double Log(string str)
        {
            double res = double.Parse(str);
            res = Math.Log10(res);
            return res;
        }

        private string Logstr(string str)
        {
            string res = "Log" + str;
            return res;
        }

        private double LognX(string str)
        {
            string num = "";
            string upval = "";
            int idx = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] == '_')
                {
                    idx = i;
                    break;
                }
                num += str[i];
            }
            for (int i = idx + 1; i < str.Length; ++i)
            {
                upval += str[i];
            }

            double dnum = double.Parse(num);
            double dupval = double.Parse(upval);
            double res = Math.Log(dupval, dnum);

            return res;
        }

        private string LognXstr(string str)
        {
            string res = "Log" + str;
            return res;
        }




        private double Fraction(string str)
        {
            double res = double.Parse(str);
            res = 1 / res;
            return res;
        }

        private string FractionStr(string str)
        {
            string res = str + "^-1";
            return res;
        }

        private double Root(string str)
        {
            double res = double.Parse(str);
            res = Math.Sqrt(res);
            return res;
        }

        private string RootString(string str)
        {
            string res = "√" + str;
            return res;
        }

        private double Sin(string str)
        {
            double res = double.Parse(str);
            res = Math.Sin(res * Math.PI / 180);
            return res;
        }

        private string SinString(string str)
        {
            string res = "Sin" + str;
            return res;
        }

        private double Cos(string str)
        {
            double res = double.Parse(str);
            res = Math.Cos(res * Math.PI / 180);
            return res;
        }

        private string CosString(string str)
        {
            string res = "Cos" + str;
            return res;
        }

        private double Tan(string str)
        {
            double res = double.Parse(str);
            res = Math.Tan(res * Math.PI / 180);
            return res;
        }

        private string TanString(string str)
        {
            string res = "Tan" + str;
            return res;
        }






        public void textadd(string str)
        {
            if (textBox1.Text.Length > 0)
            {
                string last = textBox1.Text[textBox1.Text.Length - 1].ToString();
                if (str != "-" && str != "(" && str != ")")
                {
                    if (last != "*" && last != "+" && last != "-" && last != "/")
                        textBox1.Text += str;
                }
                else
                    textBox1.Text += str;
            }
            else if (str == "-")
                textBox1.Text += str;

            textBox1.Select(textBox1.Text.Length, 0);

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            callist = new List<string>();

            rb_nor.Checked = true;
            listBox1.Text = "";

            scientificGroup.Visible = false;
            bt_Lbracket.Visible = false;
            bt_Rbracket.Visible = false;
            bt_M.Visible = false;
            bt_remember.Visible = false;
            bt_Upvalue.Visible = false;
            bt_power.Visible = false;
            bt_MC.Visible = false;

            label1.Visible = false;
            textBox2.Visible = false;
        }

        private void bt_Num_Click(object sender, EventArgs e)
        {
            double Number = double.Parse(((System.Windows.Forms.Button)sender).Text);
            //textadd(Number);
            textinsert(Number);
        }

        private void bt_remember_Click(object sender, EventArgs e)
        {
            textBox1.Text = remember;
        }

        private void bt_multiply_Click(object sender, EventArgs e)
        {
            textadd("*");
        }

        private void bt_plus_Click(object sender, EventArgs e)
        {
            textadd("+");
        }

        private void bt_divide_Click(object sender, EventArgs e)
        {
            textadd("/");
        }

        private void bt_minus_Click(object sender, EventArgs e)
        {
            textadd("-");
        }

        private void bt_dot_Click(object sender, EventArgs e)
        {
            textadd(".");
        }
        private void bt_ac_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);   //삭제
        }

        private void bt_Rbracket_Click(object sender, EventArgs e)
        {
            textadd(")");
        }

        private void bt_Lbracket_Click(object sender, EventArgs e)
        {
            textadd("(");

        }


        private string Bracket(string str)
        {
            string res = str;
            string temp;
            int idx = 0;
            bbracket = true;
            while (true)
            {
                if (idx == res.Length) { break; }


                if (res[idx] == '(')
                {
                    temp = res.Substring(idx + 1);
                    res = res.Remove(idx, res.Length - idx);
                    res += Bracket(temp);    //(속에서 (를 또 있는지 뒤에 )가 있으면 그 결과를 출력 
                }
                else if (res[idx] == ')')            // )찾으면 탈출
                {
                    temp = res.Substring(idx + 1);
                    int templength = res.Length;
                    res = res.Substring(0, idx);
                    int templength2 = res.Length;

                    res = Calculate(res);
                    res += temp;
                    break;
                }
                ++idx;
            }

            bbracket = false;
            return res;
        }


        private string Calculate(string str)
        {
            if (str == "")
                return "";

            callist.Add(str);
            listBox1.Items.Add(str);
            calidx++;
            if (bbracket == false)
                remember = str;


            string equation = str;
            List<string> strlist = new List<string>();
            List<string> signlist = new List<string>();
            double res = 0;
            int digit = 0; //숫자를 어디까지 저장해야 하나의 자릿수
            while (digit < equation.Length)   //그냥 반복 
            {

                if (equation.Contains("(") || equation.Contains(")"))
                {
                    equation = Bracket(equation);
                }


                if (equation[0] == '-')                     //하.. -부호도 생각해야한다   이 로직에선 계속 앞을 제거해주기에 맨처음이 -인지만 검사하면된다.
                {
                    int temp = 1;         //맨앞부호 제외 1부터
                    while (true)
                    {
                        if (equation.Substring(1).Contains('+') || equation.Substring(1).Contains('-') ||
                            equation.Substring(1).Contains('*') || equation.Substring(1).Contains('/') || equation.Substring(1).Contains('%'))      //맨첫 -부호를 제외후 다음으로나오는 연산이 있는가?
                        {
                            if (equation[temp].Equals('+') || equation[temp].Equals('-') || equation[temp].Equals('*') || equation[temp].Equals('/') || equation.Substring(1).Contains('%')) //있다면 그 부호는 무엇인가?
                            {
                                strlist.Add(equation.Substring(0, temp));                //있을시 -부터 temp는 digit마냥 자릿수 다음 부호를 만나기전까지 저장
                                signlist.Add(equation[temp].ToString());                 //다음 부호 저장.
                                equation = equation.Substring(temp + 1);                 //원본 문장 수정 부호다음부터 끝까지 다시 저장.
                                break;
                            }
                            else
                                ++temp;    //부호를 만날때까지 자릿수 증가 
                        }
                        else   // 만약에 부호가 나오지 않았다?  그럼 해당 음수가 혼자 남은 상태이다.
                        {

                            strlist.Add(equation.Substring(0, equation.Length));    //기호를 더이상 찾지못하고 나온 자릿수까지 저장.
                            equation = "";   //문장 공백으로 초기화
                            break;
                        }
                    }
                    --digit;    //digit은 밑에서만 사용하기에 밑에서 ++해서 하나 줄여준다. 
                }
                else if (equation[digit].Equals('+') || equation[digit].Equals('-') || equation[digit].Equals('*') || equation[digit].Equals('/') || equation.Substring(1).Contains('%'))   //처음이 음수가아닌수가 들어올시.
                {
                    strlist.Add(equation.Substring(0, digit));    //기호전까지 저장
                    signlist.Add(equation[digit].ToString());     //기호를 저장
                    equation = equation.Substring(digit + 1);      // 원본 문장 수정 부호다음부터 끝까지 다시 저장.
                    digit = 0;  //지웟으니 자릿수 초기화
                    continue;
                }
                ++digit;
            }

            // 만약 digit이 length까지 갔을때라면 더이상 만나는 부호가 없음으로 반복은 종료.
            //남은 equation 내의 식을 숫자 리스트에 넣어줘야한다. 

            if (equation != "")           //단 음수일시 ""로 초기화 하기에 체크문
                strlist.Add(equation.Substring(0, digit));    //기호를 더이상 찾지못하고 나온 자릿수까지 저장.



            int idx = 0;
            double tmp = 0;

            while (idx < signlist.Count)               //사칙연산의 우선순위를 위해 */를 찾는 반복이다.  카운트는 부호의 갯수.
            {
                if (signlist[idx] == "*")
                {
                    tmp = double.Parse(strlist[idx]) * double.Parse(strlist[idx + 1]);            //먼저 해당 인덱스의 곱진행 / 첫번째 부호는 당연히 첫번째숫자와 그다음 숫자의 계산일것이다.
                    strlist.Insert(idx, tmp.ToString());                                    //해당 인덱스에 값을 곱이 진행된 값을 인서트 
                    strlist.RemoveAt(idx + 1);                                              //곱이 이미 진행되버린 인서트로인해 밀려난 값들을 삭제한다.  
                    strlist.RemoveAt(idx + 1);                                              //삭제시 자동으로 인덱스가 줄기에 똑같이 idx+1로 삭제.
                    signlist.RemoveAt(idx);                                                 //부호리스트에서 계산된 부호 삭제.
                    --idx;                                                                  //삭제했으니 인덱스 1감소.
                }
                else if (signlist[idx] == "/")
                {
                    tmp = double.Parse(strlist[idx]) / double.Parse(strlist[idx + 1]);                //마찬가지 
                    strlist.Insert(idx, tmp.ToString());
                    strlist.RemoveAt(idx + 1);
                    strlist.RemoveAt(idx + 1);
                    signlist.RemoveAt(idx);
                    --idx;
                }
                else if (signlist[idx] == " %")
                {
                    tmp = double.Parse(strlist[idx]) % double.Parse(strlist[idx + 1]);                //마찬가지 
                    strlist.Insert(idx, tmp.ToString());
                    strlist.RemoveAt(idx + 1);
                    strlist.RemoveAt(idx + 1);
                    signlist.RemoveAt(idx);
                    --idx;
                }
                ++idx;
            }


            res = double.Parse(strlist[0]);                                   //첫 계산할 값 넣어줌.
            strlist.RemoveAt(0);                                           //리스트에서 삭제

            while (strlist.Count != 0)                                     //계산할 값이 없을때까지 반복 
            {
                switch (signlist[0])
                {
                    case "+":                                             //부호기준 값 추가 이미 */ 계산은 위에서 끝내서 통으로 저장해 놓은 상태이니 단순 덧 뺄셈만 하면된다.
                        res += double.Parse(strlist[0]);
                        strlist.RemoveAt(0);                              //계산된 값 제거
                        break;
                    case "-":
                        res -= double.Parse(strlist[0]);             //마찬가지
                        strlist.RemoveAt(0);
                        break;
                }
                signlist.RemoveAt(0);                         //계산된 부호 제거.
            }

            return res.ToString();                  //마지막에 나온 result값을 텍스트에 전달. 
        }




        private void bt_equal_Click(object sender, EventArgs e)
        {
            textBox1.Text = Calculate(textBox1.Text);
        }

        private void bt_Left_Click(object sender, EventArgs e)
        {
            int line = textBox1.GetLineFromCharIndex(textBox1.SelectionStart);
            int column = textBox1.SelectionStart - textBox1.GetFirstCharIndexFromLine(line);
            if (column - 1 < 0)
                column = 1;
            textBox1.Select(column - 1, 0);
        }

        private void bt_Right_Click(object sender, EventArgs e)
        {
            int line = textBox1.GetLineFromCharIndex(textBox1.SelectionStart);
            int column = textBox1.SelectionStart - textBox1.GetFirstCharIndexFromLine(line);

            if (column == textBox1.Text.Length)
                column -= 1;
            textBox1.Select(column + 1, 0);
        }



        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_nor.Checked == true)
            {
                bt_Lbracket.Visible = false;
                bt_Rbracket.Visible = false;
                bt_M.Visible = false;
                bt_remember.Visible = false;
                bt_Upvalue.Visible = false;
                bt_power.Visible = false;
                bt_MC.Visible = false;
                scientificGroup.Visible = false;
                label1.Visible = false;
                textBox2.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_sci.Checked == true)
            {
                bt_Lbracket.Visible = true;
                bt_Rbracket.Visible = true;
                bt_M.Visible = true;
                bt_remember.Visible = true;
                bt_Upvalue.Visible = true;
                bt_power.Visible = true;
                scientificGroup.Visible = true;
                bt_MC.Visible = true;
                label1.Visible = true;
                textBox2.Visible = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void bt_ans_Click(object sender, EventArgs e)
        {
            textBox1.Text = Calculate(callist[calidx - 1]);
            callist.RemoveAt(calidx - 1);
            listBox1.Items.RemoveAt(calidx - 1);
            calidx--;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textadd("%");
        }

        private void bt_M_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void bt_MC_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }



        public void Rtextinsert(double i)
        {
            string str = i.ToString();
            ForSpecial += str;

            if (rb_fac.Checked == true)
            {
                textBox2.Text = Factorial(ForSpecial);
            }
            else if (rb_squ.Checked == true)
            {
                textBox2.Text = ForSpecial + "^2";
            }
            else if (rb_Pow.Checked == true)
            {
                textBox2.Text = Powerstr(ForSpecial);
            }
            else if (rb_Log.Checked == true)
            {
                textBox2.Text = Logstr(ForSpecial);
            }
            else if (rb_LognX.Checked == true)
            {
                textBox2.Text = LognXstr(ForSpecial);
            }
            else if (rb_frac.Checked == true)
            {
                textBox2.Text = FractionStr(ForSpecial);
            }
            else if (rb_Root.Checked == true)
            {
                textBox2.Text = RootString(ForSpecial);
            }
            else if (rb_Sin.Checked == true)
            {
                textBox2.Text = SinString(ForSpecial);
            }
            else if (rb_Cos.Checked == true)
            {
                textBox2.Text = CosString(ForSpecial);
            }
            else if (rb_tan.Checked == true)
            {
                textBox2.Text = TanString(ForSpecial);
            }
        }


        private void bt_acc_Click(object sender, EventArgs e)
        {
            string res = "";

            if (rb_fac.Checked == true)
            {
                res = Factorial(int.Parse(ForSpecial)).ToString();

                rb_fac.Checked = false;

            }
            else if (rb_squ.Checked == true)
            {
                res = Math.Pow(double.Parse(ForSpecial), 2).ToString();
                rb_squ.Checked = false;
            }
            else if (rb_Pow.Checked == true)
            {
                res = Power(ForSpecial).ToString();
                rb_Pow.Checked = false;
                ForSpecial = ForSpecial.Remove(0, 1);
            }
            else if (rb_Log.Checked == true)
            {
                res = Log(ForSpecial).ToString();
                rb_Log.Checked = false;
            }
            else if (rb_LognX.Checked == true)
            {
                res = LognX(ForSpecial).ToString();
                rb_LognX.Checked = false;
                ForSpecial = ForSpecial.Remove(0, 1);
            }
            else if (rb_frac.Checked == true)
            {
                res = Fraction(ForSpecial).ToString();
                rb_frac.Checked = false;
            }
            else if (rb_Root.Checked == true)
            {
                res = Root(ForSpecial).ToString();
                rb_Root.Checked = false;
            }
            else if (rb_Sin.Checked == true)
            {
                res = Sin(ForSpecial).ToString();
                rb_Sin.Checked = false;
            }
            else if (rb_Cos.Checked == true)
            {
                res = Cos(ForSpecial).ToString();
                rb_Cos.Checked = false;
            }
            else if (rb_tan.Checked == true)
            {
                res = Tan(ForSpecial).ToString();
                rb_tan.Checked = false;
            }


            for (int i = 0; i < ForSpecial.Length; ++i)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);

            textBox1.Text += res;
            ForSpecial = "";
            label1.Text = "Special";
            textBox2.Text = "";
            Rbswitch = false;
            int line = textBox1.GetLineFromCharIndex(textBox1.SelectionStart);
            int column = textBox1.SelectionStart - textBox1.GetFirstCharIndexFromLine(line);
            textBox1.Select(column + 1, 0);
        }

        private void rb_fac_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = rb_fac.Text;
            Rbswitch = true;
        }

        private void rb_squ_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = rb_squ.Text;
            Rbswitch = true;
        }

        private void rb_Pow_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = rb_Pow.Text;
            Rbswitch = true;
        }

        private void bt_power_Click(object sender, EventArgs e)
        {
            if (Rbswitch == true && rb_Pow.Checked == true)
            {
                if (ForSpecial[ForSpecial.Length - 1] != '^')
                    ForSpecial += "^";
                textBox2.Text = ForSpecial;
            }
        }
        private void bt_Upvalue_Click(object sender, EventArgs e)
        {
            if (Rbswitch == true && rb_LognX.Checked == true)
            {
                if (ForSpecial[ForSpecial.Length - 1] != '_')
                    ForSpecial += "_";
                textBox2.Text = "Log" + ForSpecial;
            }
        }



        private void rb_Log_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = rb_Log.Text;
            Rbswitch = true;
        }

        private void rb_LognX_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = rb_LognX.Text;
            Rbswitch = true;
        }

        private void rb_frac_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = rb_frac.Text;
            Rbswitch = true;
        }

        private void rb_Root_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = rb_Root.Text;
            Rbswitch = true;
        }

        private void rb_Sin_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = rb_Sin.Text;
            Rbswitch = true;
        }

        private void rb_Cos_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = rb_Cos.Text;
            Rbswitch = true;
        }

        private void rb_tan_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = rb_tan.Text;
            Rbswitch = true;
        }



        private void 카드맞추기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Card = new Form20();
            Card.Show();
        }

        private void 숫자야구ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Card = new bt_bat();
            Card.Show();
        }

        private void 사용법ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("특수 기호 사용시\n1.사용하려는 라디오버튼체크 \n2.제곱은 숫자와^숫자 로그는 숫자_로그 입력\n3.apply버튼 클릭");
        }
    }
}
