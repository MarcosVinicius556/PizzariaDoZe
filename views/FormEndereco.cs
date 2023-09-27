namespace PizzariaDoZe.views;

public partial class FormEndereco : Form
{
    public FormEndereco()
    {
        InitializeComponent();
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
        if (txtId.Text.Trim().Equals(""))
        {
            errorProvider1.SetError(txtId, "Digite um e-mail registrado");
            txtId.Focus();
            return;
        }
    }

    private void lista_paises_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void txtId_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            // Impede que o caractere "Enter" seja inserido no TextBox
            e.SuppressKeyPress = true;

            // Simula o pressionamento da tecla "Tab" para mover o foco para o próximo controle
            SendKeys.Send("{Tab}");
        }
    }

    private void txtCep_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            // Impede que o caractere "Enter" seja inserido no TextBox
            e.SuppressKeyPress = true;

            // Simula o pressionamento da tecla "Tab" para mover o foco para o próximo controle
            SendKeys.Send("{Tab}");
        }
    }

    private void txtLogradouro_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            // Impede que o caractere "Enter" seja inserido no TextBox
            e.SuppressKeyPress = true;

            // Simula o pressionamento da tecla "Tab" para mover o foco para o próximo controle
            SendKeys.Send("{Tab}");
        }
    }

    private void dropBoxPais_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            // Impede que o caractere "Enter" seja inserido no TextBox
            e.SuppressKeyPress = true;

            // Simula o pressionamento da tecla "Tab" para mover o foco para o próximo controle
            SendKeys.Send("{Tab}");
        }
    }

    private void dropBoxUf_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            // Impede que o caractere "Enter" seja inserido no TextBox
            e.SuppressKeyPress = true;

            // Simula o pressionamento da tecla "Tab" para mover o foco para o próximo controle
            SendKeys.Send("{Tab}");
        }
    }

    private void dropBoxCidade_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            // Impede que o caractere "Enter" seja inserido no TextBox
            e.SuppressKeyPress = true;

            // Simula o pressionamento da tecla "Tab" para mover o foco para o próximo controle
            SendKeys.Send("{Tab}");
        }
    }

    private void txtBairro_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            // Impede que o caractere "Enter" seja inserido no TextBox
            e.SuppressKeyPress = true;

            // Simula o pressionamento da tecla "Tab" para mover o foco para o próximo controle
            SendKeys.Send("{Tab}");
        }
    }
}