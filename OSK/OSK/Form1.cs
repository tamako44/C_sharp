﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeKeyboard();
            
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams p = base.CreateParams;
                p.ExStyle |= 0x8000000; // WS_EX_NOACTIVATE
                return p;
            }
        }



    }
}
