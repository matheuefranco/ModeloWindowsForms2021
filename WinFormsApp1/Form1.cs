﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntAcessar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "adm") { 
                MessageBox.Show("Olá, seja bem vindo " + txtNome.Text + "!");
                this.Hide();
                Sistema sis = new Sistema();
                sis.ShowDialog();
                

            }
            else
                MessageBox.Show("Acesso negado :(");
        }
    }
}