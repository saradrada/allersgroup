﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace AllersGroup
{
    public partial class Form1 : Form
    {
        public Consult model;
        public Form1()
        {
            InitializeComponent();
            model = new Consult();

            uC_G41.LoadModel(model);
        }

    }
}
