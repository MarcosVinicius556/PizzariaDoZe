using PizzariaDoZe.src.entities;

namespace PizzariaDoZe.views;

public partial class FormEndereco : Form
{
    /**
     * Caso seja alteração, esta flag será marcada como true, e então o form irá executar um "update" ao invés de um "save"
     */
    private Boolean isNewRecord = true;
    public FormEndereco(Endereco endereco)
    {
        InitializeComponent();
        if(endereco != null)
        {
            MessageBox.Show("MODO DE EDIÇÃO ATIVO!");
            isNewRecord = true;
        }
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