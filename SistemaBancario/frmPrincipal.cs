﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancario
{
    public partial class frmPrincipal : Form
    {
        private string _usuarioLogado;

        public frmPrincipal(string pUsuarioLogado)
        {
            InitializeComponent();
            _usuarioLogado = pUsuarioLogado;
            lblUsuarioLogado.Text = _usuarioLogado;
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }
    }
}