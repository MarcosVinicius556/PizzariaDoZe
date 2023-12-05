using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI;
using PizzariaDoZe.src.controllers;
using PizzariaDoZe.src.entities;
using PizzariaDoZe.src.entities.@interface;
using PizzariaDoZe.src.services.factory;
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
            FormFuncionario funcionario = new FormFuncionario(null);
            funcionario.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCliente Cadastro_Cliente = new FormCadastroCliente(null);
            Cadastro_Cliente.Show();
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngredientes Ingredientes = new FormIngredientes(null);
            Ingredientes.Show();
        }

        private void saboresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSabores Sabores = new FormSabores(null);
            Sabores.Show();
        }

        private void valoresPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormValores Valores = new FormValores(null);
            Valores.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProdutos Produtos = new FormProdutos(null);
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
                    FormEndereco formEnder = new FormEndereco(null);
                    formEnder.ShowDialog();
                    break;
                case FormSelected.FUNCIONARIO:
                    FormFuncionario formFunc = new FormFuncionario(null);
                    formFunc.ShowDialog();
                    break;
                case FormSelected.CLIENTE:
                    FormCadastroCliente formCliente = new FormCadastroCliente(null);
                    formCliente.ShowDialog();
                    break;
                case FormSelected.INGREDIENTE:
                    FormIngredientes formIngredientes = new FormIngredientes(null);
                    formIngredientes.ShowDialog();
                    break;
                case FormSelected.SABOR:
                    FormSabores formSabor = new FormSabores(null);
                    formSabor.ShowDialog();
                    break;
                case FormSelected.VALOR:
                    FormValores formValor = new FormValores(null);
                    formValor.ShowDialog();
                    break;
                case FormSelected.PRODUTO:
                    FormProdutos formProduto = new FormProdutos(null);
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
            int id = -1;
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Verifica se o DataGridView está vinculado a um DataTable
                // Não é a melhor alternativa, mas... está funcional
                if (selectedRow.DataBoundItem is System.Data.DataRowView rowView)
                {
                    switch (formSelected)
                    {
                        case FormSelected.ENDERECO:

                            id = Convert.ToInt32(rowView.Row["Id"]);
                            Endereco endereco = new Endereco { Id = id };

                            FormEndereco formEnder = new FormEndereco(endereco);
                            formEnder.ShowDialog();

                            /* Refresh */
                            dataGridView.DataSource = controller.BuscarEnderecos();
                            formSelected = FormSelected.ENDERECO;

                            break;
                        case FormSelected.FUNCIONARIO:
                            id = Convert.ToInt32(rowView.Row["Id"]);
                            Funcionario func = new Funcionario { IdFuncionario = id };

                            FormFuncionario formFunc = new FormFuncionario(func);
                            formFunc.ShowDialog();

                            /* Refresh */
                            dataGridView.DataSource = controller.BuscarFuncionarios();
                            formSelected = FormSelected.FUNCIONARIO;
                            break;
                        case FormSelected.CLIENTE:
                            id = Convert.ToInt32(rowView.Row["Id"]);
                            Cliente cli = new Cliente { IdCliente = id };

                            FormCadastroCliente formCliente = new FormCadastroCliente(cli);
                            formCliente.ShowDialog();

                            /* Refresh */
                            dataGridView.DataSource = controller.BuscarClientes();
                            formSelected = FormSelected.CLIENTE;
                            break;
                        case FormSelected.INGREDIENTE:
                            id = Convert.ToInt32(rowView.Row["Id"]);
                            Ingrediente ingrediente = new Ingrediente { Id = id };

                            FormIngredientes formIngredientes = new FormIngredientes(ingrediente);
                            formIngredientes.ShowDialog();

                            /* Refresh */
                            dataGridView.DataSource = controller.BuscarIngredientes();
                            formSelected = FormSelected.INGREDIENTE;
                            break;
                        case FormSelected.SABOR:
                            id = Convert.ToInt32(rowView.Row["Id"]);
                            Sabor sab = new Sabor { IdSabor = id };

                            FormSabores formSabor = new FormSabores(sab);
                            formSabor.ShowDialog();

                            /* Refresh */
                            dataGridView.DataSource = controller.BuscarSabores();
                            formSelected = FormSelected.SABOR;
                            break;
                        case FormSelected.VALOR:
                            id = Convert.ToInt32(rowView.Row["Id"]);
                            Valor val = new Valor { Id = id };

                            FormValores formValor = new FormValores(val);
                            formValor.ShowDialog();

                            /* Refresh */
                            dataGridView.DataSource = controller.BuscarValores();
                            formSelected = FormSelected.VALOR;
                            break;
                        case FormSelected.PRODUTO:
                            id = Convert.ToInt32(rowView.Row["Id"]);
                            Produto prod = new Produto { IdProduto = id };

                            FormProdutos formProduto = new FormProdutos(prod);
                            formProduto.ShowDialog();

                            /* Refresh */
                            dataGridView.DataSource = controller.BuscarProdutos();
                            formSelected = FormSelected.PRODUTO;
                            break;
                        case FormSelected.PEDIDO:
                            break;
                        default:
                            MessageBox.Show("Nenhum tipo de registro selecionado para criar!");
                            break;
                    }
                }
                else
                {
                    // Caso não haja linhas selecionadas, faça algo aqui, como exibir uma mensagem
                    Console.WriteLine("Nenhuma linha selecionada");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica se há alguma linha selecionada no DataGridView
            int id = -1;
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Verifica se o DataGridView está vinculado a um DataTable
                // Não é a melhor alternativa, mas... está funcional
                if (selectedRow.DataBoundItem is System.Data.DataRowView rowView)
                {
                    switch (formSelected)
                    {
                        case FormSelected.ENDERECO:

                            id = Convert.ToInt32(rowView.Row["Id"]);
                            Endereco endereco = new Endereco { Id = id };
                            ServiceFactory.createEnderecoService().DeleteById(endereco);

                            /* Refresh */
                            dataGridView.DataSource = controller.BuscarEnderecos();
                            formSelected = FormSelected.ENDERECO;
                            break;
                        case FormSelected.FUNCIONARIO:
                            id = Convert.ToInt32(rowView.Row["IdFuncionario"]);
                            Funcionario func = new Funcionario { IdFuncionario = id };
                            ServiceFactory.createFuncionarioService().DeleteById(func);

                            /* Refresh */
                            dataGridView.DataSource = controller.BuscarFuncionarios();
                            formSelected = FormSelected.FUNCIONARIO;
                            break;
                        case FormSelected.CLIENTE:
                            id = Convert.ToInt32(rowView.Row["IdCliente"]);
                            Cliente cli = new Cliente { IdCliente = id };
                            ServiceFactory.createClienteService().DeleteById(cli);

                            /* Refresh */
                            dataGridView.DataSource = controller.BuscarClientes();
                            formSelected = FormSelected.CLIENTE;
                            break;
                        case FormSelected.INGREDIENTE:
                            id = Convert.ToInt32(rowView.Row["Id"]);
                            Ingrediente ingrediente = new Ingrediente { Id = id };
                            ServiceFactory.createIngredienteService().DeleteById(ingrediente);

                            /* Refresh */
                            dataGridView.DataSource = controller.BuscarIngredientes();
                            formSelected = FormSelected.INGREDIENTE;
                            break;
                        case FormSelected.SABOR:
                            id = Convert.ToInt32(rowView.Row["IdSabor"]);
                            Sabor sabor = new Sabor { IdSabor = id };
                            ServiceFactory.createSaborService().DeleteById(sabor);

                            /* Refresh */
                            dataGridView.DataSource = controller.BuscarSabores();
                            formSelected = FormSelected.SABOR;
                            break;
                        case FormSelected.VALOR:
                            id = Convert.ToInt32(rowView.Row["Id"]);
                            Valor valor = new Valor { Id = id };
                            ServiceFactory.createValorService().DeleteById(valor);

                            /* Refresh */
                            dataGridView.DataSource = controller.BuscarValores();
                            formSelected = FormSelected.VALOR;
                            break;
                        case FormSelected.PRODUTO:
                            id = Convert.ToInt32(rowView.Row["IdProduto"]);
                            Produto prod = new Produto { IdProduto = id };
                            ServiceFactory.createProdutoService().DeleteById(prod);

                            /* Refresh */
                            dataGridView.DataSource = controller.BuscarProdutos();
                            formSelected = FormSelected.PRODUTO;
                            break;
                        case FormSelected.PEDIDO:
                            break;
                        default:
                            MessageBox.Show("Nenhum tipo de registro selecionado para criar!");
                            break;
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

}
