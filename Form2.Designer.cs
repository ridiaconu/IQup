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
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Location = new System.Drawing.Point(342, 114);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(49, 13);
            this.question.TabIndex = 0;
            this.question.Text = "Question";
            this.question.Click += new System.EventHandler(this.label1_Click);
            // 
            // ans1
            // 
            this.ans1.AutoSize = true;
            this.ans1.Location = new System.Drawing.Point(249, 174);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(67, 17);
            this.ans1.TabIndex = 1;
            this.ans1.Text = "Answer1";
            this.ans1.UseVisualStyleBackColor = true;
            this.ans1.CheckedChanged += new System.EventHandler(this.ans1_CheckedChanged);
            // 
            // ans2
            // 
            this.ans2.AutoSize = true;
            this.ans2.Location = new System.Drawing.Point(436, 174);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(67, 17);
            this.ans2.TabIndex = 2;
            this.ans2.Text = "Answer2";
            this.ans2.UseVisualStyleBackColor = true;
            this.ans2.CheckedChanged += new System.EventHandler(this.ans2_CheckedChanged);
            // 
            // ans3
            // 
            this.ans3.AutoSize = true;
            this.ans3.Location = new System.Drawing.Point(249, 257);
            this.ans3.Name = "ans3";
            this.ans3.Size = new System.Drawing.Size(67, 17);
            this.ans3.TabIndex = 3;
            this.ans3.Text = "Answer3";
            this.ans3.UseVisualStyleBackColor = true;
            this.ans3.CheckedChanged += new System.EventHandler(this.ans3_CheckedChanged);
            // 
            // ans4
            // 
            this.ans4.AutoSize = true;
            this.ans4.Location = new System.Drawing.Point(436, 257);
            this.ans4.Name = "ans4";
            this.ans4.Size = new System.Drawing.Size(67, 17);
            this.ans4.TabIndex = 4;
            this.ans4.Text = "Answer4";
            this.ans4.UseVisualStyleBackColor = true;
            this.ans4.CheckedChanged += new System.EventHandler(this.ans4_CheckedChanged);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(309, 341);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(137, 53);
            this.btn_next.TabIndex = 5;
            this.btn_next.Text = "Submit";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Enabled = false;
            this.score_lbl.Location = new System.Drawing.Point(306, 204);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(63, 13);
            this.score_lbl.TabIndex = 6;
            this.score_lbl.Text = "Your Score:";
            this.score_lbl.Visible = false;
            // 
            // displayscore_lbl
            // 
            this.displayscore_lbl.AutoSize = true;
            this.displayscore_lbl.Enabled = false;
            this.displayscore_lbl.ForeColor = System.Drawing.Color.Red;
            this.displayscore_lbl.Location = new System.Drawing.Point(397, 204);
            this.displayscore_lbl.Name = "displayscore_lbl";
            this.displayscore_lbl.Size = new System.Drawing.Size(33, 13);
            this.displayscore_lbl.TabIndex = 7;
            this.displayscore_lbl.Text = "score";
            this.displayscore_lbl.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayscore_lbl);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.ans4);
            this.Controls.Add(this.ans3);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.ans1);
            this.Controls.Add(this.question);
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
    }
}