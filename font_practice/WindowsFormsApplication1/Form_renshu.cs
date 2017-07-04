using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_renshu : Form
    {

        
        public Form_renshu()
        {
            InitializeComponent();
        }

        //Button
        private void btn_1_Click(object sender, EventArgs e)
        {
            //MSDN have .this at head
            btn_label.Text = "Fahne";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            btn_label.Font = new Font("Arial", rnd_num());
            btn_label.Text = "Fahne Inc";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            btn_label.Location = new Point(rnd_num(), rnd_num());
            btn_label.ForeColor = Color.Red;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            btn_label.Text = String.Empty;
        }

        //Check Box
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                check_label.Text = "Fahne Inc";
            //else
                

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            check_label.Font = new Font("Arial", rnd_num());
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            check_label.ForeColor = Color.Yellow;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            check_label.Location = new Point(rnd_num(), rnd_num());
        }

    

        //Radio button
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                radio_label.Text = "Kanagawa ken";
            else if (radioButton2.Checked)
                radio_label.Font = new Font("Arial", rnd_num());
            else if (radioButton3.Checked)
                radio_label.ForeColor = Color.Blue;
            else
                radio_label.Location = new Point(rnd_num(), rnd_num());
        }

        
        private static int rnd_num()
        {
            Random rnd_size = new Random();
            int size = rnd_size.Next(10,400);
            return size;  
        }

        private void Form_renshu_Load(object sender, EventArgs e)
        {
            btn_label.Text = String.Empty;
            radio_label.Text = "Minatomirai";

        }
    }
}
