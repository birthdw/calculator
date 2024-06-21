using Calculator;

namespace WinFormsApp1
{
    partial class Form20
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
            card1 = new System.Windows.Forms.Button();
            card2 = new System.Windows.Forms.Button();
            card3 = new System.Windows.Forms.Button();
            card4 = new System.Windows.Forms.Button();
            card8 = new System.Windows.Forms.Button();
            card7 = new System.Windows.Forms.Button();
            card6 = new System.Windows.Forms.Button();
            card5 = new System.Windows.Forms.Button();
            lb_cnt = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // card1
            // 
            card1.Image = Resources.cback;
            card1.Location = new System.Drawing.Point(67, 42);
            card1.Name = "card1";
            card1.Size = new System.Drawing.Size(104, 153);
            card1.TabIndex = 0;
            card1.Text = "card1";
            card1.UseVisualStyleBackColor = true;
            card1.Click += card1_Click;
            // 
            // card2
            // 
            card2.Image = Resources.cback;
            card2.Location = new System.Drawing.Point(177, 42);
            card2.Name = "card2";
            card2.Size = new System.Drawing.Size(104, 153);
            card2.TabIndex = 0;
            card2.Text = "card2";
            card2.UseVisualStyleBackColor = true;
            card2.Click += card2_Click;
            // 
            // card3
            // 
            card3.Image = Resources.cback;
            card3.Location = new System.Drawing.Point(287, 42);
            card3.Name = "card3";
            card3.Size = new System.Drawing.Size(104, 153);
            card3.TabIndex = 0;
            card3.Text = "card3";
            card3.UseVisualStyleBackColor = true;
            card3.Click += card3_Click;
            // 
            // card4
            // 
            card4.Image = Resources.cback;
            card4.Location = new System.Drawing.Point(397, 42);
            card4.Name = "card4";
            card4.Size = new System.Drawing.Size(104, 153);
            card4.TabIndex = 0;
            card4.Text = "card4";
            card4.UseVisualStyleBackColor = true;
            card4.Click += card4_Click;
            // 
            // card8
            // 
            card8.Image = Resources.cback;
            card8.Location = new System.Drawing.Point(397, 201);
            card8.Name = "card8";
            card8.Size = new System.Drawing.Size(104, 153);
            card8.TabIndex = 0;
            card8.Text = "card8";
            card8.UseVisualStyleBackColor = true;
            card8.Click += card8_Click;
            // 
            // card7
            // 
            card7.Image = Resources.cback;
            card7.Location = new System.Drawing.Point(287, 201);
            card7.Name = "card7";
            card7.Size = new System.Drawing.Size(104, 153);
            card7.TabIndex = 0;
            card7.Text = "card7";
            card7.UseVisualStyleBackColor = true;
            card7.Click += card7_Click;
            // 
            // card6
            // 
            card6.Image = Resources.cback;
            card6.Location = new System.Drawing.Point(177, 201);
            card6.Name = "card6";
            card6.Size = new System.Drawing.Size(104, 153);
            card6.TabIndex = 0;
            card6.Text = "card6";
            card6.UseVisualStyleBackColor = true;
            card6.Click += card6_Click;
            // 
            // card5
            // 
            card5.Image = Resources.cback;
            card5.Location = new System.Drawing.Point(67, 201);
            card5.Name = "card5";
            card5.Size = new System.Drawing.Size(104, 153);
            card5.TabIndex = 0;
            card5.Text = "card5";
            card5.UseVisualStyleBackColor = true;
            card5.Click += card5_Click;
            // 
            // lb_cnt
            // 
            lb_cnt.AutoSize = true;
            lb_cnt.Font = new System.Drawing.Font("맑은 고딕", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_cnt.Location = new System.Drawing.Point(224, 357);
            lb_cnt.Name = "lb_cnt";
            lb_cnt.Size = new System.Drawing.Size(76, 52);
            lb_cnt.TabIndex = 1;
            lb_cnt.Text = "cnt";
            // 
            // Form20
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(580, 413);
            Controls.Add(lb_cnt);
            Controls.Add(card5);
            Controls.Add(card6);
            Controls.Add(card7);
            Controls.Add(card8);
            Controls.Add(card4);
            Controls.Add(card3);
            Controls.Add(card2);
            Controls.Add(card1);
            Name = "Form20";
            Text = "Form20";
            Paint += Form20_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button card1;
        private System.Windows.Forms.Button card2;
        private System.Windows.Forms.Button card3;
        private System.Windows.Forms.Button card4;
        private System.Windows.Forms.Button card8;
        private System.Windows.Forms.Button card7;
        private System.Windows.Forms.Button card6;
        private System.Windows.Forms.Button card5;
        private System.Windows.Forms.Label lb_cnt;
    }
}