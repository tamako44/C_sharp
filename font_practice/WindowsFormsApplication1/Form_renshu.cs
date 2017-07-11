using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathCalculate;


namespace WindowsFormsApplication1
{
    public partial class Form_renshu : Form
    {
       
        public Form_renshu()
        {
            InitializeComponent();
            //call my method  
        }

        //Button
        private void btn_1_Click(object sender, EventArgs e)
        {
            //MSDN have .this at head
            btn_label.Text = "Fahne";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            btn_label.Font = new Font("Arial", RondomNum.get_rnd_size());
            btn_label.Text = "Fahne Inc";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            btn_label.Location = new Point(RondomNum.get_rnd_location(), RondomNum.get_rnd_location());
            btn_label.ForeColor = Color.Red;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            btn_label.ResetAll();
        }

        //Check Box
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                check_label.Text = "Fahne Inc";
            else
            {
                check_label.ResetAll();
            }

        }

        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked)
                check_label.Font = new Font("Arial", RondomNum.get_rnd_size());
            else
            {
                check_label.ResetAll();
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                check_label.ForeColor = Color.Yellow;
            else
            {
                check_label.ResetAll();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox4.Checked)
                check_label.Location = new Point(RondomNum.get_rnd_location(), RondomNum.get_rnd_location());
            else
            {
                check_label.ResetAll();
            }
        }
        
    

        //Radio button
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                radio_label.Text = "Kanagawa ken";
            else if (radioButton2.Checked)
                radio_label.Font = new Font("Arial", RondomNum.get_rnd_size());
            else if (radioButton3.Checked)
                radio_label.ForeColor = Color.Blue;
            else
                radio_label.Location = new Point(RondomNum.get_rnd_location(), RondomNum.get_rnd_location());
            //else
            //    radio_label.ResetAll();
        }
    }
}
