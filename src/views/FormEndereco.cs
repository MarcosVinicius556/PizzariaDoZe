using PizzariaDoZe.src.controllers;
using PizzariaDoZe.src.entities;
using System.Runtime.ConstrainedExecution;

namespace PizzariaDoZe.views;

public partial class FormEndereco : Form
{
    /**
     * Caso seja alteração, esta flag será marcada como true, e então o form irá executar um "update" ao invés de um "save"
     */
    private Boolean isNewRecord = true;
    private Endereco enderecoToUpdate = null;
    private FormEnderecoController controller = null;
    public FormEndereco(Endereco endereco)
    {
        InitializeComponent();
        if(controller == null)
        {
            controller = new FormEnderecoController();
        }
        if(endereco != null)
        {
            isNewRecord = false;
            enderecoToUpdate = controller.LoadById(endereco.Id+"");
            displayValues();
        }

    }

    private void displayValues()
    {
        txtId.Text = enderecoToUpdate.Id+"";
        txtCep.Text = enderecoToUpdate.Cep;
        txtBairro.Text = enderecoToUpdate.Bairro;
        txtLogradouro.Text = enderecoToUpdate.Logradouro;
        /* TODO FIXME verificar como popula estes carinhas....... */
        //dropBoxUf = new ComboBox();
        //dropBoxCidade = new ComboBox();
        //dropBoxPais = new ComboBox();
    }

    private void form_endereco_Load(object sender, EventArgs e)
    {

    }

    private void lbl_cep_Click(object sender, EventArgs e)
    {

    }

    private void btn_salvar_Click(object sender, EventArgs e)
    {
        errorProvider1.Clear();
        Endereco endereco = assignData();
        if (txtId.Text.Trim().Equals(""))
        {
            errorProvider1.SetError(txtId, "Digite um e-mail registrado");
            txtId.Focus();
            return;
        }

        if (isNewRecord)
        {
            controller.Save(endereco);
        } else
        {
            endereco.Id = enderecoToUpdate.Id;
            controller.Update(endereco);

        }
    }

    private Endereco assignData()
    {
        Endereco endereco = new Endereco 
        {
            Cep = txtCep.Text,
            Logradouro = txtLogradouro.Text,
            Bairro = txtBairro.Text
        };

        return endereco;
    }

    private void lista_paises_SelectedIndexChanged(object sender, EventArgs e)
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
}