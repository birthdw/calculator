namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new System.Windows.Forms.TextBox();
            bt_Left = new System.Windows.Forms.Button();
            bt_Right = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            rb_sci = new System.Windows.Forms.RadioButton();
            rb_nor = new System.Windows.Forms.RadioButton();
            bt_7 = new System.Windows.Forms.Button();
            bt_8 = new System.Windows.Forms.Button();
            bt_9 = new System.Windows.Forms.Button();
            bt_del = new System.Windows.Forms.Button();
            bt_ac = new System.Windows.Forms.Button();
            bt_4 = new System.Windows.Forms.Button();
            bt_5 = new System.Windows.Forms.Button();
            bt_6 = new System.Windows.Forms.Button();
            bt_multiply = new System.Windows.Forms.Button();
            bt_divide = new System.Windows.Forms.Button();
            bt_1 = new System.Windows.Forms.Button();
            bt_2 = new System.Windows.Forms.Button();
            bt_3 = new System.Windows.Forms.Button();
            bt_plus = new System.Windows.Forms.Button();
            bt_minus = new System.Windows.Forms.Button();
            bt_0 = new System.Windows.Forms.Button();
            bt_dot = new System.Windows.Forms.Button();
            bt_ans = new System.Windows.Forms.Button();
            bt_equal = new System.Windows.Forms.Button();
            bt_power = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            bt_Lbracket = new System.Windows.Forms.Button();
            bt_Rbracket = new System.Windows.Forms.Button();
            bt_M = new System.Windows.Forms.Button();
            bt_remember = new System.Windows.Forms.Button();
            bt_Upvalue = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            bt_MC = new System.Windows.Forms.Button();
            scientificGroup = new System.Windows.Forms.GroupBox();
            bt_acc = new System.Windows.Forms.Button();
            rb_tan = new System.Windows.Forms.RadioButton();
            rb_LognX = new System.Windows.Forms.RadioButton();
            rb_Cos = new System.Windows.Forms.RadioButton();
            rb_Log = new System.Windows.Forms.RadioButton();
            rb_Sin = new System.Windows.Forms.RadioButton();
            rb_Root = new System.Windows.Forms.RadioButton();
            rb_Pow = new System.Windows.Forms.RadioButton();
            rb_frac = new System.Windows.Forms.RadioButton();
            rb_squ = new System.Windows.Forms.RadioButton();
            rb_fac = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            미니게임ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            카드맞추기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            숫자야구ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            계산기사용법ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            사용법ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            groupBox2.SuspendLayout();
            scientificGroup.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("맑은 고딕", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(0, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(522, 77);
            textBox1.TabIndex = 0;
            // 
            // bt_Left
            // 
            bt_Left.Location = new System.Drawing.Point(172, 152);
            bt_Left.Name = "bt_Left";
            bt_Left.Size = new System.Drawing.Size(58, 23);
            bt_Left.TabIndex = 2;
            bt_Left.Text = "←";
            bt_Left.UseVisualStyleBackColor = true;
            bt_Left.Click += bt_Left_Click;
            // 
            // bt_Right
            // 
            bt_Right.Location = new System.Drawing.Point(260, 152);
            bt_Right.Name = "bt_Right";
            bt_Right.Size = new System.Drawing.Size(58, 23);
            bt_Right.TabIndex = 2;
            bt_Right.Text = "→";
            bt_Right.UseVisualStyleBackColor = true;
            bt_Right.Click += bt_Right_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rb_sci);
            groupBox2.Controls.Add(rb_nor);
            groupBox2.Location = new System.Drawing.Point(345, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(172, 51);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // rb_sci
            // 
            rb_sci.AutoSize = true;
            rb_sci.Location = new System.Drawing.Point(90, 22);
            rb_sci.Name = "rb_sci";
            rb_sci.Size = new System.Drawing.Size(72, 19);
            rb_sci.TabIndex = 0;
            rb_sci.TabStop = true;
            rb_sci.Text = "scientific";
            rb_sci.UseVisualStyleBackColor = true;
            rb_sci.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rb_nor
            // 
            rb_nor.AutoSize = true;
            rb_nor.Location = new System.Drawing.Point(6, 22);
            rb_nor.Name = "rb_nor";
            rb_nor.Size = new System.Drawing.Size(65, 19);
            rb_nor.TabIndex = 0;
            rb_nor.TabStop = true;
            rb_nor.Text = "Normal";
            rb_nor.UseVisualStyleBackColor = true;
            rb_nor.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // bt_7
            // 
            bt_7.Location = new System.Drawing.Point(8, 349);
            bt_7.Name = "bt_7";
            bt_7.Size = new System.Drawing.Size(98, 45);
            bt_7.TabIndex = 3;
            bt_7.Text = "7";
            bt_7.UseVisualStyleBackColor = true;
            bt_7.Click += bt_Num_Click;
            // 
            // bt_8
            // 
            bt_8.Location = new System.Drawing.Point(112, 349);
            bt_8.Name = "bt_8";
            bt_8.Size = new System.Drawing.Size(98, 45);
            bt_8.TabIndex = 3;
            bt_8.Text = "8";
            bt_8.UseVisualStyleBackColor = true;
            bt_8.Click += bt_Num_Click;
            // 
            // bt_9
            // 
            bt_9.Location = new System.Drawing.Point(216, 349);
            bt_9.Name = "bt_9";
            bt_9.Size = new System.Drawing.Size(98, 45);
            bt_9.TabIndex = 3;
            bt_9.Text = "9";
            bt_9.UseVisualStyleBackColor = true;
            bt_9.Click += bt_Num_Click;
            // 
            // bt_del
            // 
            bt_del.Location = new System.Drawing.Point(320, 349);
            bt_del.Name = "bt_del";
            bt_del.Size = new System.Drawing.Size(98, 45);
            bt_del.TabIndex = 3;
            bt_del.Text = "DEL";
            bt_del.UseVisualStyleBackColor = true;
            bt_del.Click += bt_del_Click;
            // 
            // bt_ac
            // 
            bt_ac.Location = new System.Drawing.Point(424, 349);
            bt_ac.Name = "bt_ac";
            bt_ac.Size = new System.Drawing.Size(98, 45);
            bt_ac.TabIndex = 3;
            bt_ac.Text = "AC";
            bt_ac.UseVisualStyleBackColor = true;
            bt_ac.Click += bt_ac_Click;
            // 
            // bt_4
            // 
            bt_4.Location = new System.Drawing.Point(10, 400);
            bt_4.Name = "bt_4";
            bt_4.Size = new System.Drawing.Size(98, 45);
            bt_4.TabIndex = 3;
            bt_4.Text = "4";
            bt_4.UseVisualStyleBackColor = true;
            bt_4.Click += bt_Num_Click;
            // 
            // bt_5
            // 
            bt_5.Location = new System.Drawing.Point(114, 400);
            bt_5.Name = "bt_5";
            bt_5.Size = new System.Drawing.Size(98, 45);
            bt_5.TabIndex = 3;
            bt_5.Text = "5";
            bt_5.UseVisualStyleBackColor = true;
            bt_5.Click += bt_Num_Click;
            // 
            // bt_6
            // 
            bt_6.Location = new System.Drawing.Point(218, 400);
            bt_6.Name = "bt_6";
            bt_6.Size = new System.Drawing.Size(98, 45);
            bt_6.TabIndex = 3;
            bt_6.Text = "6";
            bt_6.UseVisualStyleBackColor = true;
            bt_6.Click += bt_Num_Click;
            // 
            // bt_multiply
            // 
            bt_multiply.Location = new System.Drawing.Point(322, 400);
            bt_multiply.Name = "bt_multiply";
            bt_multiply.Size = new System.Drawing.Size(98, 45);
            bt_multiply.TabIndex = 3;
            bt_multiply.Text = "*";
            bt_multiply.UseVisualStyleBackColor = true;
            bt_multiply.Click += bt_multiply_Click;
            // 
            // bt_divide
            // 
            bt_divide.Location = new System.Drawing.Point(426, 400);
            bt_divide.Name = "bt_divide";
            bt_divide.Size = new System.Drawing.Size(98, 45);
            bt_divide.TabIndex = 3;
            bt_divide.Text = "/";
            bt_divide.UseVisualStyleBackColor = true;
            bt_divide.Click += bt_divide_Click;
            // 
            // bt_1
            // 
            bt_1.Location = new System.Drawing.Point(10, 451);
            bt_1.Name = "bt_1";
            bt_1.Size = new System.Drawing.Size(98, 45);
            bt_1.TabIndex = 3;
            bt_1.Text = "1";
            bt_1.UseVisualStyleBackColor = true;
            bt_1.Click += bt_Num_Click;
            // 
            // bt_2
            // 
            bt_2.Location = new System.Drawing.Point(114, 451);
            bt_2.Name = "bt_2";
            bt_2.Size = new System.Drawing.Size(98, 45);
            bt_2.TabIndex = 3;
            bt_2.Text = "2";
            bt_2.UseVisualStyleBackColor = true;
            bt_2.Click += bt_Num_Click;
            // 
            // bt_3
            // 
            bt_3.Location = new System.Drawing.Point(218, 451);
            bt_3.Name = "bt_3";
            bt_3.Size = new System.Drawing.Size(98, 45);
            bt_3.TabIndex = 3;
            bt_3.Text = "3";
            bt_3.UseVisualStyleBackColor = true;
            bt_3.Click += bt_Num_Click;
            // 
            // bt_plus
            // 
            bt_plus.Location = new System.Drawing.Point(322, 451);
            bt_plus.Name = "bt_plus";
            bt_plus.Size = new System.Drawing.Size(98, 45);
            bt_plus.TabIndex = 3;
            bt_plus.Text = "+";
            bt_plus.UseVisualStyleBackColor = true;
            bt_plus.Click += bt_plus_Click;
            // 
            // bt_minus
            // 
            bt_minus.Location = new System.Drawing.Point(426, 451);
            bt_minus.Name = "bt_minus";
            bt_minus.Size = new System.Drawing.Size(98, 45);
            bt_minus.TabIndex = 3;
            bt_minus.Text = "-";
            bt_minus.UseVisualStyleBackColor = true;
            bt_minus.Click += bt_minus_Click;
            // 
            // bt_0
            // 
            bt_0.Location = new System.Drawing.Point(10, 502);
            bt_0.Name = "bt_0";
            bt_0.Size = new System.Drawing.Size(98, 45);
            bt_0.TabIndex = 3;
            bt_0.Text = "0";
            bt_0.UseVisualStyleBackColor = true;
            bt_0.Click += bt_Num_Click;
            // 
            // bt_dot
            // 
            bt_dot.Location = new System.Drawing.Point(114, 502);
            bt_dot.Name = "bt_dot";
            bt_dot.Size = new System.Drawing.Size(98, 45);
            bt_dot.TabIndex = 3;
            bt_dot.Text = ".";
            bt_dot.UseVisualStyleBackColor = true;
            bt_dot.Click += bt_dot_Click;
            // 
            // bt_ans
            // 
            bt_ans.Location = new System.Drawing.Point(218, 502);
            bt_ans.Name = "bt_ans";
            bt_ans.Size = new System.Drawing.Size(98, 45);
            bt_ans.TabIndex = 3;
            bt_ans.Text = "ans";
            bt_ans.UseVisualStyleBackColor = true;
            bt_ans.Click += bt_ans_Click;
            // 
            // bt_equal
            // 
            bt_equal.Location = new System.Drawing.Point(426, 502);
            bt_equal.Name = "bt_equal";
            bt_equal.Size = new System.Drawing.Size(98, 45);
            bt_equal.TabIndex = 3;
            bt_equal.Text = "=";
            bt_equal.UseVisualStyleBackColor = true;
            bt_equal.Click += bt_equal_Click;
            // 
            // bt_power
            // 
            bt_power.Location = new System.Drawing.Point(186, 71);
            bt_power.Name = "bt_power";
            bt_power.Size = new System.Drawing.Size(72, 23);
            bt_power.TabIndex = 4;
            bt_power.Text = "^";
            bt_power.UseVisualStyleBackColor = true;
            bt_power.Click += bt_power_Click;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(320, 503);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(97, 44);
            button7.TabIndex = 4;
            button7.Text = "%";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // bt_Lbracket
            // 
            bt_Lbracket.Location = new System.Drawing.Point(33, 299);
            bt_Lbracket.Name = "bt_Lbracket";
            bt_Lbracket.Size = new System.Drawing.Size(72, 44);
            bt_Lbracket.TabIndex = 4;
            bt_Lbracket.Text = "(";
            bt_Lbracket.UseVisualStyleBackColor = true;
            bt_Lbracket.Click += bt_Lbracket_Click;
            // 
            // bt_Rbracket
            // 
            bt_Rbracket.Location = new System.Drawing.Point(111, 299);
            bt_Rbracket.Name = "bt_Rbracket";
            bt_Rbracket.Size = new System.Drawing.Size(72, 44);
            bt_Rbracket.TabIndex = 4;
            bt_Rbracket.Text = ")";
            bt_Rbracket.UseVisualStyleBackColor = true;
            bt_Rbracket.Click += bt_Rbracket_Click;
            // 
            // bt_M
            // 
            bt_M.Location = new System.Drawing.Point(267, 299);
            bt_M.Name = "bt_M";
            bt_M.Size = new System.Drawing.Size(72, 44);
            bt_M.TabIndex = 4;
            bt_M.Text = "M";
            bt_M.UseVisualStyleBackColor = true;
            bt_M.Click += bt_M_Click;
            // 
            // bt_remember
            // 
            bt_remember.Location = new System.Drawing.Point(345, 299);
            bt_remember.Name = "bt_remember";
            bt_remember.Size = new System.Drawing.Size(150, 44);
            bt_remember.TabIndex = 4;
            bt_remember.Text = "remember";
            bt_remember.UseVisualStyleBackColor = true;
            bt_remember.Click += bt_remember_Click;
            // 
            // bt_Upvalue
            // 
            bt_Upvalue.Location = new System.Drawing.Point(264, 71);
            bt_Upvalue.Name = "bt_Upvalue";
            bt_Upvalue.Size = new System.Drawing.Size(72, 23);
            bt_Upvalue.TabIndex = 4;
            bt_Upvalue.Text = "_";
            bt_Upvalue.UseVisualStyleBackColor = true;
            bt_Upvalue.Click += bt_Upvalue_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(17, 109);
            listBox1.Margin = new System.Windows.Forms.Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(127, 79);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // bt_MC
            // 
            bt_MC.Location = new System.Drawing.Point(189, 299);
            bt_MC.Name = "bt_MC";
            bt_MC.Size = new System.Drawing.Size(72, 44);
            bt_MC.TabIndex = 4;
            bt_MC.Text = "MC";
            bt_MC.UseVisualStyleBackColor = true;
            bt_MC.Click += bt_MC_Click;
            // 
            // scientificGroup
            // 
            scientificGroup.Controls.Add(bt_acc);
            scientificGroup.Controls.Add(rb_tan);
            scientificGroup.Controls.Add(rb_LognX);
            scientificGroup.Controls.Add(rb_Cos);
            scientificGroup.Controls.Add(rb_Log);
            scientificGroup.Controls.Add(rb_Sin);
            scientificGroup.Controls.Add(rb_Root);
            scientificGroup.Controls.Add(rb_Pow);
            scientificGroup.Controls.Add(rb_frac);
            scientificGroup.Controls.Add(rb_squ);
            scientificGroup.Controls.Add(rb_fac);
            scientificGroup.Controls.Add(bt_power);
            scientificGroup.Controls.Add(bt_Upvalue);
            scientificGroup.Location = new System.Drawing.Point(8, 201);
            scientificGroup.Name = "scientificGroup";
            scientificGroup.Size = new System.Drawing.Size(514, 100);
            scientificGroup.TabIndex = 6;
            scientificGroup.TabStop = false;
            // 
            // bt_acc
            // 
            bt_acc.Location = new System.Drawing.Point(342, 71);
            bt_acc.Name = "bt_acc";
            bt_acc.Size = new System.Drawing.Size(75, 23);
            bt_acc.TabIndex = 1;
            bt_acc.Text = "apply";
            bt_acc.UseVisualStyleBackColor = true;
            bt_acc.Click += bt_acc_Click;
            // 
            // rb_tan
            // 
            rb_tan.AutoSize = true;
            rb_tan.Location = new System.Drawing.Point(409, 47);
            rb_tan.Name = "rb_tan";
            rb_tan.Size = new System.Drawing.Size(44, 19);
            rb_tan.TabIndex = 0;
            rb_tan.TabStop = true;
            rb_tan.Text = "Tan";
            rb_tan.UseVisualStyleBackColor = true;
            rb_tan.CheckedChanged += rb_tan_CheckedChanged;
            // 
            // rb_LognX
            // 
            rb_LognX.AutoSize = true;
            rb_LognX.Location = new System.Drawing.Point(409, 22);
            rb_LognX.Name = "rb_LognX";
            rb_LognX.Size = new System.Drawing.Size(56, 19);
            rb_LognX.TabIndex = 0;
            rb_LognX.TabStop = true;
            rb_LognX.Text = "lognX";
            rb_LognX.UseVisualStyleBackColor = true;
            rb_LognX.CheckedChanged += rb_LognX_CheckedChanged;
            // 
            // rb_Cos
            // 
            rb_Cos.AutoSize = true;
            rb_Cos.Location = new System.Drawing.Point(309, 47);
            rb_Cos.Name = "rb_Cos";
            rb_Cos.Size = new System.Drawing.Size(45, 19);
            rb_Cos.TabIndex = 0;
            rb_Cos.TabStop = true;
            rb_Cos.Text = "Cos";
            rb_Cos.UseVisualStyleBackColor = true;
            rb_Cos.CheckedChanged += rb_Cos_CheckedChanged;
            // 
            // rb_Log
            // 
            rb_Log.AutoSize = true;
            rb_Log.Location = new System.Drawing.Point(309, 22);
            rb_Log.Name = "rb_Log";
            rb_Log.Size = new System.Drawing.Size(42, 19);
            rb_Log.TabIndex = 0;
            rb_Log.TabStop = true;
            rb_Log.Text = "log";
            rb_Log.UseVisualStyleBackColor = true;
            rb_Log.CheckedChanged += rb_Log_CheckedChanged;
            // 
            // rb_Sin
            // 
            rb_Sin.AutoSize = true;
            rb_Sin.Location = new System.Drawing.Point(208, 47);
            rb_Sin.Name = "rb_Sin";
            rb_Sin.Size = new System.Drawing.Size(42, 19);
            rb_Sin.TabIndex = 0;
            rb_Sin.TabStop = true;
            rb_Sin.Text = "Sin";
            rb_Sin.UseVisualStyleBackColor = true;
            rb_Sin.CheckedChanged += rb_Sin_CheckedChanged;
            // 
            // rb_Root
            // 
            rb_Root.AutoSize = true;
            rb_Root.Location = new System.Drawing.Point(107, 47);
            rb_Root.Name = "rb_Root";
            rb_Root.Size = new System.Drawing.Size(50, 19);
            rb_Root.TabIndex = 0;
            rb_Root.TabStop = true;
            rb_Root.Text = "Root";
            rb_Root.UseVisualStyleBackColor = true;
            rb_Root.CheckedChanged += rb_Root_CheckedChanged;
            // 
            // rb_Pow
            // 
            rb_Pow.AutoSize = true;
            rb_Pow.Location = new System.Drawing.Point(208, 22);
            rb_Pow.Name = "rb_Pow";
            rb_Pow.Size = new System.Drawing.Size(47, 19);
            rb_Pow.TabIndex = 0;
            rb_Pow.TabStop = true;
            rb_Pow.Text = "X^n";
            rb_Pow.UseVisualStyleBackColor = true;
            rb_Pow.CheckedChanged += rb_Pow_CheckedChanged;
            // 
            // rb_frac
            // 
            rb_frac.AutoSize = true;
            rb_frac.Location = new System.Drawing.Point(5, 47);
            rb_frac.Name = "rb_frac";
            rb_frac.Size = new System.Drawing.Size(51, 19);
            rb_frac.TabIndex = 0;
            rb_frac.TabStop = true;
            rb_frac.Text = "x^-1";
            rb_frac.UseVisualStyleBackColor = true;
            rb_frac.CheckedChanged += rb_frac_CheckedChanged;
            // 
            // rb_squ
            // 
            rb_squ.AutoSize = true;
            rb_squ.Location = new System.Drawing.Point(107, 22);
            rb_squ.Name = "rb_squ";
            rb_squ.Size = new System.Drawing.Size(47, 19);
            rb_squ.TabIndex = 0;
            rb_squ.TabStop = true;
            rb_squ.Text = "X^2";
            rb_squ.UseVisualStyleBackColor = true;
            rb_squ.CheckedChanged += rb_squ_CheckedChanged;
            // 
            // rb_fac
            // 
            rb_fac.AutoSize = true;
            rb_fac.Location = new System.Drawing.Point(5, 22);
            rb_fac.Name = "rb_fac";
            rb_fac.Size = new System.Drawing.Size(35, 19);
            rb_fac.TabIndex = 0;
            rb_fac.TabStop = true;
            rb_fac.Text = "X!";
            rb_fac.UseVisualStyleBackColor = true;
            rb_fac.CheckedChanged += rb_fac_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(150, 114);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 28);
            label1.TabIndex = 7;
            label1.Text = "Special";
            // 
            // textBox2
            // 
            textBox2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox2.Location = new System.Drawing.Point(225, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(297, 29);
            textBox2.TabIndex = 8;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 계산기사용법ToolStripMenuItem, 미니게임ToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(532, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // 미니게임ToolStripMenuItem
            // 
            미니게임ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { 카드맞추기ToolStripMenuItem, 숫자야구ToolStripMenuItem });
            미니게임ToolStripMenuItem.Name = "미니게임ToolStripMenuItem";
            미니게임ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            미니게임ToolStripMenuItem.Text = "미니게임";
            // 
            // 카드맞추기ToolStripMenuItem
            // 
            카드맞추기ToolStripMenuItem.Name = "카드맞추기ToolStripMenuItem";
            카드맞추기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            카드맞추기ToolStripMenuItem.Text = "카드맞추기";
            카드맞추기ToolStripMenuItem.Click += 카드맞추기ToolStripMenuItem_Click;
            // 
            // 숫자야구ToolStripMenuItem
            // 
            숫자야구ToolStripMenuItem.Name = "숫자야구ToolStripMenuItem";
            숫자야구ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            숫자야구ToolStripMenuItem.Text = "숫자야구";
            숫자야구ToolStripMenuItem.Click += 숫자야구ToolStripMenuItem_Click;
            // 
            // 계산기사용법ToolStripMenuItem
            // 
            계산기사용법ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { 사용법ToolStripMenuItem });
            계산기사용법ToolStripMenuItem.Name = "계산기사용법ToolStripMenuItem";
            계산기사용법ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            계산기사용법ToolStripMenuItem.Text = "계산기사용법";
            // 
            // 사용법ToolStripMenuItem
            // 
            사용법ToolStripMenuItem.Name = "사용법ToolStripMenuItem";
            사용법ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            사용법ToolStripMenuItem.Text = "사용법";
            사용법ToolStripMenuItem.Click += 사용법ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(532, 568);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(scientificGroup);
            Controls.Add(listBox1);
            Controls.Add(bt_remember);
            Controls.Add(bt_MC);
            Controls.Add(bt_M);
            Controls.Add(bt_Rbracket);
            Controls.Add(bt_Lbracket);
            Controls.Add(button7);
            Controls.Add(bt_equal);
            Controls.Add(bt_minus);
            Controls.Add(bt_divide);
            Controls.Add(bt_ac);
            Controls.Add(bt_ans);
            Controls.Add(bt_plus);
            Controls.Add(bt_multiply);
            Controls.Add(bt_del);
            Controls.Add(bt_dot);
            Controls.Add(bt_3);
            Controls.Add(bt_2);
            Controls.Add(bt_6);
            Controls.Add(bt_0);
            Controls.Add(bt_5);
            Controls.Add(bt_1);
            Controls.Add(bt_9);
            Controls.Add(bt_4);
            Controls.Add(bt_8);
            Controls.Add(bt_7);
            Controls.Add(bt_Right);
            Controls.Add(bt_Left);
            Controls.Add(groupBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "계산기";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            scientificGroup.ResumeLayout(false);
            scientificGroup.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_Left;
        private System.Windows.Forms.Button bt_Right;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_sci;
        private System.Windows.Forms.RadioButton rb_nor;
        private System.Windows.Forms.Button bt_7;
        private System.Windows.Forms.Button bt_8;
        private System.Windows.Forms.Button bt_9;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.Button bt_ac;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.Button bt_6;
        private System.Windows.Forms.Button bt_multiply;
        private System.Windows.Forms.Button bt_divide;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_plus;
        private System.Windows.Forms.Button bt_minus;
        private System.Windows.Forms.Button bt_0;
        private System.Windows.Forms.Button bt_dot;
        private System.Windows.Forms.Button bt_ans;
        private System.Windows.Forms.Button bt_equal;
        private System.Windows.Forms.Button bt_power;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button bt_Lbracket;
        private System.Windows.Forms.Button bt_Rbracket;
        private System.Windows.Forms.Button bt_M;
        private System.Windows.Forms.Button bt_remember;
        private System.Windows.Forms.Button bt_Upvalue;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_MC;
        private System.Windows.Forms.GroupBox scientificGroup;
        private System.Windows.Forms.RadioButton rb_tan;
        private System.Windows.Forms.RadioButton rb_LognX;
        private System.Windows.Forms.RadioButton rb_Cos;
        private System.Windows.Forms.RadioButton rb_Log;
        private System.Windows.Forms.RadioButton rb_Sin;
        private System.Windows.Forms.RadioButton rb_Root;
        private System.Windows.Forms.RadioButton rb_Pow;
        private System.Windows.Forms.RadioButton rb_frac;
        private System.Windows.Forms.RadioButton rb_squ;
        private System.Windows.Forms.RadioButton rb_fac;
        private System.Windows.Forms.Button bt_acc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 미니게임ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 카드맞추기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 숫자야구ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 계산기사용법ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용법ToolStripMenuItem;
    }
}
