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

namespace IQup
{
    public partial class Form2 : Form
    {
        int i = 1;
        bool A1, A2, A3, A4;
        dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText("D:\\Code\\IQup\\test.json")); // to be replaced with relative path
        public Form2()
        {
            InitializeComponent();
            Get_Question();


        }

        private void Get_Question()
        {
            string Question_num = "Q" + i.ToString();
            question.Text = jsonFile[Question_num]["Statement"];
            ans1.Text = jsonFile[Question_num]["A1"];
            ans1.Checked = false;
            ans2.Text = jsonFile[Question_num]["A2"];
            ans2.Checked = false;
            ans3.Text = jsonFile[Question_num]["A3"];
            ans3.Checked = false;
            ans4.Text = jsonFile[Question_num]["A4"];
            ans4.Checked = false;
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
            ansval();
            int ilimit = jsonFile["NoQuestions"];
            if (i + 1 <= ilimit)
            {
                i++;
                Get_Question();
            }
            else
            {
                System.Windows.Forms.Application.Exit();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = jsonFile["Testname"];
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
            }
            else
            {
                MessageBox.Show("Wrong!", "Message", MessageBoxButtons.OK);
            }

        }
    }
}
