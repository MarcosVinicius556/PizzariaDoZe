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
            btnVoltar = new Button();
            panelClienteEndereco = new Panel();
            DropBoxUf = new ComboBox();
            lblPais = new Label();
            lblUf = new Label();
            lblCidade = new Label();
            lblBairro = new Label();
            lblLogradouro = new Label();
            lblCep = new Label();
            lblIdEndereco = new Label();
            txtPais = new TextBox();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtLogradouro = new TextBox();
            txtCep = new TextBox();
            txtIdEndereco = new TextBox();
            txtNumero = new TextBox();
            txtComplemento = new TextBox();
            lblNumero = new Label();
            lblComplemento = new Label();
            panelClientes.SuspendLayout();
            panelClienteEndereco.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ControlDarkDark;
            btnSalvar.ForeColor = SystemColors.Control;
            btnSalvar.Location = new Point(457, 383);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 32);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(21, 10);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 1;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(21, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(42, 23);
            txtId.TabIndex = 2;
            txtId.KeyDown += TabEvent;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(126, 19);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(0, 15);
            lblCpf.TabIndex = 3;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(302, 19);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(0, 15);
            lblMatricula.TabIndex = 4;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(21, 83);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(0, 15);
            lblNome.TabIndex = 5;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(21, 158);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(0, 15);
            lblTelefone.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(198, 158);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(0, 15);
            lblEmail.TabIndex = 7;
            // 
            // lblCnh
            // 
            lblCnh.AutoSize = true;
            lblCnh.Location = new Point(21, 213);
            lblCnh.Name = "lblCnh";
            lblCnh.Size = new Size(0, 15);
            lblCnh.TabIndex = 8;
            // 
            // lblValidade
            // 
            lblValidade.AutoSize = true;
            lblValidade.Location = new Point(186, 213);
            lblValidade.Name = "lblValidade";
            lblValidade.Size = new Size(0, 15);
            lblValidade.TabIndex = 9;
            lblValidade.Click += LabelValidade_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(312, 213);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(0, 15);
            lblSenha.TabIndex = 10;
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
            panelClientes.Location = new Point(40, 21);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(492, 356);
            panelClientes.TabIndex = 11;
            panelClientes.Paint += panel1_Paint;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(15, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(0, 15);
            lblTitulo.TabIndex = 25;
            lblTitulo.Click += label2_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(21, 167);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(168, 23);
            txtTelefone.TabIndex = 24;
            txtTelefone.KeyDown += TabEvent;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(126, 28);
            txtCpf.Mask = "00000-000";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(147, 23);
            txtCpf.TabIndex = 15;
            txtCpf.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            txtCpf.KeyDown += TabEvent;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(312, 225);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 23;
            txtSenha.KeyDown += TabEvent;
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Location = new Point(15, 267);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(0, 15);
            lblObs.TabIndex = 22;
            // 
            // txtObs
            // 
            txtObs.Location = new Point(15, 276);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(461, 68);
            txtObs.TabIndex = 21;
            txtObs.KeyDown += TabEvent;
            // 
            // calendarioCnh
            // 
            calendarioCnh.Format = DateTimePickerFormat.Short;
            calendarioCnh.Location = new Point(186, 222);
            calendarioCnh.Name = "calendarioCnh";
            calendarioCnh.Size = new Size(110, 23);
            calendarioCnh.TabIndex = 19;
            calendarioCnh.KeyDown += TabEvent;
            // 
            // txtCnh
            // 
            txtCnh.Location = new Point(21, 222);
            txtCnh.Name = "txtCnh";
            txtCnh.Size = new Size(150, 23);
            txtCnh.TabIndex = 18;
            txtCnh.KeyDown += TabEvent;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(195, 167);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(281, 23);
            txtEmail.TabIndex = 17;
            txtEmail.KeyDown += TabEvent;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(21, 92);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(455, 23);
            txtNome.TabIndex = 15;
            txtNome.KeyDown += TabEvent;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(302, 28);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(174, 23);
            txtMatricula.TabIndex = 14;
            txtMatricula.KeyDown += TabEvent;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.ControlDarkDark;
            btnExcluir.ForeColor = SystemColors.Control;
            btnExcluir.Location = new Point(931, 383);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 32);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Deletar";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = SystemColors.ControlDarkDark;
            btnVoltar.ForeColor = SystemColors.Control;
            btnVoltar.Location = new Point(553, 383);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 32);
            btnVoltar.TabIndex = 14;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // panelClienteEndereco
            // 
            panelClienteEndereco.BackColor = SystemColors.ActiveBorder;
            panelClienteEndereco.Controls.Add(DropBoxUf);
            panelClienteEndereco.Controls.Add(lblPais);
            panelClienteEndereco.Controls.Add(lblUf);
            panelClienteEndereco.Controls.Add(lblCidade);
            panelClienteEndereco.Controls.Add(lblBairro);
            panelClienteEndereco.Controls.Add(lblLogradouro);
            panelClienteEndereco.Controls.Add(lblCep);
            panelClienteEndereco.Controls.Add(lblIdEndereco);
            panelClienteEndereco.Controls.Add(txtPais);
            panelClienteEndereco.Controls.Add(txtCidade);
            panelClienteEndereco.Controls.Add(txtBairro);
            panelClienteEndereco.Controls.Add(txtLogradouro);
            panelClienteEndereco.Controls.Add(txtCep);
            panelClienteEndereco.Controls.Add(txtIdEndereco);
            panelClienteEndereco.Location = new Point(553, 21);
            panelClienteEndereco.Name = "panelClienteEndereco";
            panelClienteEndereco.Size = new Size(453, 190);
            panelClienteEndereco.TabIndex = 15;
            // 
            // DropBoxUf
            // 
            DropBoxUf.FormattingEnabled = true;
            DropBoxUf.Location = new Point(20, 150);
            DropBoxUf.Name = "DropBoxUf";
            DropBoxUf.Size = new Size(73, 23);
            DropBoxUf.TabIndex = 14;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(96, 133);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(31, 15);
            lblPais.TabIndex = 13;
            lblPais.Text = "País:";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(18, 133);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(24, 15);
            lblUf.TabIndex = 12;
            lblUf.Text = "UF:";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(224, 75);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 11;
            lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(17, 75);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 10;
            lblBairro.Text = "Bairro:";
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(287, 11);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(72, 15);
            lblLogradouro.TabIndex = 9;
            lblLogradouro.Text = "Logradouro:";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(130, 11);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(31, 15);
            lblCep.TabIndex = 8;
            lblCep.Text = "CEP:";
            // 
            // lblIdEndereco
            // 
            lblIdEndereco.AutoSize = true;
            lblIdEndereco.Location = new Point(19, 13);
            lblIdEndereco.Name = "lblIdEndereco";
            lblIdEndereco.Size = new Size(21, 15);
            lblIdEndereco.TabIndex = 7;
            lblIdEndereco.Text = "ID:";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(99, 150);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(328, 23);
            txtPais.TabIndex = 6;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(226, 92);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(201, 23);
            txtCidade.TabIndex = 4;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(20, 92);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(200, 23);
            txtBairro.TabIndex = 3;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(290, 28);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(137, 23);
            txtLogradouro.TabIndex = 2;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(131, 28);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(153, 23);
            txtCep.TabIndex = 1;
            // 
            // txtIdEndereco
            // 
            txtIdEndereco.Location = new Point(20, 28);
            txtIdEndereco.Name = "txtIdEndereco";
            txtIdEndereco.Size = new Size(73, 23);
            txtIdEndereco.TabIndex = 0;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(553, 243);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(73, 23);
            txtNumero.TabIndex = 16;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(632, 243);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(328, 23);
            txtComplemento.TabIndex = 17;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(551, 226);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 18;
            lblNumero.Text = "Número:";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(630, 226);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(87, 15);
            lblComplemento.TabIndex = 19;
            lblComplemento.Text = "Complemento:";
            // 
            // FormCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1037, 419);
            Controls.Add(lblComplemento);
            Controls.Add(lblNumero);
            Controls.Add(txtComplemento);
            Controls.Add(txtNumero);
            Controls.Add(panelClienteEndereco);
            Controls.Add(btnVoltar);
            Controls.Add(btnExcluir);
            Controls.Add(panelClientes);
            Controls.Add(btnSalvar);
            Name = "FormCadastroCliente";
            Text = "FormCadastroClientes";
            Load += Form1_Load;
            panelClientes.ResumeLayout(false);
            panelClientes.PerformLayout();
            panelClienteEndereco.ResumeLayout(false);
            panelClienteEndereco.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnVoltar;
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
        private Panel panelClienteEndereco;
        private TextBox txtPais;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtLogradouro;
        private TextBox txtCep;
        private TextBox txtIdEndereco;
        private TextBox txtNumero;
        private Label lblPais;
        private Label lblUf;
        private Label lblCidade;
        private Label lblBairro;
        private Label lblLogradouro;
        private Label lblCep;
        private Label lblIdEndereco;
        private TextBox txtComplemento;
        private Label lblNumero;
        private Label lblComplemento;
        private ComboBox DropBoxUf;
    }
}