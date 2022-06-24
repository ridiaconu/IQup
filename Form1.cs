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
    public partial class Form1 : Form
    {
        public OpenFileDialog ofd;
        public string testname;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void begin_btn_Click(object sender, EventArgs e)
        {
            if(testname!=null)
            {
                this.Hide();
                Form2 f2 = new Form2(testname);
                f2.Show();
            }
            else
            {
                MessageBox.Show("Please select a test file first!", "Error");
            }

            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                testname= ofd.FileName;
            }
        }
    }
}
