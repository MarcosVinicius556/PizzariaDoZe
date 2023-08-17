namespace PizzariaDoZe.views
{
    partial class FormValores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem7 = new ListViewItem("Tradicional");
            ListViewItem listViewItem8 = new ListViewItem("Especial");
            ListViewItem listViewItem9 = new ListViewItem("Pequena");
            ListViewItem listViewItem10 = new ListViewItem("Média");
            ListViewItem listViewItem11 = new ListViewItem("Grande");
            ListViewItem listViewItem12 = new ListViewItem("Familia");
            fecharTela = new Button();
            excluirPizza = new Button();
            EditarPizza = new Button();
            salvarPizza = new Button();
            label5 = new Label();
            label4 = new Label();
            categoriaPizza = new ListView();
            tamanhoPizza = new ListView();
            label3 = new Label();
            label2 = new Label();
            valorBordaPizza = new TextBox();
            valorPizza = new TextBox();
            idPizza = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // fecharTela
            // 
            fecharTela.BackColor = Color.MediumBlue;
            fecharTela.ForeColor = SystemColors.Control;
            fecharTela.Location = new Point(418, 232);
            fecharTela.Name = "fecharTela";
            fecharTela.Size = new Size(110, 33);
            fecharTela.TabIndex = 27;
            fecharTela.Text = "Fechar";
            fecharTela.UseVisualStyleBackColor = false;
            // 
            // excluirPizza
            // 
            excluirPizza.BackColor = Color.Red;
            excluirPizza.ForeColor = SystemColors.Control;
            excluirPizza.Location = new Point(295, 232);
            excluirPizza.Name = "excluirPizza";
            excluirPizza.Size = new Size(110, 33);
            excluirPizza.TabIndex = 26;
            excluirPizza.Text = "Excluir";
            excluirPizza.UseVisualStyleBackColor = false;
            // 
            // EditarPizza
            // 
            EditarPizza.BackColor = Color.LightSeaGreen;
            EditarPizza.ForeColor = SystemColors.Control;
            EditarPizza.Location = new Point(172, 232);
            EditarPizza.Name = "EditarPizza";
            EditarPizza.Size = new Size(110, 33);
            EditarPizza.TabIndex = 25;
            EditarPizza.Text = "Editar";
            EditarPizza.UseVisualStyleBackColor = false;
            // 
            // salvarPizza
            // 
            salvarPizza.BackColor = Color.Lime;
            salvarPizza.ForeColor = SystemColors.Control;
            salvarPizza.ImageAlign = ContentAlignment.MiddleLeft;
            salvarPizza.Location = new Point(48, 232);
            salvarPizza.Margin = new Padding(0);
            salvarPizza.Name = "salvarPizza";
            salvarPizza.Size = new Size(110, 33);
            salvarPizza.TabIndex = 24;
            salvarPizza.Text = "Salvar";
            salvarPizza.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 31);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 23;
            label5.Text = "Categoria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 31);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 22;
            label4.Text = "Tamanho:";
            // 
            // categoriaPizza
            // 
            categoriaPizza.Items.AddRange(new ListViewItem[] { listViewItem7, listViewItem8 });
            categoriaPizza.Location = new Point(407, 49);
            categoriaPizza.Name = "categoriaPizza";
            categoriaPizza.Size = new Size(121, 157);
            categoriaPizza.TabIndex = 21;
            categoriaPizza.UseCompatibleStateImageBehavior = false;
            categoriaPizza.View = View.List;
            // 
            // tamanhoPizza
            // 
            tamanhoPizza.Items.AddRange(new ListViewItem[] { listViewItem9, listViewItem10, listViewItem11, listViewItem12 });
            tamanhoPizza.Location = new Point(270, 49);
            tamanhoPizza.Name = "tamanhoPizza";
            tamanhoPizza.Size = new Size(121, 157);
            tamanhoPizza.TabIndex = 20;
            tamanhoPizza.UseCompatibleStateImageBehavior = false;
            tamanhoPizza.View = View.List;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 165);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 19;
            label3.Text = "Valor adicional borda:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 93);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 18;
            label2.Text = "Valor:";
            // 
            // valorBordaPizza
            // 
            valorBordaPizza.Location = new Point(48, 183);
            valorBordaPizza.Name = "valorBordaPizza";
            valorBordaPizza.Size = new Size(180, 23);
            valorBordaPizza.TabIndex = 17;
            // 
            // valorPizza
            // 
            valorPizza.Location = new Point(48, 111);
            valorPizza.Name = "valorPizza";
            valorPizza.Size = new Size(180, 23);
            valorPizza.TabIndex = 16;
            // 
            // idPizza
            // 
            idPizza.BackColor = SystemColors.InactiveCaption;
            idPizza.Enabled = false;
            idPizza.Location = new Point(48, 49);
            idPizza.Name = "idPizza";
            idPizza.Size = new Size(67, 23);
            idPizza.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 31);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 14;
            label1.Text = "ID:";
            // 
            // FormValores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(572, 297);
            Controls.Add(fecharTela);
            Controls.Add(excluirPizza);
            Controls.Add(EditarPizza);
            Controls.Add(salvarPizza);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(categoriaPizza);
            Controls.Add(tamanhoPizza);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(valorBordaPizza);
            Controls.Add(valorPizza);
            Controls.Add(idPizza);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormValores";
            ShowIcon = false;
            Text = "Cadastrar valor pizza";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button fecharTela;
        private Button excluirPizza;
        private Button EditarPizza;
        private Button salvarPizza;
        private Label label5;
        private Label label4;
        private ListView categoriaPizza;
        private ListView tamanhoPizza;
        private Label label3;
        private Label label2;
        private TextBox valorBordaPizza;
        private TextBox valorPizza;
        private TextBox idPizza;
        private Label label1;
    }
}