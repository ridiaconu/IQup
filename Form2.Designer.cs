namespace IQup
{
    partial class Form2
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
            this.question = new System.Windows.Forms.Label();
            this.ans1 = new System.Windows.Forms.CheckBox();
            this.ans2 = new System.Windows.Forms.CheckBox();
            this.ans3 = new System.Windows.Forms.CheckBox();
            this.ans4 = new System.Windows.Forms.CheckBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.score_lbl = new System.Windows.Forms.Label();
            this.displayscore_lbl = new System.Windows.Forms.Label();
            this.ans1_radio = new System.Windows.Forms.RadioButton();
            this.ans2_radio = new System.Windows.Forms.RadioButton();
            this.ans3_radio = new System.Windows.Forms.RadioButton();
            this.ans4_radio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Location = new System.Drawing.Point(456, 140);
            this.question.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(60, 16);
            this.question.TabIndex = 0;
            this.question.Text = "Question";
            this.question.Click += new System.EventHandler(this.label1_Click);
            // 
            // ans1
            // 
            this.ans1.AutoSize = true;
            this.ans1.Location = new System.Drawing.Point(332, 214);
            this.ans1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(80, 20);
            this.ans1.TabIndex = 1;
            this.ans1.Text = "Answer1";
            this.ans1.UseVisualStyleBackColor = true;
            this.ans1.CheckedChanged += new System.EventHandler(this.ans1_CheckedChanged);
            // 
            // ans2
            // 
            this.ans2.AutoSize = true;
            this.ans2.Location = new System.Drawing.Point(581, 214);
            this.ans2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(80, 20);
            this.ans2.TabIndex = 2;
            this.ans2.Text = "Answer2";
            this.ans2.UseVisualStyleBackColor = true;
            this.ans2.CheckedChanged += new System.EventHandler(this.ans2_CheckedChanged);
            // 
            // ans3
            // 
            this.ans3.AutoSize = true;
            this.ans3.Location = new System.Drawing.Point(332, 316);
            this.ans3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ans3.Name = "ans3";
            this.ans3.Size = new System.Drawing.Size(80, 20);
            this.ans3.TabIndex = 3;
            this.ans3.Text = "Answer3";
            this.ans3.UseVisualStyleBackColor = true;
            this.ans3.CheckedChanged += new System.EventHandler(this.ans3_CheckedChanged);
            // 
            // ans4
            // 
            this.ans4.AutoSize = true;
            this.ans4.Location = new System.Drawing.Point(581, 316);
            this.ans4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ans4.Name = "ans4";
            this.ans4.Size = new System.Drawing.Size(80, 20);
            this.ans4.TabIndex = 4;
            this.ans4.Text = "Answer4";
            this.ans4.UseVisualStyleBackColor = true;
            this.ans4.CheckedChanged += new System.EventHandler(this.ans4_CheckedChanged);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(412, 420);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(183, 65);
            this.btn_next.TabIndex = 5;
            this.btn_next.Text = "Submit";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Enabled = false;
            this.score_lbl.Location = new System.Drawing.Point(408, 251);
            this.score_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(77, 16);
            this.score_lbl.TabIndex = 6;
            this.score_lbl.Text = "Your Score:";
            this.score_lbl.Visible = false;
            // 
            // displayscore_lbl
            // 
            this.displayscore_lbl.AutoSize = true;
            this.displayscore_lbl.Enabled = false;
            this.displayscore_lbl.ForeColor = System.Drawing.Color.Red;
            this.displayscore_lbl.Location = new System.Drawing.Point(529, 251);
            this.displayscore_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayscore_lbl.Name = "displayscore_lbl";
            this.displayscore_lbl.Size = new System.Drawing.Size(41, 16);
            this.displayscore_lbl.TabIndex = 7;
            this.displayscore_lbl.Text = "score";
            this.displayscore_lbl.Visible = false;
            // 
            // ans1_radio
            // 
            this.ans1_radio.AutoSize = true;
            this.ans1_radio.Location = new System.Drawing.Point(332, 214);
            this.ans1_radio.Name = "ans1_radio";
            this.ans1_radio.Size = new System.Drawing.Size(79, 20);
            this.ans1_radio.TabIndex = 8;
            this.ans1_radio.TabStop = true;
            this.ans1_radio.Text = "Answer1";
            this.ans1_radio.UseVisualStyleBackColor = true;
            this.ans1_radio.CheckedChanged += new System.EventHandler(this.ans1_radio_CheckedChanged);
            // 
            // ans2_radio
            // 
            this.ans2_radio.AutoSize = true;
            this.ans2_radio.Location = new System.Drawing.Point(581, 214);
            this.ans2_radio.Name = "ans2_radio";
            this.ans2_radio.Size = new System.Drawing.Size(79, 20);
            this.ans2_radio.TabIndex = 9;
            this.ans2_radio.TabStop = true;
            this.ans2_radio.Text = "Answer2";
            this.ans2_radio.UseVisualStyleBackColor = true;
            this.ans2_radio.CheckedChanged += new System.EventHandler(this.ans2_radio_CheckedChanged);
            // 
            // ans3_radio
            // 
            this.ans3_radio.AutoSize = true;
            this.ans3_radio.Location = new System.Drawing.Point(332, 316);
            this.ans3_radio.Name = "ans3_radio";
            this.ans3_radio.Size = new System.Drawing.Size(79, 20);
            this.ans3_radio.TabIndex = 10;
            this.ans3_radio.TabStop = true;
            this.ans3_radio.Text = "Answer3";
            this.ans3_radio.UseVisualStyleBackColor = true;
            this.ans3_radio.CheckedChanged += new System.EventHandler(this.ans3_radio_CheckedChanged);
            // 
            // ans4_radio
            // 
            this.ans4_radio.AutoSize = true;
            this.ans4_radio.Location = new System.Drawing.Point(581, 316);
            this.ans4_radio.Name = "ans4_radio";
            this.ans4_radio.Size = new System.Drawing.Size(79, 20);
            this.ans4_radio.TabIndex = 11;
            this.ans4_radio.TabStop = true;
            this.ans4_radio.Text = "Answer4";
            this.ans4_radio.UseVisualStyleBackColor = true;
            this.ans4_radio.CheckedChanged += new System.EventHandler(this.ans4_radio_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ans4_radio);
            this.Controls.Add(this.ans3_radio);
            this.Controls.Add(this.ans2_radio);
            this.Controls.Add(this.ans1_radio);
            this.Controls.Add(this.displayscore_lbl);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.ans4);
            this.Controls.Add(this.ans3);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.ans1);
            this.Controls.Add(this.question);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IQup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.CheckBox ans1;
        private System.Windows.Forms.CheckBox ans2;
        private System.Windows.Forms.CheckBox ans3;
        private System.Windows.Forms.CheckBox ans4;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label displayscore_lbl;
        private System.Windows.Forms.RadioButton ans1_radio;
        private System.Windows.Forms.RadioButton ans2_radio;
        private System.Windows.Forms.RadioButton ans3_radio;
        private System.Windows.Forms.RadioButton ans4_radio;
    }
}