﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreTesting
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            CommonControl1 commontrol1 = new CommonControl1();
            commontrol1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CommonControl2 commonControl2 = new CommonControl2();
            commonControl2.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DataControls dataControls = new DataControls();
            dataControls.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DialogControls dialogsTesting = new DialogControls();
            dialogsTesting.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            PrintingControls printingTesting = new PrintingControls();
            printingTesting.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            RemainingControls remainingControls = new RemainingControls();
            remainingControls.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ContainerControls containerControl = new ContainerControls();
            containerControl.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Binding_Data binding_Data = new Binding_Data();
            binding_Data.Show();
        }
    }
}
