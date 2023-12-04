using PizzariaDoZe.src.controllers;
using PizzariaDoZe.src.entities;
using System;
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
    public partial class FormProdutos : Form
    {
        private Boolean isNewRecord = true;

        private FormProdutosController controller = new FormProdutosController();
        public FormProdutos(Produto produto)
        {
            InitializeComponent();

            if(produto != null)
            {
                isNewRecord = false;
            }
        }
        private void TabEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Impede que o caractere "Enter" seja inserido no TextBox
                e.SuppressKeyPress = true;

                // Simula o pressionamento da tecla "Tab" para mover o foco para o pr�ximo controle
                SendKeys.Send("{Tab}");
            }
        }

        /* Outros métodos */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.DescricaoProduto = txtNome.Text.Substring(0, 1);
            produto.Valor = decimal.Parse(txtValor.Text);
            produto.MedidaUnitaria = "UN";
            produto.Tipo = 'C';

            controller.Save(produto);
        }
    }

}
