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
            lblFuncionarios = new Label();
            txtTelefone = new MaskedTextBox();
            txtCpf = new MaskedTextBox();
            txtSenha = new MaskedTextBox();
            lblObs = new Label();
            txtObs = new TextBox();
            calendarioCnh = new DateTimePicker();
            textBoxCnh = new TextBox();
            textBoxEmail = new TextBox();
            TextBox4 = new TextBox();
            txtMatricula = new TextBox();
            groupBoxFuncao = new GroupBox();
            radioEntregador = new RadioButton();
            radioAtendente = new RadioButton();
            radioAdministrador = new RadioButton();
            btnExcluir = new Button();
            btnEditar = new Button();
            panelFuncionarios.SuspendLayout();
            groupBoxFuncao.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.LimeGreen;
            btnSalvar.Location = new Point(242, 511);
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
            // labelNomeFuncionario
            // 
            labelNomeFuncionario.AutoSize = true;
            labelNomeFuncionario.Location = new Point(24, 111);
            labelNomeFuncionario.Name = "labelNomeFuncionario";
            labelNomeFuncionario.Size = new Size(55, 20);
            labelNomeFuncionario.TabIndex = 5;
            labelNomeFuncionario.Text = Properties.Resources.ResourceManager.GetString("Nome");
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
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(226, 211);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(60, 20);
            labelEmail.TabIndex = 7;
            labelEmail.Text = Properties.Resources.ResourceManager.GetString("Email");
            // 
            // labelCnh
            // 
            labelCnh.AutoSize = true;
            labelCnh.Location = new Point(24, 284);
            labelCnh.Name = "labelCnh";
            labelCnh.Size = new Size(40, 20);
            labelCnh.TabIndex = 8;
            labelCnh.Text = Properties.Resources.ResourceManager.GetString("CNH");
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
            // panelFuncionarios
            // 
            panelFuncionarios.BackColor = SystemColors.ActiveBorder;
            panelFuncionarios.Controls.Add(lblFuncionarios);
            panelFuncionarios.Controls.Add(txtTelefone);
            panelFuncionarios.Controls.Add(txtCpf);
            panelFuncionarios.Controls.Add(txtSenha);
            panelFuncionarios.Controls.Add(lblObs);
            panelFuncionarios.Controls.Add(txtObs);
            panelFuncionarios.Controls.Add(calendarioCnh);
            panelFuncionarios.Controls.Add(textBoxCnh);
            panelFuncionarios.Controls.Add(textBoxEmail);
            panelFuncionarios.Controls.Add(TextBox4);
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
            panelFuncionarios.Location = new Point(19, 28);
            panelFuncionarios.Margin = new Padding(3, 4, 3, 4);
            panelFuncionarios.Name = "panelFuncionarios";
            panelFuncionarios.Size = new Size(745, 475);
            panelFuncionarios.TabIndex = 11;
            panelFuncionarios.Paint += panel1_Paint;
            // 
            // lblFuncionarios
            // 
            lblFuncionarios.AutoSize = true;
            lblFuncionarios.Location = new Point(17, 0);
            lblFuncionarios.Name = "lblFuncionarios";
            lblFuncionarios.Size = new Size(194, 20);
            lblFuncionarios.TabIndex = 25;
            lblFuncionarios.Text = Properties.Resources.ResourceManager.GetString("Cadastro de Funcionários");
            lblFuncionarios.Click += label2_Click;
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
            txtObs.Size = new Size(621, 89);
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
            // textBoxCnh
            // 
            textBoxCnh.Location = new Point(24, 308);
            textBoxCnh.Margin = new Padding(3, 4, 3, 4);
            textBoxCnh.Name = "textBoxCnh";
            textBoxCnh.Size = new Size(171, 27);
            textBoxCnh.TabIndex = 18;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(223, 235);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(321, 27);
            textBoxEmail.TabIndex = 17;
            // 
            // TextBox4
            // 
            TextBox4.Location = new Point(24, 135);
            TextBox4.Margin = new Padding(3, 4, 3, 4);
            TextBox4.Name = "TextBox4";
            TextBox4.Size = new Size(462, 27);
            TextBox4.TabIndex = 15;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(345, 49);
            txtMatricula.Margin = new Padding(3, 4, 3, 4);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(145, 27);
            txtMatricula.TabIndex = 14;
            // 
            // groupBoxFuncao
            // 
            groupBoxFuncao.Controls.Add(radioEntregador);
            groupBoxFuncao.Controls.Add(radioAtendente);
            groupBoxFuncao.Controls.Add(radioAdministrador);
            groupBoxFuncao.Location = new Point(515, 25);
            groupBoxFuncao.Margin = new Padding(3, 4, 3, 4);
            groupBoxFuncao.Name = "groupBoxFuncao";
            groupBoxFuncao.Padding = new Padding(3, 4, 3, 4);
            groupBoxFuncao.Size = new Size(208, 176);
            groupBoxFuncao.TabIndex = 12;
            groupBoxFuncao.TabStop = false;
            groupBoxFuncao.Text = "FUNÇÃO";
            // 
            // radioEntregador
            // 
            radioEntregador.AutoSize = true;
            radioEntregador.Location = new Point(7, 129);
            radioEntregador.Margin = new Padding(3, 4, 3, 4);
            radioEntregador.Name = "radioEntregador";
            radioEntregador.Size = new Size(128, 24);
            radioEntregador.TabIndex = 14;
            radioEntregador.TabStop = true;
            radioEntregador.Text = Properties.Resources.ResourceManager.GetString("Entregador");
            radioEntregador.UseVisualStyleBackColor = true;
            radioEntregador.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioAtendente
            // 
            radioAtendente.AutoSize = true;
            radioAtendente.Location = new Point(7, 80);
            radioAtendente.Margin = new Padding(3, 4, 3, 4);
            radioAtendente.Name = "radioAtendente";
            radioAtendente.Size = new Size(115, 24);
            radioAtendente.TabIndex = 13;
            radioAtendente.TabStop = true;
            radioAtendente.Text = Properties.Resources.ResourceManager.GetString("Atendente");
            radioAtendente.UseVisualStyleBackColor = true;
            radioAtendente.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioAdministrador
            // 
            radioAdministrador.AutoSize = true;
            radioAdministrador.Location = new Point(7, 29);
            radioAdministrador.Margin = new Padding(3, 4, 3, 4);
            radioAdministrador.Name = "radioAdministrador";
            radioAdministrador.Size = new Size(152, 24);
            radioAdministrador.TabIndex = 12;
            radioAdministrador.TabStop = true;
            radioAdministrador.Text = Properties.Resources.ResourceManager.GetString("Administrador");
            radioAdministrador.UseVisualStyleBackColor = true;
            radioAdministrador.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.LightCoral;
            btnExcluir.Location = new Point(478, 511);
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
            btnEditar.Location = new Point(363, 511);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 43);
            btnEditar.TabIndex = 14;
            btnEditar.Text = Properties.Resources.ResourceManager.GetString("Editar");
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // FormFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 569);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(panelFuncionarios);
            Controls.Add(btnSalvar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormFuncionario";
            Text = "Form1";
            Load += Form1_Load;
            panelFuncionarios.ResumeLayout(false);
            panelFuncionarios.PerformLayout();
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
        private Button btnEditar;
        private TextBox textBoxEmail;
        private TextBox TextBox4;
        private TextBox txtMatricula;
        private TextBox textBoxCnh;
        private Label lblObs;
        private TextBox txtObs;
        private DateTimePicker calendarioCnh;
        private MaskedTextBox txtSenha;
        private MaskedTextBox txtCpf;
        private MaskedTextBox txtTelefone;
        private Label lblFuncionarios;
    }
}