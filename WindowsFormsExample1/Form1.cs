using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show("hello!");
        }

        void MyButtonClick(object o, EventArgs a)
        {
            Button btn = o as Button;
            DialogResult res = MessageBox.Show(btn.Text,"Are you sure?",MessageBoxButtons.YesNoCancel);

            if(res == DialogResult.No)
            {
                Application.Exit();
            }
            else if(res == DialogResult.Yes)
            {
                MessageBox.Show("YES!");
            }else if (res == DialogResult.Cancel)
            {
                MessageBox.Show("Cancel!");

            }
        }

        private void dateTimeChangeButton_Click(object sender, EventArgs e)
        {
            dateTimeLabel.Text = DateTime.Now.ToString(@"yyyy/MM/dd HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimeLabel.Text = DateTime.Now.ToString(@"yyyy/MM/dd HH:mm:ss");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
