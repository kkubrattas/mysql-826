﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesli_tukenmekte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle ekle = new Ekle();
            ekle.Show();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele listele = new Listele();
            listele.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
