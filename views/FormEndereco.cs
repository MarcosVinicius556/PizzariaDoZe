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
}