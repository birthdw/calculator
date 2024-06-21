namespace WinFormsApp1
{
    partial class bt_bat
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
            components = new System.ComponentModel.Container();
            txt_Ans = new System.Windows.Forms.TextBox();
            Player = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            txt_bat = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            p1list = new System.Windows.Forms.ListBox();
            p2list = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // txt_Ans
            // 
            txt_Ans.Font = new System.Drawing.Font("맑은 고딕", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Ans.Location = new System.Drawing.Point(182, 9);
            txt_Ans.Name = "txt_Ans";
            txt_Ans.Size = new System.Drawing.Size(129, 48);
            txt_Ans.TabIndex = 0;
            // 
            // Player
            // 
            Player.AutoSize = true;
            Player.Font = new System.Drawing.Font("맑은 고딕", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Player.Location = new System.Drawing.Point(12, 9);
            Player.Name = "Player";
            Player.Size = new System.Drawing.Size(160, 52);
            Player.TabIndex = 1;
            Player.Text = "p1 num";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(329, 22);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(98, 35);
            button1.TabIndex = 2;
            button1.Text = "입력";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_bat
            // 
            txt_bat.Font = new System.Drawing.Font("맑은 고딕", 49F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_bat.Location = new System.Drawing.Point(29, 167);
            txt_bat.Name = "txt_bat";
            txt_bat.Size = new System.Drawing.Size(282, 94);
            txt_bat.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(329, 167);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(71, 94);
            button2.TabIndex = 4;
            button2.Text = "Bat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // p1list
            // 
            p1list.FormattingEnabled = true;
            p1list.ItemHeight = 15;
            p1list.Location = new System.Drawing.Point(499, 49);
            p1list.Name = "p1list";
            p1list.Size = new System.Drawing.Size(138, 379);
            p1list.TabIndex = 5;
            // 
            // p2list
            // 
            p2list.FormattingEnabled = true;
            p2list.ItemHeight = 15;
            p2list.Location = new System.Drawing.Point(656, 49);
            p2list.Name = "p2list";
            p2list.Size = new System.Drawing.Size(132, 379);
            p2list.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(499, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 36);
            label1.TabIndex = 6;
            label1.Text = "p1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("맑은 고딕", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(656, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 36);
            label2.TabIndex = 6;
            label2.Text = "p2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("맑은 고딕", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(19, 112);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(153, 52);
            label3.TabIndex = 1;
            label3.Text = "p1 turn";
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(33, 308);
            progressBar1.Maximum = 7;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(367, 49);
            progressBar1.TabIndex = 7;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // bt_bat
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(p2list);
            Controls.Add(p1list);
            Controls.Add(button2);
            Controls.Add(txt_bat);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(Player);
            Controls.Add(txt_Ans);
            Name = "bt_bat";
            Text = "Form13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txt_Ans;
        private System.Windows.Forms.Label Player;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_bat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox p1list;
        private System.Windows.Forms.ListBox p2list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}