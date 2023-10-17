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
            btnSalvar.Location = new Point(73, 383);
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
            panelClientes.Location = new Point(17, 21);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(544, 356);
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
            txtTelefone.Location = new Point(21, 176);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(168, 23);
            txtTelefone.TabIndex = 24;
            txtTelefone.KeyDown += TabEvent;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(126, 37);
            txtCpf.Mask = "00000-000";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(147, 23);
            txtCpf.TabIndex = 15;
            txtCpf.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            txtCpf.KeyDown += TabEvent;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(312, 234);
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
            txtObs.Location = new Point(15, 285);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(461, 68);
            txtObs.TabIndex = 21;
            txtObs.KeyDown += TabEvent;
            // 
            // calendarioCnh
            // 
            calendarioCnh.Format = DateTimePickerFormat.Short;
            calendarioCnh.Location = new Point(186, 231);
            calendarioCnh.Name = "calendarioCnh";
            calendarioCnh.Size = new Size(110, 23);
            calendarioCnh.TabIndex = 19;
            calendarioCnh.KeyDown += TabEvent;
            // 
            // txtCnh
            // 
            txtCnh.Location = new Point(21, 231);
            txtCnh.Name = "txtCnh";
            txtCnh.Size = new Size(150, 23);
            txtCnh.TabIndex = 18;
            txtCnh.KeyDown += TabEvent;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(195, 176);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(281, 23);
            txtEmail.TabIndex = 17;
            txtEmail.KeyDown += TabEvent;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(21, 101);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(455, 23);
            txtNome.TabIndex = 15;
            txtNome.KeyDown += TabEvent;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(302, 37);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(174, 23);
            txtMatricula.TabIndex = 14;
            txtMatricula.KeyDown += TabEvent;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.LightCoral;
            btnExcluir.Location = new Point(302, 383);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 32);
            btnExcluir.TabIndex = 13;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.CornflowerBlue;
            btnEditar.Location = new Point(189, 383);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 32);
            btnEditar.TabIndex = 14;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // FormCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 419);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(panelClientes);
            Controls.Add(btnSalvar);
            Name = "FormCadastroCliente";
            Text = "Cadastro de Clientes";
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