﻿namespace PizzariaDoZe.views
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
            ButtonSalvar = new Button();
            labelId = new Label();
            textBoxId = new TextBox();
            labelCpf = new Label();
            labelMatricula = new Label();
            labelNomeFuncionario = new Label();
            labelTelefone = new Label();
            labelEmail = new Label();
            labelCnh = new Label();
            LabelValidade = new Label();
            LabelSenha = new Label();
            PanelRegistro = new Panel();
            label2 = new Label();
            MaskedTextBoxTelefone = new MaskedTextBox();
            maskedTextBoxCpf = new MaskedTextBox();
            maskedTextBoxSenhaFuncinario = new MaskedTextBox();
            labelObservacoes = new Label();
            textBox9 = new TextBox();
            Calendario = new DateTimePicker();
            textBoxCnh = new TextBox();
            textBoxEmail = new TextBox();
            TextBox4 = new TextBox();
            textBoxMatricula = new TextBox();
            ButtonExcluir = new Button();
            ButtonEditar = new Button();
            PanelRegistro.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonSalvar
            // 
            ButtonSalvar.BackColor = Color.LimeGreen;
            ButtonSalvar.Location = new Point(73, 383);
            ButtonSalvar.Name = "ButtonSalvar";
            ButtonSalvar.Size = new Size(75, 32);
            ButtonSalvar.TabIndex = 0;
            ButtonSalvar.Text = "SALVAR";
            ButtonSalvar.UseVisualStyleBackColor = false;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(21, 19);
            labelId.Name = "labelId";
            labelId.Size = new Size(21, 15);
            labelId.TabIndex = 1;
            labelId.Text = "ID:";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(21, 37);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(42, 23);
            textBoxId.TabIndex = 2;
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(126, 19);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(31, 15);
            labelCpf.TabIndex = 3;
            labelCpf.Text = "CPF:";
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Location = new Point(302, 19);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(74, 15);
            labelMatricula.TabIndex = 4;
            labelMatricula.Text = "MATRICULA:";
            // 
            // labelNomeFuncionario
            // 
            labelNomeFuncionario.AutoSize = true;
            labelNomeFuncionario.Location = new Point(21, 83);
            labelNomeFuncionario.Name = "labelNomeFuncionario";
            labelNomeFuncionario.Size = new Size(45, 15);
            labelNomeFuncionario.TabIndex = 5;
            labelNomeFuncionario.Text = "NOME:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(21, 158);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(64, 15);
            labelTelefone.TabIndex = 6;
            labelTelefone.Text = "TELEFONE:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(198, 158);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 15);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "E-MAIL:";
            // 
            // labelCnh
            // 
            labelCnh.AutoSize = true;
            labelCnh.Location = new Point(21, 213);
            labelCnh.Name = "labelCnh";
            labelCnh.Size = new Size(33, 15);
            labelCnh.TabIndex = 8;
            labelCnh.Text = "CNH";
            // 
            // LabelValidade
            // 
            LabelValidade.AutoSize = true;
            LabelValidade.Location = new Point(186, 213);
            LabelValidade.Name = "LabelValidade";
            LabelValidade.Size = new Size(63, 15);
            LabelValidade.TabIndex = 9;
            LabelValidade.Text = "VALIDADE:";
            LabelValidade.Click += LabelValidade_Click;
            // 
            // LabelSenha
            // 
            LabelSenha.AutoSize = true;
            LabelSenha.Location = new Point(312, 213);
            LabelSenha.Name = "LabelSenha";
            LabelSenha.Size = new Size(48, 15);
            LabelSenha.TabIndex = 10;
            LabelSenha.Text = "SENHA:";
            // 
            // PanelRegistro
            // 
            PanelRegistro.BackColor = SystemColors.ActiveBorder;
            PanelRegistro.Controls.Add(label2);
            PanelRegistro.Controls.Add(MaskedTextBoxTelefone);
            PanelRegistro.Controls.Add(maskedTextBoxCpf);
            PanelRegistro.Controls.Add(maskedTextBoxSenhaFuncinario);
            PanelRegistro.Controls.Add(labelObservacoes);
            PanelRegistro.Controls.Add(textBox9);
            PanelRegistro.Controls.Add(Calendario);
            PanelRegistro.Controls.Add(textBoxCnh);
            PanelRegistro.Controls.Add(textBoxEmail);
            PanelRegistro.Controls.Add(TextBox4);
            PanelRegistro.Controls.Add(textBoxMatricula);
            PanelRegistro.Controls.Add(LabelSenha);
            PanelRegistro.Controls.Add(labelTelefone);
            PanelRegistro.Controls.Add(labelEmail);
            PanelRegistro.Controls.Add(labelCnh);
            PanelRegistro.Controls.Add(LabelValidade);
            PanelRegistro.Controls.Add(labelNomeFuncionario);
            PanelRegistro.Controls.Add(labelId);
            PanelRegistro.Controls.Add(textBoxId);
            PanelRegistro.Controls.Add(labelCpf);
            PanelRegistro.Controls.Add(labelMatricula);
            PanelRegistro.Location = new Point(17, 21);
            PanelRegistro.Name = "PanelRegistro";
            PanelRegistro.Size = new Size(544, 356);
            PanelRegistro.TabIndex = 11;
            PanelRegistro.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 0);
            label2.Name = "label2";
            label2.Size = new Size(155, 15);
            label2.TabIndex = 25;
            label2.Text = "CADASTRO FUNCIONARIOS";
            label2.Click += label2_Click;
            // 
            // MaskedTextBoxTelefone
            // 
            MaskedTextBoxTelefone.Location = new Point(21, 176);
            MaskedTextBoxTelefone.Mask = "(99) 00000-0000";
            MaskedTextBoxTelefone.Name = "MaskedTextBoxTelefone";
            MaskedTextBoxTelefone.Size = new Size(168, 23);
            MaskedTextBoxTelefone.TabIndex = 24;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(126, 37);
            maskedTextBoxCpf.Mask = "00000-000";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(147, 23);
            maskedTextBoxCpf.TabIndex = 15;
            maskedTextBoxCpf.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // maskedTextBoxSenhaFuncinario
            // 
            maskedTextBoxSenhaFuncinario.Location = new Point(312, 234);
            maskedTextBoxSenhaFuncinario.Name = "maskedTextBoxSenhaFuncinario";
            maskedTextBoxSenhaFuncinario.PasswordChar = '*';
            maskedTextBoxSenhaFuncinario.Size = new Size(100, 23);
            maskedTextBoxSenhaFuncinario.TabIndex = 23;
            // 
            // labelObservacoes
            // 
            labelObservacoes.AutoSize = true;
            labelObservacoes.Location = new Point(15, 267);
            labelObservacoes.Name = "labelObservacoes";
            labelObservacoes.Size = new Size(84, 15);
            labelObservacoes.TabIndex = 22;
            labelObservacoes.Text = "OBSERVAÇÃO:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(15, 285);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(461, 68);
            textBox9.TabIndex = 21;
            // 
            // Calendario
            // 
            Calendario.Format = DateTimePickerFormat.Short;
            Calendario.Location = new Point(186, 231);
            Calendario.Name = "Calendario";
            Calendario.Size = new Size(110, 23);
            Calendario.TabIndex = 19;
            // 
            // textBoxCnh
            // 
            textBoxCnh.Location = new Point(21, 231);
            textBoxCnh.Name = "textBoxCnh";
            textBoxCnh.Size = new Size(150, 23);
            textBoxCnh.TabIndex = 18;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(195, 176);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(281, 23);
            textBoxEmail.TabIndex = 17;
            // 
            // TextBox4
            // 
            TextBox4.Location = new Point(21, 101);
            TextBox4.Name = "TextBox4";
            TextBox4.Size = new Size(455, 23);
            TextBox4.TabIndex = 15;
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Location = new Point(302, 37);
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(174, 23);
            textBoxMatricula.TabIndex = 14;
            // 
            // ButtonExcluir
            // 
            ButtonExcluir.BackColor = Color.LightCoral;
            ButtonExcluir.Location = new Point(302, 383);
            ButtonExcluir.Name = "ButtonExcluir";
            ButtonExcluir.Size = new Size(75, 32);
            ButtonExcluir.TabIndex = 13;
            ButtonExcluir.Text = "EXCLUIR";
            ButtonExcluir.UseVisualStyleBackColor = false;
            // 
            // ButtonEditar
            // 
            ButtonEditar.BackColor = Color.CornflowerBlue;
            ButtonEditar.Location = new Point(189, 383);
            ButtonEditar.Name = "ButtonEditar";
            ButtonEditar.Size = new Size(75, 32);
            ButtonEditar.TabIndex = 14;
            ButtonEditar.Text = "EDITAR";
            ButtonEditar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 419);
            Controls.Add(ButtonEditar);
            Controls.Add(ButtonExcluir);
            Controls.Add(PanelRegistro);
            Controls.Add(ButtonSalvar);
            Name = "Form1";
            Text = "FormCadastroClientes";
            Load += Form1_Load;
            PanelRegistro.ResumeLayout(false);
            PanelRegistro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonSalvar;
        private Label labelId;
        private TextBox textBoxId;
        private Label labelCpf;
        private Label labelMatricula;
        private Label labelNomeFuncionario;
        private Label labelTelefone;
        private Label labelEmail;
        private Label labelCnh;
        private Label LabelValidade;
        private Label LabelSenha;
        private Panel PanelRegistro;
        private Button ButtonExcluir;
        private Button ButtonEditar;
        private TextBox textBoxEmail;
        private TextBox TextBox4;
        private TextBox textBoxMatricula;
        private TextBox textBoxCnh;
        private Label labelObservacoes;
        private TextBox textBox9;
        private DateTimePicker Calendario;
        private MaskedTextBox maskedTextBoxSenhaFuncinario;
        private MaskedTextBox maskedTextBoxCpf;
        private MaskedTextBox MaskedTextBoxTelefone;
        private Label label2;
    }
}