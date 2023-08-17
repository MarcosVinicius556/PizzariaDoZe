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
            labelIdProutos = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelNomePizza = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            panel2 = new Panel();
            label4 = new Label();
            ButtonEditar = new Button();
            ButtonExcluir = new Button();
            ButtonSalvar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelNomePizza);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(labelIdProutos);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // labelIdProutos
            // 
            labelIdProutos.AutoSize = true;
            labelIdProutos.Location = new Point(27, 10);
            labelIdProutos.Name = "labelIdProutos";
            labelIdProutos.Size = new Size(21, 15);
            labelIdProutos.TabIndex = 0;
            labelIdProutos.Text = "ID:";
            labelIdProutos.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(69, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(405, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // labelNomePizza
            // 
            labelNomePizza.AutoSize = true;
            labelNomePizza.Location = new Point(27, 86);
            labelNomePizza.Name = "labelNomePizza";
            labelNomePizza.Size = new Size(45, 15);
            labelNomePizza.TabIndex = 3;
            labelNomePizza.Text = "NOME:";
            labelNomePizza.Click += labelNomePizza_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(574, 10);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 4;
            label1.Text = "INGREDIENTES";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(574, 30);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 358);
            textBox3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 151);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 6;
            label2.Text = "TIPO:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 151);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 7;
            label3.Text = "CATEGORIA:";
            label3.Click += label3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(22, 169);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(141, 112);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(237, 169);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(141, 112);
            textBox5.TabIndex = 9;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(22, 312);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 111);
            panel2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 294);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "FOTO:";
            label4.Click += label4_Click;
            // 
            // ButtonEditar
            // 
            ButtonEditar.BackColor = Color.CornflowerBlue;
            ButtonEditar.Location = new Point(315, 454);
            ButtonEditar.Name = "ButtonEditar";
            ButtonEditar.Size = new Size(75, 32);
            ButtonEditar.TabIndex = 17;
            ButtonEditar.Text = "EDITAR";
            ButtonEditar.UseVisualStyleBackColor = false;
            // 
            // ButtonExcluir
            // 
            ButtonExcluir.BackColor = Color.LightCoral;
            ButtonExcluir.Location = new Point(415, 454);
            ButtonExcluir.Name = "ButtonExcluir";
            ButtonExcluir.Size = new Size(75, 32);
            ButtonExcluir.TabIndex = 16;
            ButtonExcluir.Text = "EXCLUIR";
            ButtonExcluir.UseVisualStyleBackColor = false;
            // 
            // ButtonSalvar
            // 
            ButtonSalvar.BackColor = Color.LimeGreen;
            ButtonSalvar.Location = new Point(209, 454);
            ButtonSalvar.Name = "ButtonSalvar";
            ButtonSalvar.Size = new Size(75, 32);
            ButtonSalvar.TabIndex = 15;
            ButtonSalvar.Text = "SALVAR";
            ButtonSalvar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 498);
            Controls.Add(ButtonEditar);
            Controls.Add(ButtonExcluir);
            Controls.Add(ButtonSalvar);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label labelIdProutos;
        private TextBox textBox4;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private Label label1;
        private Label labelNomePizza;
        private Panel panel2;
        private TextBox textBox5;
        private Label label4;
        private Button ButtonEditar;
        private Button ButtonExcluir;
        private Button ButtonSalvar;
    }
}