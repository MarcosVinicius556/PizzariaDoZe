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
            btnFechar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            lblCategoria = new Label();
            lblTamanho = new Label();
            txtCategoria = new ListView();
            txtTamanho = new ListView();
            lblAdicionalBorda = new Label();
            lblValor = new Label();
            txtAdicionalBorda = new TextBox();
            txtValor = new TextBox();
            txtId = new TextBox();
            lblId = new Label();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.MediumBlue;
            btnFechar.ForeColor = SystemColors.Control;
            btnFechar.Location = new Point(418, 232);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(110, 33);
            btnFechar.TabIndex = 27;
            btnFechar.Text = Properties.Resources.ResourceManager.GetString("Fechar");
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.ForeColor = SystemColors.Control;
            btnExcluir.Location = new Point(295, 232);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 33);
            btnExcluir.TabIndex = 26;
            btnExcluir.Text = Properties.Resources.ResourceManager.GetString("Excluir");
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.LightSeaGreen;
            btnEditar.ForeColor = SystemColors.Control;
            btnEditar.Location = new Point(172, 232);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 33);
            btnEditar.TabIndex = 25;
            btnEditar.Text = Properties.Resources.ResourceManager.GetString("Editar");
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.ForeColor = SystemColors.Control;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(48, 232);
            btnSalvar.Margin = new Padding(0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 33);
            btnSalvar.TabIndex = 24;
            btnSalvar.Text = Properties.Resources.ResourceManager.GetString("Salvar");
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(407, 31);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 23;
            lblCategoria.Text = Properties.Resources.ResourceManager.GetString("Categoria");
            // 
            // lblTamanho
            // 
            lblTamanho.AutoSize = true;
            lblTamanho.Location = new Point(270, 31);
            lblTamanho.Name = "lblTamanho";
            lblTamanho.Size = new Size(59, 15);
            lblTamanho.TabIndex = 22;
            lblTamanho.Text = Properties.Resources.ResourceManager.GetString("tamanho");
            // 
            // txtCategoria
            // 
            txtCategoria.Items.AddRange(new ListViewItem[] { listViewItem7, listViewItem8 });
            txtCategoria.Location = new Point(407, 49);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(121, 157);
            txtCategoria.TabIndex = 21;
            txtCategoria.UseCompatibleStateImageBehavior = false;
            txtCategoria.View = View.List;
            // 
            // txtTamanho
            // 
            txtTamanho.Items.AddRange(new ListViewItem[] { listViewItem9, listViewItem10, listViewItem11, listViewItem12 });
            txtTamanho.Location = new Point(270, 49);
            txtTamanho.Name = "txtTamanho";
            txtTamanho.Size = new Size(121, 157);
            txtTamanho.TabIndex = 20;
            txtTamanho.UseCompatibleStateImageBehavior = false;
            txtTamanho.View = View.List;
            // 
            // lblAdicionalBorda
            // 
            lblAdicionalBorda.AutoSize = true;
            lblAdicionalBorda.Location = new Point(48, 165);
            lblAdicionalBorda.Name = "lblAdicionalBorda";
            lblAdicionalBorda.Size = new Size(121, 15);
            lblAdicionalBorda.TabIndex = 19;
            lblAdicionalBorda.Text = Properties.Resources.ResourceManager.GetString("Valor Adicional Borda");
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(48, 93);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(36, 15);
            lblValor.TabIndex = 18;
            lblValor.Text = Properties.Resources.ResourceManager.GetString("Valor");
            // 
            // txtAdicionalBorda
            // 
            txtAdicionalBorda.Location = new Point(48, 183);
            txtAdicionalBorda.Name = "txtAdicionalBorda";
            txtAdicionalBorda.Size = new Size(180, 23);
            txtAdicionalBorda.TabIndex = 17;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(48, 111);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(180, 23);
            txtValor.TabIndex = 16;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.InactiveCaption;
            txtId.Enabled = false;
            txtId.Location = new Point(48, 49);
            txtId.Name = "txtId";
            txtId.Size = new Size(67, 23);
            txtId.TabIndex = 15;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(48, 31);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 14;
            lblId.Text = "ID:";
            // 
            // FormValores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(572, 297);
            Controls.Add(btnFechar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(lblCategoria);
            Controls.Add(lblTamanho);
            Controls.Add(txtCategoria);
            Controls.Add(txtTamanho);
            Controls.Add(lblAdicionalBorda);
            Controls.Add(lblValor);
            Controls.Add(txtAdicionalBorda);
            Controls.Add(txtValor);
            Controls.Add(txtId);
            Controls.Add(lblId);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormValores";
            ShowIcon = false;
            Text = "Cadastrar valor pizza";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFechar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
        private Label lblCategoria;
        private Label lblTamanho;
        private ListView txtCategoria;
        private ListView txtTamanho;
        private Label lblAdicionalBorda;
        private Label lblValor;
        private TextBox txtAdicionalBorda;
        private TextBox txtValor;
        private TextBox txtId;
        private Label lblId;
    }
}