﻿using System.Runtime.CompilerServices;

namespace PizzariaDoZe.views
{
    partial class FormSabores
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
            panel1 = new Panel();
            this.pictureBoxFoto = new PictureBox();
            txtTipo = new TextBox();
            txtCategoria = new TextBox();
            lblCategoria = new Label();
            lblTipo = new Label();
            this.txtIngredientes = new TextBox();
            this.lblIngredientes = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            txtId = new TextBox();
            lblId = new Label();
            this.btnEditar = new Button();
            this.btnExcluir = new Button();
            btnSalvar = new Button();
            pictureBoxFoto = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(pictureBoxFoto);
            panel1.Controls.Add(this.pictureBoxFoto);
            panel1.Controls.Add(txtTipo);
            panel1.Controls.Add(txtCategoria);
            panel1.Controls.Add(lblCategoria);
            panel1.Controls.Add(lblTipo);
            panel1.Controls.Add(this.txtIngredientes);
            panel1.Controls.Add(this.lblIngredientes);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(lblId);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // lblFoto
            // 
            this.pictureBoxFoto.AutoSize = true;
            this.pictureBoxFoto.Location = new Point(22, 294);
            this.pictureBoxFoto.Name = "lblFoto";
            this.pictureBoxFoto.Size = new Size(38, 15);
            this.pictureBoxFoto.TabIndex = 11;
            this.pictureBoxFoto.Text = "FOTO:";
            this.pictureBoxFoto.Click += this.label4_Click;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(237, 169);
            txtTipo.Multiline = true;
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(141, 112);
            txtTipo.TabIndex = 9;
            txtTipo.TextChanged += textBox5_TextChanged;
            txtTipo.KeyDown += TabEvent;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(22, 169);
            txtCategoria.Multiline = true;
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(141, 112);
            txtCategoria.TabIndex = 8;
            txtCategoria.TextChanged += textBox4_TextChanged;
            txtCategoria.KeyDown += TabEvent;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(22, 151);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(72, 15);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "CATEGORIA:";
            lblCategoria.Click += label3_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(237, 151);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(35, 15);
            lblTipo.TabIndex = 6;
            lblTipo.Text = "TIPO:";
            lblTipo.Click += label2_Click;
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Location = new Point(574, 30);
            this.txtIngredientes.Multiline = true;
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new Size(171, 358);
            this.txtIngredientes.TabIndex = 5;
            this.txtIngredientes.KeyDown += TabEvent;
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Location = new Point(574, 10);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new Size(84, 15);
            this.lblIngredientes.TabIndex = 4;
            this.lblIngredientes.Text = "INGREDIENTES";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(27, 86);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(45, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "NOME:";
            lblNome.Click += labelNomePizza_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(22, 104);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(405, 23);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += textBox2_TextChanged;
            txtNome.KeyDown += TabEvent;
            // 
            // txtId
            // 
            txtId.Location = new Point(27, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(69, 23);
            txtId.TabIndex = 1;
            txtId.TextChanged += textBox1_TextChanged;
            txtId.KeyDown += TabEvent;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(27, 10);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            lblId.Click += label1_Click;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = Color.CornflowerBlue;
            this.btnEditar.Location = new Point(315, 454);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new Size(75, 32);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = Color.LightCoral;
            this.btnExcluir.Location = new Point(415, 454);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new Size(75, 32);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.LimeGreen;
            btnSalvar.Location = new Point(209, 454);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 32);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // pictureBoxFoto
            // 
            pictureBoxFoto.Location = new Point(28, 327);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(206, 91);
            pictureBoxFoto.TabIndex = 12;
            pictureBoxFoto.TabStop = false;
            // 
            // FormSabores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 498);
            Controls.Add(this.btnEditar);
            Controls.Add(this.btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(panel1);
            Name = "FormSabores";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtNome;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtCategoria;
        private Label lblCategoria;
        private Label lblTipo;
        private TextBox txtTipo;
        private Label label1;
        private Label lblNome;
        private Panel panel2;
        private Label label4;
        private Button btnSalvar;
        private TextBox txtIngredientes;
        private PictureBox pictureBoxFoto;
        private Label lblIngredientes;
        private Button btnEditar;
        private Button btnExcluir;
    }
}