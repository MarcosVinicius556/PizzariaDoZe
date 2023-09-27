namespace PizzariaDoZe.views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FormPrincipal form = new FormPrincipal();
            form.Show();
            this.Hide();
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Impede que o caractere "Enter" seja inserido no TextBox
                e.SuppressKeyPress = true;

                // Simula o pressionamento da tecla "Tab" para mover o foco para o próximo controle
                SendKeys.Send("{Tab}");
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
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
}