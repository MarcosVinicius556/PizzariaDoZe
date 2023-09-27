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
            btnSalvar.Location = new Point(212, 383);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 32);
            btnSalvar.TabIndex = 0;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(21, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 1;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(21, 37);
            txtId.Name = "txtId";
            txtId.Size = new Size(42, 23);
            txtId.TabIndex = 2;
            txtId.KeyDown += txtId_KeyDown;
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
            labelEmail.Location = new Point(198, 158);
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
            panelFuncionarios.Location = new Point(17, 21);
            panelFuncionarios.Name = "panelFuncionarios";
            panelFuncionarios.Size = new Size(652, 356);
            panelFuncionarios.TabIndex = 11;
            panelFuncionarios.Paint += panel1_Paint;
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
            txtTelefone.Location = new Point(21, 176);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(168, 23);
            txtTelefone.TabIndex = 24;
            txtTelefone.KeyDown += txtTelefone_KeyDown;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(126, 37);
            txtCpf.Mask = "00000-000";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(147, 23);
            txtCpf.TabIndex = 15;
            txtCpf.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            txtCpf.KeyDown += txtCpf_KeyDown;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(312, 234);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 23;
            txtSenha.KeyDown += txtSenha_KeyDown;
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
            txtObs.Location = new Point(15, 285);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(544, 68);
            txtObs.TabIndex = 21;
            txtObs.KeyDown += txtObs_KeyDown;
            // 
            // calendarioCnh
            // 
            calendarioCnh.Format = DateTimePickerFormat.Short;
            calendarioCnh.Location = new Point(186, 231);
            calendarioCnh.Name = "calendarioCnh";
            calendarioCnh.Size = new Size(110, 23);
            calendarioCnh.TabIndex = 19;
            calendarioCnh.KeyDown += calendarioCnh_KeyDown;
            // 
            // textBoxCnh
            // 
            textBoxCnh.Location = new Point(21, 231);
            textBoxCnh.Name = "textBoxCnh";
            textBoxCnh.Size = new Size(150, 23);
            textBoxCnh.TabIndex = 18;
            textBoxCnh.KeyDown += textBoxCnh_KeyDown;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(195, 176);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(281, 23);
            textBoxEmail.TabIndex = 17;
            textBoxEmail.KeyDown += textBoxEmail_KeyDown;
            // 
            // TextBox4
            // 
            TextBox4.Location = new Point(21, 101);
            TextBox4.Name = "TextBox4";
            TextBox4.Size = new Size(405, 23);
            TextBox4.TabIndex = 15;
            TextBox4.KeyDown += TextBox4_KeyDown;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(302, 37);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(127, 23);
            txtMatricula.TabIndex = 14;
            txtMatricula.KeyDown += txtMatricula_KeyDown;
            // 
            // groupBoxFuncao
            // 
            groupBoxFuncao.Controls.Add(radioEntregador);
            groupBoxFuncao.Controls.Add(radioAtendente);
            groupBoxFuncao.Controls.Add(radioAdministrador);
            groupBoxFuncao.Location = new Point(451, 19);
            groupBoxFuncao.Name = "groupBoxFuncao";
            groupBoxFuncao.Size = new Size(182, 132);
            groupBoxFuncao.TabIndex = 12;
            groupBoxFuncao.TabStop = false;
            groupBoxFuncao.Text = "FUNÇÃO";
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
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.LightCoral;
            btnExcluir.Location = new Point(418, 383);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 32);
            btnExcluir.TabIndex = 13;
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.CornflowerBlue;
            btnEditar.Location = new Point(318, 383);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 32);
            btnEditar.TabIndex = 14;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // FormFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 427);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(panelFuncionarios);
            Controls.Add(btnSalvar);
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