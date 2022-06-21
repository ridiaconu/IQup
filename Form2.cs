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
            ans2.Text = jsonFile[Question_num]["A2"];
            ans3.Text = jsonFile[Question_num]["A3"];
            ans4.Text = jsonFile[Question_num]["A4"];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
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
    }
}
