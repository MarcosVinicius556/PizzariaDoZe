﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.views
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            FormConfiguracoes config = new FormConfiguracoes()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            _ = config.ShowDialog();

            Controls.Clear();
            InitializeComponent();

        }

        private void contextMenuStripPrincipal_Opening(object sender, CancelEventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionario funcionario = new FormFuncionario();
            funcionario.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCliente Cadastro_Cliente = new FormCadastroCliente();
            Cadastro_Cliente.Show();
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngredientes Ingredientes = new FormIngredientes();
            Ingredientes.Show();
        }

        private void saboresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSabores Sabores = new FormSabores();
            Sabores.Show();
        }

        private void valoresPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormValores Valores = new FormValores();
            Valores.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProdutos Produtos = new FormProdutos();
            Produtos.Show();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfiguracoes form = new FormConfiguracoes();
            form.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin form = new FormLogin();
            form.ShowDialog();
        }
    }

}
