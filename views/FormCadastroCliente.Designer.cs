namespace PizzariaDoZe.views
{
    partial class FormCadastroCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalvar = new Button();
            lblId = new Label();
            txtId = new TextBox();
            lblCpf = new Label();
            lblMatricula = new Label();
            lblNome = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblCnh = new Label();
            lblValidade = new Label();
            lblSenha = new Label();
            panelClientes = new Panel();
            lblTitulo = new Label();
            txtTelefone = new MaskedTextBox();
            txtCpf = new MaskedTextBox();
            txtSenha = new MaskedTextBox();
            lblObs = new Label();
            txtObs = new TextBox();
            calendarioCnh = new DateTimePicker();
            txtCnh = new TextBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtMatricula = new TextBox();
            btnExcluir = new Button();
            btnEditar = new Button();
            panelClientes.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.LimeGreen;
            btnSalvar.Location = new Point(83, 511);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 43);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = Properties.Resources.ResourceManager.GetString("Salvar");
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(24, 25);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 20);
            lblId.TabIndex = 1;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(24, 49);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(47, 27);
            txtId.TabIndex = 2;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(144, 25);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(36, 20);
            lblCpf.TabIndex = 3;
            lblCpf.Text = Properties.Resources.ResourceManager.GetString("CPF");
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(345, 25);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(91, 20);
            lblMatricula.TabIndex = 4;
            lblMatricula.Text = Properties.Resources.ResourceManager.GetString("Matricula");
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(24, 111);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(55, 20);
            lblNome.TabIndex = 5;
            lblNome.Text = Properties.Resources.ResourceManager.GetString("Nome");
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(24, 211);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(80, 20);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = Properties.Resources.ResourceManager.GetString("Telefone");
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(226, 211);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = Properties.Resources.ResourceManager.GetString("Email");
            // 
            // lblCnh
            // 
            lblCnh.AutoSize = true;
            lblCnh.Location = new Point(24, 284);
            lblCnh.Name = "lblCnh";
            lblCnh.Size = new Size(43, 20);
            lblCnh.TabIndex = 8;
            lblCnh.Text = Properties.Resources.ResourceManager.GetString("CNH");
            // 
            // lblValidade
            // 
            lblValidade.AutoSize = true;
            lblValidade.Location = new Point(213, 284);
            lblValidade.Name = "lblValidade";
            lblValidade.Size = new Size(81, 20);
            lblValidade.TabIndex = 9;
            lblValidade.Text = Properties.Resources.ResourceManager.GetString("Validade");
            lblValidade.Click += LabelValidade_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(357, 284);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(60, 20);
            lblSenha.TabIndex = 10;
            lblSenha.Text = Properties.Resources.ResourceManager.GetString("Senha");
            // 
            // panelClientes
            // 
            panelClientes.BackColor = SystemColors.ActiveBorder;
            panelClientes.Controls.Add(lblTitulo);
            panelClientes.Controls.Add(txtTelefone);
            panelClientes.Controls.Add(txtCpf);
            panelClientes.Controls.Add(txtSenha);
            panelClientes.Controls.Add(lblObs);
            panelClientes.Controls.Add(txtObs);
            panelClientes.Controls.Add(calendarioCnh);
            panelClientes.Controls.Add(txtCnh);
            panelClientes.Controls.Add(txtEmail);
            panelClientes.Controls.Add(txtNome);
            panelClientes.Controls.Add(txtMatricula);
            panelClientes.Controls.Add(lblSenha);
            panelClientes.Controls.Add(lblTelefone);
            panelClientes.Controls.Add(lblEmail);
            panelClientes.Controls.Add(lblCnh);
            panelClientes.Controls.Add(lblValidade);
            panelClientes.Controls.Add(lblNome);
            panelClientes.Controls.Add(lblId);
            panelClientes.Controls.Add(txtId);
            panelClientes.Controls.Add(lblCpf);
            panelClientes.Controls.Add(lblMatricula);
            panelClientes.Location = new Point(19, 28);
            panelClientes.Margin = new Padding(3, 4, 3, 4);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(622, 475);
            panelClientes.TabIndex = 11;
            panelClientes.Paint += panel1_Paint;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(17, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(152, 20);
            lblTitulo.TabIndex = 25;
            lblTitulo.Text = Properties.Resources.ResourceManager.GetString("Cadastro Cliente");
            lblTitulo.Click += label2_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(24, 235);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(191, 27);
            txtTelefone.TabIndex = 24;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(144, 49);
            txtCpf.Margin = new Padding(3, 4, 3, 4);
            txtCpf.Mask = "00000-000";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(167, 27);
            txtCpf.TabIndex = 15;
            txtCpf.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(357, 312);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(114, 27);
            txtSenha.TabIndex = 23;
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Location = new Point(17, 356);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(105, 20);
            lblObs.TabIndex = 22;
            lblObs.Text = Properties.Resources.ResourceManager.GetString("Observação");
            // 
            // txtObs
            // 
            txtObs.Location = new Point(17, 380);
            txtObs.Margin = new Padding(3, 4, 3, 4);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(526, 89);
            txtObs.TabIndex = 21;
            // 
            // calendarioCnh
            // 
            calendarioCnh.Format = DateTimePickerFormat.Short;
            calendarioCnh.Location = new Point(213, 308);
            calendarioCnh.Margin = new Padding(3, 4, 3, 4);
            calendarioCnh.Name = "calendarioCnh";
            calendarioCnh.Size = new Size(125, 27);
            calendarioCnh.TabIndex = 19;
            // 
            // txtCnh
            // 
            txtCnh.Location = new Point(24, 308);
            txtCnh.Margin = new Padding(3, 4, 3, 4);
            txtCnh.Name = "txtCnh";
            txtCnh.Size = new Size(171, 27);
            txtCnh.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(223, 235);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(321, 27);
            txtEmail.TabIndex = 17;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(24, 135);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(519, 27);
            txtNome.TabIndex = 15;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(345, 49);
            txtMatricula.Margin = new Padding(3, 4, 3, 4);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(198, 27);
            txtMatricula.TabIndex = 14;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.LightCoral;
            btnExcluir.Location = new Point(345, 511);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(86, 43);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = Properties.Resources.ResourceManager.GetString("Excluir");
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.CornflowerBlue;
            btnEditar.Location = new Point(216, 511);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 43);
            btnEditar.TabIndex = 14;
            btnEditar.Text = Properties.Resources.ResourceManager.GetString("Editar");
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // FormCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 559);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(panelClientes);
            Controls.Add(btnSalvar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCadastroCliente";
            Text = "FormCadastroClientes";
            Load += Form1_Load;
            panelClientes.ResumeLayout(false);
            panelClientes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalvar;
        private Label lblId;
        private TextBox txtId;
        private Label lblCpf;
        private Label lblMatricula;
        private Label lblNome;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblCnh;
        private Label lblValidade;
        private Label lblSenha;
        private Panel panelClientes;
        private Button btnExcluir;
        private Button btnEditar;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TextBox txtMatricula;
        private TextBox txtCnh;
        private Label lblObs;
        private TextBox txtObs;
        private DateTimePicker calendarioCnh;
        private MaskedTextBox txtSenha;
        private MaskedTextBox txtCpf;
        private MaskedTextBox txtTelefone;
        private Label lblTitulo;
    }
}