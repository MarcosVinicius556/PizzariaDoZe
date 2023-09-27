namespace PizzariaDoZe.views
{
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
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

        private void txtCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Impede que o caractere "Enter" seja inserido no TextBox
                e.SuppressKeyPress = true;

                // Simula o pressionamento da tecla "Tab" para mover o foco para o próximo controle
                SendKeys.Send("{Tab}");
            }
        }

        private void txtMatricula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Impede que o caractere "Enter" seja inserido no TextBox
                e.SuppressKeyPress = true;

                // Simula o pressionamento da tecla "Tab" para mover o foco para o próximo controle
                SendKeys.Send("{Tab}");
            }
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Impede que o caractere "Enter" seja inserido no TextBox
                e.SuppressKeyPress = true;

                // Simula o pressionamento da tecla "Tab" para mover o foco para o próximo controle
                SendKeys.Send("{Tab}");
            }
        }

        private void txtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Impede que o caractere "Enter" seja inserido no TextBox
                e.SuppressKeyPress = true;

                // Simula o pressionamento da tecla "Tab" para mover o foco para o próximo controle
                SendKeys.Send("{Tab}");
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Impede que o caractere "Enter" seja inserido no TextBox
                e.SuppressKeyPress = true;

                // Simula o pressionamento da tecla "Tab" para mover o foco para o próximo controle
                SendKeys.Send("{Tab}");
            }
        }

        private void txtCnh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Impede que o caractere "Enter" seja inserido no TextBox
                e.SuppressKeyPress = true;

                // Simula o pressionamento da tecla "Tab" para mover o foco para o próximo controle
                SendKeys.Send("{Tab}");
            }
        }

        private void calendarioCnh_KeyDown(object sender, KeyEventArgs e)
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

        private void txtObs_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void FormCadastroCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Console.WriteLine("TESTE");
                this.Close();
            }
        }
    }
}