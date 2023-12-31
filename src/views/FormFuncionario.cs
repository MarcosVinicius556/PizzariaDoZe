﻿using MySqlX.XDevAPI;
using PizzariaDoZe.src.controllers;
using PizzariaDoZe.src.entities;

namespace PizzariaDoZe.views;

public partial class FormFuncionario : Form
{

    private Boolean isNewRecord = true;
    private Funcionario funcToUpdate = null;
    private FormFuncionariosController controller;
    public FormFuncionario(Funcionario funcionario)
    {
        InitializeComponent();
        if (controller == null)
            controller = new FormFuncionariosController();

        if(funcionario != null)
        {
            isNewRecord = false;
            clienteToUpdate = controller.LoadById(cliente.IdCliente + "");
            Endereco enderTemp = controller.loadEnderecoById(cliente.Endereco.Id);
            clienteToUpdate.Endereco = enderTemp;

            displayValues();
        }

    }


    private void displayValues()
    {
        Funcionario funcionario = new Funcionario();
        txtId.Text = funcionario.IdFuncionario+"";
        TextBoxNome.Text = funcionario.NomeFuncionario;
        txtCpf.Text = funcionario.Cpf;
        txtMatricula.Text = funcionario.Matricula;
        txtSenha.Text = funcionario.Senha;
        textBoxCnh.Text = funcionario.Motorista;
        txtObs.Text = funcionario.Observacao;
        txtTelefone.Text = funcionario.Telefone;
        funcionario.Email = textBoxEmail.Text;

        Endereco endereco = new Endereco();
        if (textBoxEnderecoId.Text != "")
            endereco.Id = int.Parse(textBoxEnderecoId.Text);
        endereco.Logradouro = txtLogradouro.Text;
        endereco.Bairro = txtBairro.Text;
        endereco.Cep = maskedTextBoxCep.Text.Replace("-", "");
        funcionario.Endereco = endereco;

        if (textBoxNumero.Text != "")
            funcionario.Numero = int.Parse(textBoxNumero.Text, 0);
        funcionario.Complemento = textBoxComplemento.Text;

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

    private void labelBairro_Click(object sender, EventArgs e)
    {

    }

    private void txtBairro_TextChanged(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void labelComplemento_Click(object sender, EventArgs e)
    {

    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            Funcionario func = assignData();
            if (isNewRecord)
            {
                controller.Save(func);
            }
            else
            {
                func.IdFuncionario = funcToUpdate.IdFuncionario;
                controller.Update(func);

            }
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro ao processar os dados do funcionário. Erro: {ex.Message}");
        }
    }

    private Funcionario assignData()
    {
        Funcionario funcionario = new Funcionario();
        //funcionario.IdFuncionario = int.Parse(txtId.Text);
        funcionario.NomeFuncionario = TextBoxNome.Text;
        funcionario.Cpf = txtCpf.Text.Replace(",", "").Replace("-", "").Replace(".", "");
        funcionario.Matricula = txtMatricula.Text;
        funcionario.Senha = txtSenha.Text;
        funcionario.Grupo = 'N';
        funcionario.Motorista = textBoxCnh.Text;
        funcionario.ValidadeMotorista = calendarioCnh.Value.Date;
        funcionario.Observacao = txtObs.Text;
        //funcionario.Telefone = txtTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim(); //TODO
        funcionario.Email = textBoxEmail.Text;

        Endereco endereco = new Endereco();
        if (textBoxEnderecoId.Text != "")
            endereco.Id = int.Parse(textBoxEnderecoId.Text);
        endereco.Logradouro = txtLogradouro.Text;
        endereco.Bairro = txtBairro.Text;
        endereco.Cep = maskedTextBoxCep.Text.Replace("-", "");
        funcionario.Endereco = endereco;

        if (textBoxNumero.Text != "")
            funcionario.Numero = int.Parse(textBoxNumero.Text, 0);
        funcionario.Complemento = textBoxComplemento.Text;

        return funcionario;
    }

    private void btnVoltar_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }

    private void txtCep_Leave(object sender, EventArgs e)
    {
        string cep = maskedTextBoxCep.Text.Replace("-", "");
        Endereco endereco = controller.findEnderecoByCep(cep);
        if (endereco != null)
        {
            textBoxEnderecoId.Text = endereco.Id != 0 ? endereco.Id + "" : "";
            txtLogradouro.Text = endereco.Logradouro != null ? endereco.Logradouro : ""; ;
            txtBairro.Text = endereco.Bairro != null ? endereco.Bairro : ""; ;
            dropBoxUf.Select(); //TODO
                                //            textBoxPais.Text = endereco.Cidade.Uf.Pais.NomePais != null ? endereco.Cidade.Uf.Pais.NomePais : ""; ;
        }
        else
        {
            MessageBox.Show("Nenhum endereço encontrado com este CEP");
        }
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
        if(txtId.Text != "")
        {
            controller.remove(txtId.Text);
        }
    }
}