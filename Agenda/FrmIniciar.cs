﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class FrmIniciar : Form
    {
        public FrmIniciar()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu frm = new FrmMenu();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void FrmIniciar_Load(object sender, EventArgs e)
        {

        }
    }
}
