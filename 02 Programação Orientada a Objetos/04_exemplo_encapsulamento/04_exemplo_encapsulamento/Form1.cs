﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_exemplo_encapsulamento
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

        aluno z = new aluno();
        private void btn_armazenar_Click(object sender, EventArgs e)
        {
            z.setNome(txt_nome.Text);
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            lbl_nome.Text = z.getNome();
        }
    }
}
