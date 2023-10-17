namespace PizzariaDoZe.views
{
    partial class FormFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionario));
            btnSalvar = new Button();
            lblId = new Label();
            txtId = new TextBox();
            lblCpf = new Label();
            lblMatricula = new Label();
            labelNomeFuncionario = new Label();
            lblTelefone = new Label();
            labelEmail = new Label();
            labelCnh = new Label();
            lblValidade = new Label();
            lblSenha = new Label();
            panelFuncionarios = new Panel();
            panelEndereco = new Panel();
            maskedTextBoxCep = new MaskedTextBox();
            labelNumero = new Label();
            labelComplemento = new Label();
            textBoxComplemento = new TextBox();
            textBoxNumero = new TextBox();
            labelPais = new Label();
            textBoxPais = new TextBox();
            labelUf = new Label();
            labelLogradouro = new Label();
            labelCep = new Label();
            labelBairro = new Label();
            lblBairro = new Label();
            txtBairro = new TextBox();
            dropBoxUf = new ComboBox();
            lblUf = new Label();
            lblCidade = new Label();
            lblPais = new Label();
            lblLogradouro = new Label();
            txtLogradouro = new TextBox();
            textBoxEnderecoId = new TextBox();
            lblCep = new Label();
            labelId = new Label();
            labelObs = new Label();
            labelSenha = new Label();
            labelValidadeCNH = new Label();
            labelHabilitacao = new Label();
            labelMail = new Label();
            labelTelefone = new Label();
            labelMatricula = new Label();
            label1 = new Label();
            labelNome = new Label();
            btnExcluir = new Button();
            btnVoltar = new Button();
            lblFuncionarios = new Label();
            txtTelefone = new MaskedTextBox();
            txtCpf = new MaskedTextBox();
            txtSenha = new MaskedTextBox();
            lblObs = new Label();
            txtObs = new TextBox();
            calendarioCnh = new DateTimePicker();
            textBoxCnh = new TextBox();
            textBoxEmail = new TextBox();
            TextBoxNome = new TextBox();
            txtMatricula = new TextBox();
            groupBoxFuncao = new GroupBox();
            radioEntregador = new RadioButton();
            radioAtendente = new RadioButton();
            radioAdministrador = new RadioButton();
            panelFuncionarios.SuspendLayout();
            panelEndereco.SuspendLayout();
            groupBoxFuncao.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ControlDarkDark;
            btnSalvar.FlatAppearance.BorderColor = Color.Black;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(346, 469);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(118, 52);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(67, 24);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 1;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(94, 21);
            txtId.Name = "txtId";
            txtId.Size = new Size(42, 23);
            txtId.TabIndex = 2;
            txtId.KeyDown += TabEvent;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(126, 3);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(0, 15);
            lblCpf.TabIndex = 3;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(302, 3);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(0, 15);
            lblMatricula.TabIndex = 4;
            // 
            // labelNomeFuncionario
            // 
            labelNomeFuncionario.AutoSize = true;
            labelNomeFuncionario.Location = new Point(21, 83);
            labelNomeFuncionario.Name = "labelNomeFuncionario";
            labelNomeFuncionario.Size = new Size(0, 15);
            labelNomeFuncionario.TabIndex = 5;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(21, 158);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(0, 15);
            lblTelefone.TabIndex = 6;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(198, 142);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(0, 15);
            labelEmail.TabIndex = 7;
            // 
            // labelCnh
            // 
            labelCnh.AutoSize = true;
            labelCnh.Location = new Point(21, 213);
            labelCnh.Name = "labelCnh";
            labelCnh.Size = new Size(0, 15);
            labelCnh.TabIndex = 8;
            // 
            // lblValidade
            // 
            lblValidade.AutoSize = true;
            lblValidade.Location = new Point(186, 197);
            lblValidade.Name = "lblValidade";
            lblValidade.Size = new Size(0, 15);
            lblValidade.TabIndex = 9;
            lblValidade.Click += LabelValidade_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(312, 197);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(0, 15);
            lblSenha.TabIndex = 10;
            // 
            // panelFuncionarios
            // 
            panelFuncionarios.BackColor = SystemColors.ActiveBorder;
            panelFuncionarios.Controls.Add(panelEndereco);
            panelFuncionarios.Controls.Add(labelObs);
            panelFuncionarios.Controls.Add(labelSenha);
            panelFuncionarios.Controls.Add(labelValidadeCNH);
            panelFuncionarios.Controls.Add(labelHabilitacao);
            panelFuncionarios.Controls.Add(labelMail);
            panelFuncionarios.Controls.Add(labelTelefone);
            panelFuncionarios.Controls.Add(labelMatricula);
            panelFuncionarios.Controls.Add(label1);
            panelFuncionarios.Controls.Add(labelNome);
            panelFuncionarios.Controls.Add(btnExcluir);
            panelFuncionarios.Controls.Add(btnVoltar);
            panelFuncionarios.Controls.Add(lblFuncionarios);
            panelFuncionarios.Controls.Add(txtTelefone);
            panelFuncionarios.Controls.Add(btnSalvar);
            panelFuncionarios.Controls.Add(txtCpf);
            panelFuncionarios.Controls.Add(txtSenha);
            panelFuncionarios.Controls.Add(lblObs);
            panelFuncionarios.Controls.Add(txtObs);
            panelFuncionarios.Controls.Add(calendarioCnh);
            panelFuncionarios.Controls.Add(textBoxCnh);
            panelFuncionarios.Controls.Add(textBoxEmail);
            panelFuncionarios.Controls.Add(TextBoxNome);
            panelFuncionarios.Controls.Add(txtMatricula);
            panelFuncionarios.Controls.Add(groupBoxFuncao);
            panelFuncionarios.Controls.Add(lblSenha);
            panelFuncionarios.Controls.Add(lblTelefone);
            panelFuncionarios.Controls.Add(labelEmail);
            panelFuncionarios.Controls.Add(labelCnh);
            panelFuncionarios.Controls.Add(lblValidade);
            panelFuncionarios.Controls.Add(labelNomeFuncionario);
            panelFuncionarios.Controls.Add(lblId);
            panelFuncionarios.Controls.Add(txtId);
            panelFuncionarios.Controls.Add(lblCpf);
            panelFuncionarios.Controls.Add(lblMatricula);
            panelFuncionarios.Location = new Point(12, 12);
            panelFuncionarios.Name = "panelFuncionarios";
            panelFuncionarios.Size = new Size(943, 535);
            panelFuncionarios.TabIndex = 11;
            panelFuncionarios.Paint += panel1_Paint;
            // 
            // panelEndereco
            // 
            panelEndereco.BackColor = SystemColors.AppWorkspace;
            panelEndereco.BorderStyle = BorderStyle.FixedSingle;
            panelEndereco.Controls.Add(maskedTextBoxCep);
            panelEndereco.Controls.Add(labelNumero);
            panelEndereco.Controls.Add(labelComplemento);
            panelEndereco.Controls.Add(textBoxComplemento);
            panelEndereco.Controls.Add(textBoxNumero);
            panelEndereco.Controls.Add(labelPais);
            panelEndereco.Controls.Add(textBoxPais);
            panelEndereco.Controls.Add(labelUf);
            panelEndereco.Controls.Add(labelLogradouro);
            panelEndereco.Controls.Add(labelCep);
            panelEndereco.Controls.Add(labelBairro);
            panelEndereco.Controls.Add(lblBairro);
            panelEndereco.Controls.Add(txtBairro);
            panelEndereco.Controls.Add(dropBoxUf);
            panelEndereco.Controls.Add(lblUf);
            panelEndereco.Controls.Add(lblCidade);
            panelEndereco.Controls.Add(lblPais);
            panelEndereco.Controls.Add(lblLogradouro);
            panelEndereco.Controls.Add(txtLogradouro);
            panelEndereco.Controls.Add(textBoxEnderecoId);
            panelEndereco.Controls.Add(lblCep);
            panelEndereco.Controls.Add(labelId);
            panelEndereco.Location = new Point(565, 21);
            panelEndereco.Name = "panelEndereco";
            panelEndereco.Size = new Size(370, 207);
            panelEndereco.TabIndex = 35;
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(99, 90);
            maskedTextBoxCep.Mask = "00000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(147, 23);
            maskedTextBoxCep.TabIndex = 36;
            maskedTextBoxCep.Leave += txtCep_Leave;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(40, 143);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(54, 15);
            labelNumero.TabIndex = 26;
            labelNumero.Text = "Número:";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(9, 168);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(87, 15);
            labelComplemento.TabIndex = 25;
            labelComplemento.Text = "Complemento:";
            labelComplemento.Click += labelComplemento_Click;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(99, 164);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(244, 23);
            textBoxComplemento.TabIndex = 24;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(99, 139);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(58, 23);
            textBoxNumero.TabIndex = 23;
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Location = new Point(161, 118);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(31, 15);
            labelPais.TabIndex = 22;
            labelPais.Text = "Pais:";
            // 
            // textBoxPais
            // 
            textBoxPais.Location = new Point(196, 115);
            textBoxPais.Name = "textBoxPais";
            textBoxPais.Size = new Size(160, 23);
            textBoxPais.TabIndex = 21;
            // 
            // labelUf
            // 
            labelUf.AutoSize = true;
            labelUf.Location = new Point(69, 118);
            labelUf.Name = "labelUf";
            labelUf.Size = new Size(24, 15);
            labelUf.TabIndex = 20;
            labelUf.Text = "UF:";
            labelUf.Click += label3_Click;
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(21, 44);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(72, 15);
            labelLogradouro.TabIndex = 19;
            labelLogradouro.Text = "Logradouro:";
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Location = new Point(62, 93);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(31, 15);
            labelCep.TabIndex = 18;
            labelCep.Text = "CEP:";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(52, 68);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(41, 15);
            labelBairro.TabIndex = 17;
            labelBairro.Text = "Bairro:";
            labelBairro.Click += labelBairro_Click;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(466, 180);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(0, 15);
            lblBairro.TabIndex = 16;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(99, 65);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(257, 23);
            txtBairro.TabIndex = 15;
            txtBairro.TextChanged += txtBairro_TextChanged;
            // 
            // dropBoxUf
            // 
            dropBoxUf.FormattingEnabled = true;
            dropBoxUf.Location = new Point(99, 114);
            dropBoxUf.Name = "dropBoxUf";
            dropBoxUf.Size = new Size(58, 23);
            dropBoxUf.TabIndex = 14;
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(466, 103);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(0, 15);
            lblUf.TabIndex = 13;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(31, 189);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(0, 15);
            lblCidade.TabIndex = 12;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(31, 103);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(0, 15);
            lblPais.TabIndex = 9;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(466, 44);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(0, 15);
            lblLogradouro.TabIndex = 8;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(99, 40);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(257, 23);
            txtLogradouro.TabIndex = 6;
            // 
            // textBoxEnderecoId
            // 
            textBoxEnderecoId.Enabled = false;
            textBoxEnderecoId.Location = new Point(99, 15);
            textBoxEnderecoId.Name = "textBoxEnderecoId";
            textBoxEnderecoId.Size = new Size(33, 23);
            textBoxEnderecoId.TabIndex = 1;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(230, 43);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(0, 15);
            lblCep.TabIndex = 5;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(70, 23);
            labelId.Name = "labelId";
            labelId.Size = new Size(21, 15);
            labelId.TabIndex = 3;
            labelId.Text = "ID:";
            // 
            // labelObs
            // 
            labelObs.AutoSize = true;
            labelObs.Location = new Point(15, 165);
            labelObs.Name = "labelObs";
            labelObs.Size = new Size(77, 15);
            labelObs.TabIndex = 34;
            labelObs.Text = "Observações:";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(50, 138);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(42, 15);
            labelSenha.TabIndex = 33;
            labelSenha.Text = "Senha:";
            // 
            // labelValidadeCNH
            // 
            labelValidadeCNH.AutoSize = true;
            labelValidadeCNH.Location = new Point(276, 110);
            labelValidadeCNH.Name = "labelValidadeCNH";
            labelValidadeCNH.Size = new Size(83, 15);
            labelValidadeCNH.TabIndex = 32;
            labelValidadeCNH.Text = "Validade CNH:";
            // 
            // labelHabilitacao
            // 
            labelHabilitacao.AutoSize = true;
            labelHabilitacao.Location = new Point(55, 110);
            labelHabilitacao.Name = "labelHabilitacao";
            labelHabilitacao.Size = new Size(36, 15);
            labelHabilitacao.TabIndex = 31;
            labelHabilitacao.Text = "CNH:";
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Location = new Point(260, 83);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(39, 15);
            labelMail.TabIndex = 30;
            labelMail.Text = "Email:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(36, 83);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(54, 15);
            labelTelefone.TabIndex = 29;
            labelTelefone.Text = "Telefone:";
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Location = new Point(369, 25);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(60, 15);
            labelMatricula.TabIndex = 28;
            labelMatricula.Text = "Matricula:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 25);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 27;
            label1.Text = "CPF:";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(46, 53);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(43, 15);
            labelNome.TabIndex = 26;
            labelNome.Text = "Nome:";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.ControlDarkDark;
            btnExcluir.FlatAppearance.BorderColor = Color.Black;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ForeColor = SystemColors.ButtonHighlight;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(809, 469);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(118, 52);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Deletar";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = SystemColors.ControlDarkDark;
            btnVoltar.FlatAppearance.BorderColor = Color.Black;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = SystemColors.ButtonHighlight;
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(482, 469);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(111, 52);
            btnVoltar.TabIndex = 14;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextAlign = ContentAlignment.MiddleRight;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblFuncionarios
            // 
            lblFuncionarios.AutoSize = true;
            lblFuncionarios.Location = new Point(15, 0);
            lblFuncionarios.Name = "lblFuncionarios";
            lblFuncionarios.Size = new Size(0, 15);
            lblFuncionarios.TabIndex = 25;
            lblFuncionarios.Click += label2_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(95, 79);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(128, 23);
            txtTelefone.TabIndex = 24;
            txtTelefone.KeyDown += TabEvent;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(214, 21);
            txtCpf.Mask = "000.000.000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(147, 23);
            txtCpf.TabIndex = 15;
            txtCpf.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            txtCpf.KeyDown += TabEvent;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(95, 134);
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
            txtObs.Location = new Point(95, 162);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(464, 134);
            txtObs.TabIndex = 21;
            txtObs.KeyDown += TabEvent;
            // 
            // calendarioCnh
            // 
            calendarioCnh.Format = DateTimePickerFormat.Short;
            calendarioCnh.Location = new Point(363, 106);
            calendarioCnh.Name = "calendarioCnh";
            calendarioCnh.Size = new Size(110, 23);
            calendarioCnh.TabIndex = 19;
            calendarioCnh.KeyDown += TabEvent;
            // 
            // textBoxCnh
            // 
            textBoxCnh.Location = new Point(95, 106);
            textBoxCnh.Name = "textBoxCnh";
            textBoxCnh.Size = new Size(168, 23);
            textBoxCnh.TabIndex = 18;
            textBoxCnh.KeyDown += TabEvent;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(302, 79);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(257, 23);
            textBoxEmail.TabIndex = 17;
            textBoxEmail.KeyDown += TabEvent;
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(94, 50);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(465, 23);
            TextBoxNome.TabIndex = 15;
            TextBoxNome.KeyDown += TabEvent;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(432, 21);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(127, 23);
            txtMatricula.TabIndex = 14;
            txtMatricula.KeyDown += TabEvent;
            // 
            // groupBoxFuncao
            // 
            groupBoxFuncao.Controls.Add(radioEntregador);
            groupBoxFuncao.Controls.Add(radioAtendente);
            groupBoxFuncao.Controls.Add(radioAdministrador);
            groupBoxFuncao.Location = new Point(96, 303);
            groupBoxFuncao.Name = "groupBoxFuncao";
            groupBoxFuncao.Size = new Size(182, 129);
            groupBoxFuncao.TabIndex = 12;
            groupBoxFuncao.TabStop = false;
            groupBoxFuncao.Text = "FUNÇÃO";
            groupBoxFuncao.KeyDown += TabEvent;
            // 
            // radioEntregador
            // 
            radioEntregador.AutoSize = true;
            radioEntregador.Location = new Point(6, 97);
            radioEntregador.Name = "radioEntregador";
            radioEntregador.Size = new Size(14, 13);
            radioEntregador.TabIndex = 14;
            radioEntregador.TabStop = true;
            radioEntregador.UseVisualStyleBackColor = true;
            radioEntregador.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioAtendente
            // 
            radioAtendente.AutoSize = true;
            radioAtendente.Location = new Point(6, 60);
            radioAtendente.Name = "radioAtendente";
            radioAtendente.Size = new Size(14, 13);
            radioAtendente.TabIndex = 13;
            radioAtendente.TabStop = true;
            radioAtendente.UseVisualStyleBackColor = true;
            radioAtendente.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioAdministrador
            // 
            radioAdministrador.AutoSize = true;
            radioAdministrador.Location = new Point(6, 22);
            radioAdministrador.Name = "radioAdministrador";
            radioAdministrador.Size = new Size(14, 13);
            radioAdministrador.TabIndex = 12;
            radioAdministrador.TabStop = true;
            radioAdministrador.UseVisualStyleBackColor = true;
            radioAdministrador.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // FormFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(969, 559);
            Controls.Add(panelFuncionarios);
            Name = "FormFuncionario";
            Text = "Cadastro de Funcionário";
            Load += Form1_Load;
            panelFuncionarios.ResumeLayout(false);
            panelFuncionarios.PerformLayout();
            panelEndereco.ResumeLayout(false);
            panelEndereco.PerformLayout();
            groupBoxFuncao.ResumeLayout(false);
            groupBoxFuncao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalvar;
        private Label lblId;
        private TextBox txtId;
        private Label lblCpf;
        private Label lblMatricula;
        private Label labelNomeFuncionario;
        private Label lblTelefone;
        private Label labelEmail;
        private Label labelCnh;
        private Label lblValidade;
        private Label lblSenha;
        private Panel panelFuncionarios;
        private GroupBox groupBoxFuncao;
        private RadioButton radioEntregador;
        private RadioButton radioAtendente;
        private RadioButton radioAdministrador;
        private Button btnExcluir;
        private TextBox textBoxEmail;
        private TextBox TextBoxNome;
        private TextBox txtMatricula;
        private TextBox textBoxCnh;
        private Label lblObs;
        private TextBox txtObs;
        private DateTimePicker calendarioCnh;
        private MaskedTextBox txtSenha;
        private MaskedTextBox txtCpf;
        private MaskedTextBox txtTelefone;
        private Label lblFuncionarios;
        private Label labelNome;
        private Label labelMatricula;
        private Label label1;
        private Label labelObs;
        private Label labelSenha;
        private Label labelValidadeCNH;
        private Label labelHabilitacao;
        private Label labelMail;
        private Label labelTelefone;
        private Button btnVoltar;
        private Panel panelEndereco;
        private Label lblBairro;
        private TextBox txtBairro;
        private ComboBox dropBoxUf;
        private Label lblUf;
        private Label lblCidade;
        private Label lblPais;
        private Label lblLogradouro;
        private TextBox txtLogradouro;
        private TextBox txtCep;
        private TextBox textBoxEnderecoId;
        private Label lblCep;
        private Label labelId;
        private Label labelBairro;
        private Label labelCep;
        private Label labelLogradouro;
        private Label labelUf;
        private Label labelPais;
        private TextBox textBoxPais;
        private Label labelNumero;
        private Label labelComplemento;
        private TextBox textBoxComplemento;
        private TextBox textBoxNumero;
        private MaskedTextBox maskedTextBoxCep;
    }
}