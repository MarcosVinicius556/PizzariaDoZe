﻿using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI;
using PizzariaDoZe.src.controllers;
using PizzariaDoZe.src.entities;
using PizzariaDoZe.src.entities.@interface;
using PizzariaDoZe.src.views.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace PizzariaDoZe.views
{
    public partial class FormPrincipal : Form
    {

        private static FormSelected formSelected;

        public FormPrincipal()
        {
            if (controller == null)
                controller = new FormPrincipalController();
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

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Pizzaria do Zé";
            notifyIcon1.BalloonTipText = "Enviado para bandeja";
            notifyIcon1.Text = "Pizzaria do Zé";
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void FormPrincipal_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você tem um shape completamente aesthetic, por quê ainda come pizza?");
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void contextMenuStripPrincipal_Opening(object sender, CancelEventArgs e)
        {

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Deseja fechar o formulário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {

                e.Cancel = true;
            }
            else
            {

                e.Cancel = false;
            }

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

        private void buttonNovoRegistro_Click(object sender, EventArgs e)
        {
            switch (formSelected)
            {
                case FormSelected.ENDERECO:
                    FormEndereco formEnder = new FormEndereco();
                    formEnder.ShowDialog();
                    break;
                case FormSelected.FUNCIONARIO:
                    FormFuncionario formFunc = new FormFuncionario();
                    formFunc.ShowDialog();
                    break;
                case FormSelected.CLIENTE:
                    FormCadastroCliente formCliente = new FormCadastroCliente();
                    formCliente.ShowDialog();
                    break;
                case FormSelected.INGREDIENTE:
                    FormIngredientes formIngredientes = new FormIngredientes();
                    formIngredientes.ShowDialog();
                    break;
                case FormSelected.SABOR:
                    FormSabores formSabor = new FormSabores();
                    formSabor.ShowDialog();
                    break;
                case FormSelected.VALOR:
                    FormValores formValor = new FormValores();
                    formValor.ShowDialog();
                    break;
                case FormSelected.PRODUTO:
                    FormProdutos formProduto = new FormProdutos();
                    formProduto.ShowDialog();
                    break;
                case FormSelected.PEDIDO:
                    break;
                default:
                    MessageBox.Show("Nenhum tipo de registro selecionado para criar!");
                    break;
            }
        }

        /**
         * Centralizando as chamadas das telas de edições....
         */
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            // Verifica se há alguma linha selecionada no DataGridView
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Verifica se o DataGridView está vinculado a um DataTable
                if (selectedRow.DataBoundItem is System.Data.DataRowView rowView)
                {
                    // Acessa os valores das células para construir o objeto Endereco
                    int id = Convert.ToInt32(rowView.Row["Id"]);
                    string rua = rowView.Row["Cep"].ToString();
                    string cidade = rowView.Row["Logradouro"].ToString();
                    // ... outras propriedades

                    // Crie um objeto Endereco com os valores das células
                    //Endereco endereco = new Endereco
                    //{
                       // Id = id,
                       // Rua = rua,
                       // Cidade = cidade
                        // ... atribua outras propriedades conforme necessário
                    // };

                    // Faça o que precisar com o objeto endereco
                    //Console.WriteLine("Objeto Endereco criado com os valores das células: " + endereco);
                }
            }
            else
            {
                // Caso não haja linhas selecionadas, faça algo aqui, como exibir uma mensagem
                Console.WriteLine("Nenhuma linha selecionada");
            }
        }
    }

}
