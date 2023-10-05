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
            lblId = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtValor = new TextBox();
            lblNome = new Label();
            lblValor = new Label();
            groupBoxTipo = new ListView();
            groupBoxMl = new ListView();
            lblTipo = new Label();
            lblMl = new Label();
            btnFechar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(46, 31);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.InactiveCaption;
            txtId.Enabled = false;
            txtId.Location = new Point(46, 49);
            txtId.Name = "txtId";
            txtId.Size = new Size(67, 23);
            txtId.TabIndex = 1;
            txtId.KeyDown += TabEvent;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(46, 111);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(180, 23);
            txtNome.TabIndex = 2;
            txtNome.KeyDown += TabEvent;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(46, 183);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(180, 23);
            txtValor.TabIndex = 3;
            txtValor.KeyDown += TabEvent;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(46, 93);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = Properties.Resources.ResourceManager.GetString("Nome");
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(46, 165);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(36, 15);
            lblValor.TabIndex = 5;
            lblValor.Text = Properties.Resources.ResourceManager.GetString("Valor");
            // 
            // groupBoxTipo
            // 
            groupBoxTipo.Items.AddRange(new ListViewItem[] { listViewItem13, listViewItem14, listViewItem15, listViewItem16, listViewItem17, listViewItem18 });
            groupBoxTipo.Location = new Point(268, 49);
            groupBoxTipo.Name = "groupBoxTipo";
            groupBoxTipo.Size = new Size(121, 157);
            groupBoxTipo.TabIndex = 6;
            groupBoxTipo.UseCompatibleStateImageBehavior = false;
            groupBoxTipo.View = View.List;
            groupBoxTipo.KeyDown += TabEvent;
            // 
            // groupBoxMl
            // 
            groupBoxMl.Items.AddRange(new ListViewItem[] { listViewItem19, listViewItem20, listViewItem21, listViewItem22, listViewItem23, listViewItem24 });
            groupBoxMl.Location = new Point(405, 49);
            groupBoxMl.Name = "groupBoxMl";
            groupBoxMl.Size = new Size(121, 157);
            groupBoxMl.TabIndex = 7;
            groupBoxMl.UseCompatibleStateImageBehavior = false;
            groupBoxMl.View = View.List;
            groupBoxMl.KeyDown += TabEvent;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(268, 31);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(33, 15);
            lblTipo.TabIndex = 8;
            lblTipo.Text = Properties.Resources.ResourceManager.GetString("Tipo");
            // 
            // lblMl
            // 
            lblMl.AutoSize = true;
            lblMl.Location = new Point(405, 31);
            lblMl.Name = "lblMl";
            lblMl.Size = new Size(27, 15);
            lblMl.TabIndex = 9;
            lblMl.Text = Properties.Resources.ResourceManager.GetString("ML");
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.MediumBlue;
            btnFechar.ForeColor = SystemColors.Control;
            btnFechar.Location = new Point(416, 233);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(110, 33);
            btnFechar.TabIndex = 31;
            btnFechar.Text = Properties.Resources.ResourceManager.GetString("Fechar");
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.ForeColor = SystemColors.Control;
            btnExcluir.Location = new Point(293, 233);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 33);
            btnExcluir.TabIndex = 30;
            btnExcluir.Text = Properties.Resources.ResourceManager.GetString("Excluir");
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Turquoise;
            btnEditar.ForeColor = SystemColors.Control;
            btnEditar.Location = new Point(170, 233);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 33);
            btnEditar.TabIndex = 29;
            btnEditar.Text = Properties.Resources.ResourceManager.GetString("Editar");
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.ForeColor = SystemColors.Control;
            btnSalvar.Location = new Point(46, 233);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 33);
            btnSalvar.TabIndex = 28;
            btnSalvar.Text = Properties.Resources.ResourceManager.GetString("Salvar");
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // FormProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(572, 297);
            Controls.Add(btnFechar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(lblMl);
            Controls.Add(lblTipo);
            Controls.Add(groupBoxMl);
            Controls.Add(groupBoxTipo);
            Controls.Add(lblValor);
            Controls.Add(lblNome);
            Controls.Add(txtValor);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(lblId);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormProdutos";
            ShowIcon = false;
            Text = "Cadastro de produtos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtValor;
        private Label lblNome;
        private Label lblValor;
        private ListView groupBoxTipo;
        private ListView groupBoxMl;
        private Label lblTipo;
        private Label lblMl;
        private Button btnFechar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
    }
}