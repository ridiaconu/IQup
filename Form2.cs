using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Reflection;
namespace IQup
{
    public partial class Form2 : Form
    {
        
        int i = 1;
        bool A1, A2, A3, A4;
        float score = 0;
        //string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tests\test.json");
        //string[] files = File.ReadAllText(path);
        public string testname;
        dynamic jsonFile;

        
        public Form2(string testname)
        {
            InitializeComponent();
            this.testname = testname;
            jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(testname));
            Get_Question();


        }

        private void Get_Question()
        {
            string Question_num = "Q" + i.ToString();
            question.Text = jsonFile[Question_num]["Statement"];
            bool mAns = jsonFile[Question_num]["MultipleAnswers"];
            if(mAns==false)
            {
                ans1.Enabled = false;
                ans1.Visible = false;
                ans1.Checked = false;
                ans2.Enabled = false;
                ans2.Visible = false;
                ans2.Checked = false;
                ans3.Enabled = false;
                ans3.Visible = false;
                ans3.Checked = false;
                ans4.Enabled = false;
                ans4.Visible = false;
                ans4.Checked = false;
                ans1_radio.Enabled = true;
                ans1_radio.Visible = true;
                ans1_radio.Text = jsonFile[Question_num]["A1"];
                ans1_radio.Checked = false;
                ans2_radio.Enabled = true;
                ans2_radio.Visible = true;
                ans2_radio.Text = jsonFile[Question_num]["A2"];
                ans2_radio.Checked = false;
                ans3_radio.Enabled = true;
                ans3_radio.Visible = true;
                ans3_radio.Text = jsonFile[Question_num]["A3"];
                ans3_radio.Checked = false;
                ans4_radio.Enabled = true;
                ans4_radio.Visible = true;
                ans4_radio.Text = jsonFile[Question_num]["A4"];
                ans4_radio.Checked = false;

            }
            else
            {
                ans1_radio.Enabled = false;
                ans1_radio.Visible = false;
                ans1_radio.Checked = false;
                ans2_radio.Enabled = false;
                ans2_radio.Visible = false;
                ans2_radio.Checked = false;
                ans3_radio.Enabled = false;
                ans3_radio.Visible = false;
                ans3_radio.Checked = false;
                ans4_radio.Enabled = false;
                ans4_radio.Visible = false;
                ans4_radio.Checked = false;
                ans1.Enabled = true;
                ans1.Visible = true;
                ans1.Text = jsonFile[Question_num]["A1"];
                ans1.Checked = false;
                ans2.Enabled = true;
                ans2.Visible = true;
                ans2.Text = jsonFile[Question_num]["A2"];
                ans2.Checked = false;
                ans3.Enabled = true;
                ans3.Visible = true;
                ans3.Text = jsonFile[Question_num]["A3"];
                ans3.Checked = false;
                ans4.Enabled = true;
                ans4.Visible = true;
                ans4.Text = jsonFile[Question_num]["A4"];
                ans4.Checked = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ans2_CheckedChanged(object sender, EventArgs e)
        {
            if(ans2.Checked==true)
            {
                A2 = true;
            }
            else
            {
                A2 = false;
            }
        }

        private void ans3_CheckedChanged(object sender, EventArgs e)
        {
            if(ans3.Checked==true)
            {
                A3 = true;
            }
            else
            {
                A3 = false;
            }
        }

        private void ans4_CheckedChanged(object sender, EventArgs e)
        {
            if(ans4.Checked==true)
            {
                A4 = true;
            }
            else
            {
                A4 = false;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (btn_next.Text == "Finish Test")
            {
                System.Windows.Forms.Application.Exit();
            }
            ansval();
            int ilimit = jsonFile["NoQuestions"];
            if (i + 1 <= ilimit)
            {
                i++;
                Get_Question();
            }
            else
            {
                scorecheck();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = jsonFile["Testname"];
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ans1_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (ans1_radio.Checked == true)
            {
                A1 = true;
            }
            else
            {
                A1 = false;
            }
        }

        private void ans2_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (ans2_radio.Checked == true)
            {
                A2 = true;
            }
            else
            {
                A2 = false;
            }
        }

        private void ans3_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (ans3_radio.Checked == true)
            {
                A3 = true;
            }
            else
            {
                A3 = false;
            }
        }

        private void ans4_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (ans4_radio.Checked == true)
            {
                A4 = true;
            }
            else
            {
                A4 = false;
            }
        }

        private void ans1_CheckedChanged(object sender, EventArgs e)
        {
            if (ans1.Checked==true)
            {
                A1 = true;
            }
            else
            {
                A1 = false;
            }
              
        }

        private void ansval()
        {
            bool corect = true;
            string Question_num = "Q" + i.ToString();
            bool G1 = jsonFile[Question_num]["CorrectAnswers"]["A1"];
            bool G2 = jsonFile[Question_num]["CorrectAnswers"]["A2"];
            bool G3 = jsonFile[Question_num]["CorrectAnswers"]["A3"];
            bool G4 = jsonFile[Question_num]["CorrectAnswers"]["A4"];
            if (A1 != G1)
            {
                corect = false;
            }
            if (A2 != G2)
            {
                corect = false;
            }
            if (A3 != G3)
            {
                corect = false;
            }
            if (A4 != G4)
            {
                corect = false;
            }
            if(corect==true)
            {
                MessageBox.Show("Correct!", "Message", MessageBoxButtons.OK);
                score++;
            }
            else
            {
                MessageBox.Show("Wrong!", "Message", MessageBoxButtons.OK);
            }

        }

        private void scorecheck()
        {
            question.Enabled = false;
            question.Visible = false;
            ans1.Enabled = false;
            ans1.Visible = false;
            ans2.Enabled = false;
            ans2.Visible = false;
            ans3.Enabled = false;
            ans3.Visible = false;
            ans4.Enabled = false;
            ans4.Visible = false;
            ans1_radio.Enabled = false;
            ans2_radio.Enabled = false;
            ans3_radio.Enabled = false;
            ans4_radio.Enabled = false;
            ans1_radio.Visible = false;
            ans2_radio.Visible = false;
            ans3_radio.Visible = false;
            ans4_radio.Visible = false;
            btn_next.Text = "Finish Test";
            float noquestions = jsonFile["NoQuestions"];
            float totalscore = (score / noquestions) * 100;
            Math.Round(totalscore, 1);
            score_lbl.Enabled = true;
            score_lbl.Visible = true;
            string displayscore = totalscore.ToString();
            String.Format("{0:0.##}", displayscore);
            displayscore = displayscore + "%";
            displayscore_lbl.Text = displayscore;
            displayscore_lbl.Visible = true;
            displayscore_lbl.Enabled = true;
        }
    }
}
