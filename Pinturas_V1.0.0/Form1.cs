﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinturas_V1._0._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private void formularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFormula nuevo = new CrearFormula();
            nuevo.Show();
        }
    }
}
