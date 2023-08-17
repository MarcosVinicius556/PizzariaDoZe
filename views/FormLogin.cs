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
            form.ShowDialog();
            this.Dispose();
            this.Close();
        }
    }
}