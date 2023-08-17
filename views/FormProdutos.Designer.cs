namespace PizzariaDoZe.views
{
    partial class FormProdutos
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
            ListViewItem listViewItem13 = new ListViewItem("Refrigerante");
            ListViewItem listViewItem14 = new ListViewItem("Cerveja");
            ListViewItem listViewItem15 = new ListViewItem("Suco");
            ListViewItem listViewItem16 = new ListViewItem("Água");
            ListViewItem listViewItem17 = new ListViewItem("Chocoleite");
            ListViewItem listViewItem18 = new ListViewItem("Outros");
            ListViewItem listViewItem19 = new ListViewItem("150");
            ListViewItem listViewItem20 = new ListViewItem("300");
            ListViewItem listViewItem21 = new ListViewItem("600");
            ListViewItem listViewItem22 = new ListViewItem("1000");
            ListViewItem listViewItem23 = new ListViewItem("1500");
            ListViewItem listViewItem24 = new ListViewItem("2000");
            label1 = new Label();
            idProduto = new TextBox();
            nomeProduto = new TextBox();
            valorProduto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tipoProduto = new ListView();
            mlProduto = new ListView();
            label4 = new Label();
            label5 = new Label();
            fecharTela = new Button();
            excluirProdutos = new Button();
            editarProdutos = new Button();
            salvarProdutos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 31);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // idProduto
            // 
            idProduto.BackColor = SystemColors.InactiveCaption;
            idProduto.Enabled = false;
            idProduto.Location = new Point(46, 49);
            idProduto.Name = "idProduto";
            idProduto.Size = new Size(67, 23);
            idProduto.TabIndex = 1;
            // 
            // nomeProduto
            // 
            nomeProduto.Location = new Point(46, 111);
            nomeProduto.Name = "nomeProduto";
            nomeProduto.Size = new Size(180, 23);
            nomeProduto.TabIndex = 2;
            // 
            // valorProduto
            // 
            valorProduto.Location = new Point(46, 183);
            valorProduto.Name = "valorProduto";
            valorProduto.Size = new Size(180, 23);
            valorProduto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 93);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 165);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Valor:";
            // 
            // tipoProduto
            // 
            tipoProduto.Items.AddRange(new ListViewItem[] { listViewItem13, listViewItem14, listViewItem15, listViewItem16, listViewItem17, listViewItem18 });
            tipoProduto.Location = new Point(268, 49);
            tipoProduto.Name = "tipoProduto";
            tipoProduto.Size = new Size(121, 157);
            tipoProduto.TabIndex = 6;
            tipoProduto.UseCompatibleStateImageBehavior = false;
            tipoProduto.View = View.List;
            // 
            // mlProduto
            // 
            mlProduto.Items.AddRange(new ListViewItem[] { listViewItem19, listViewItem20, listViewItem21, listViewItem22, listViewItem23, listViewItem24 });
            mlProduto.Location = new Point(405, 49);
            mlProduto.Name = "mlProduto";
            mlProduto.Size = new Size(121, 157);
            mlProduto.TabIndex = 7;
            mlProduto.UseCompatibleStateImageBehavior = false;
            mlProduto.View = View.List;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 31);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 8;
            label4.Text = "Tipo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 31);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 9;
            label5.Text = "ML:";
            // 
            // fecharTela
            // 
            fecharTela.BackColor = Color.MediumBlue;
            fecharTela.ForeColor = SystemColors.Control;
            fecharTela.Location = new Point(416, 233);
            fecharTela.Name = "fecharTela";
            fecharTela.Size = new Size(110, 33);
            fecharTela.TabIndex = 31;
            fecharTela.Text = "Fechar";
            fecharTela.UseVisualStyleBackColor = false;
            // 
            // excluirProdutos
            // 
            excluirProdutos.BackColor = Color.Red;
            excluirProdutos.ForeColor = SystemColors.Control;
            excluirProdutos.Location = new Point(293, 233);
            excluirProdutos.Name = "excluirProdutos";
            excluirProdutos.Size = new Size(110, 33);
            excluirProdutos.TabIndex = 30;
            excluirProdutos.Text = "Excluir";
            excluirProdutos.UseVisualStyleBackColor = false;
            // 
            // editarProdutos
            // 
            editarProdutos.BackColor = Color.Turquoise;
            editarProdutos.ForeColor = SystemColors.Control;
            editarProdutos.Location = new Point(170, 233);
            editarProdutos.Name = "editarProdutos";
            editarProdutos.Size = new Size(110, 33);
            editarProdutos.TabIndex = 29;
            editarProdutos.Text = "Editar";
            editarProdutos.UseVisualStyleBackColor = false;
            // 
            // salvarProdutos
            // 
            salvarProdutos.BackColor = Color.Lime;
            salvarProdutos.ForeColor = SystemColors.Control;
            salvarProdutos.Location = new Point(46, 233);
            salvarProdutos.Name = "salvarProdutos";
            salvarProdutos.Size = new Size(110, 33);
            salvarProdutos.TabIndex = 28;
            salvarProdutos.Text = "Salvar";
            salvarProdutos.UseVisualStyleBackColor = false;
            // 
            // FormProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(572, 297);
            Controls.Add(fecharTela);
            Controls.Add(excluirProdutos);
            Controls.Add(editarProdutos);
            Controls.Add(salvarProdutos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(mlProduto);
            Controls.Add(tipoProduto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(valorProduto);
            Controls.Add(nomeProduto);
            Controls.Add(idProduto);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormProdutos";
            ShowIcon = false;
            Text = "Cadastro de produtos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox idProduto;
        private TextBox nomeProduto;
        private TextBox valorProduto;
        private Label label2;
        private Label label3;
        private ListView tipoProduto;
        private ListView mlProduto;
        private Label label4;
        private Label label5;
        private Button fecharTela;
        private Button excluirProdutos;
        private Button editarProdutos;
        private Button salvarProdutos;
    }
}