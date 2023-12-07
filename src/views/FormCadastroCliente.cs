using PizzariaDoZe.src.controllers;
using PizzariaDoZe.src.entities;
using System.Windows.Forms;

namespace PizzariaDoZe.views
{
    public partial class FormCadastroCliente : Form
    {
        private Boolean isNewRecord = true;
        Cliente clienteToUpdate = null;
        private FormClienteController controller = null;
        public FormCadastroCliente(Cliente cliente)
        {
            InitializeComponent();

            if(controller == null)
            {
                controller = new FormClienteController();
            }

            if (cliente != null)
            {
                isNewRecord = false;
                clienteToUpdate = controller.LoadById(cliente.IdCliente+"");
                Endereco enderTemp = controller.loadEnderecoById(cliente.Endereco.Id);
                clienteToUpdate.Endereco = enderTemp;

                displayValues();
            }
        }

        private void displayValues()
        {
            txtId.Text = clienteToUpdate.IdCliente + "";
            txtCep.Text = clienteToUpdate.Endereco.Cep;
            txtBairro.Text = clienteToUpdate.Endereco.Bairro;
            txtLogradouro.Text = clienteToUpdate.Endereco.Logradouro;
            txtObs.Text = "Sem obs";
            txtSenha.Text = ""; //TODO
            txtCnh.Text = ""; //TODO
            txtEmail.Text = clienteToUpdate.Email;
            txtTelefone.Text = clienteToUpdate.Telefone;
            txtNome.Text = clienteToUpdate.NomeCliente;
            txtCpf.Text = clienteToUpdate.Cpf;
            txtMatricula.Text = ""; //TODO

            /* TODO FIXME verificar como popula estes carinhas....... */
            //dropBoxUf = new ComboBox();
            //dropBoxCidade = new ComboBox();
            //dropBoxPais = new ComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelValidade_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroupBoxFuncao_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
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
            Cliente cliente = assignData();
            if (txtId.Text.Trim().Equals(""))
            {
                txtId.Focus();
                return;
            }

            if (isNewRecord)
            {
                controller.Save(cliente);
            }
            else
            {
                cliente.IdCliente = clienteToUpdate.IdCliente;
                controller.Update(cliente);

            }
        }

        private Cliente assignData()
        {
            Cliente cliente = new Cliente
            {
                Email = txtEmail.Text ,
                Telefone = txtTelefone.Text,
                NomeCliente = txtNome.Text,
                Cpf = txtCpf.Text 
        };

            return cliente;
        }
    }
}