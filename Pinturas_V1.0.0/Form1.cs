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
            Conexion nueva = new Conexion();
            nueva.crear_conexion();   
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
