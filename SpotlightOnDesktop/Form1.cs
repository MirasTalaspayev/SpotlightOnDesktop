﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotlightOnDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void NextImage_Click(object sender, EventArgs e)
        {
            
            while (!SpotlightOnDesktop.ChangeDesktopImage())
            {
                SpotlightOnDesktop.NextImage();
            }
            btn_ImageSetter.Text = "Next Image";
            SpotlightOnDesktop.NextImage();
        }
    }
}
