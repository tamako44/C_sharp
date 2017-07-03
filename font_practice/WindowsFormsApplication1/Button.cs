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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //MSDN have .this at head
            btn_label.Text = "Fahne";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            btn_label.Font = new Font("Arial",40);
            btn_label.Text = "Fahne Inc";
            //btn_label.Font = new System.Drawing.Font(l.Font.FontFamily.Name, 12);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btn_label.Location = new Point(180, 50);
            btn_label.ForeColor = Color.Red;
        }
    }
}
