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
            ListViewItem listViewItem1 = new ListViewItem("Refrigerante");
            ListViewItem listViewItem2 = new ListViewItem("Cerveja");
            ListViewItem listViewItem3 = new ListViewItem("Suco");
            ListViewItem listViewItem4 = new ListViewItem("Água");
            ListViewItem listViewItem5 = new ListViewItem("Chocoleite");
            ListViewItem listViewItem6 = new ListViewItem("Outros");
            ListViewItem listViewItem7 = new ListViewItem("150");
            ListViewItem listViewItem8 = new ListViewItem("300");
            ListViewItem listViewItem9 = new ListViewItem("600");
            ListViewItem listViewItem10 = new ListViewItem("1000");
            ListViewItem listViewItem11 = new ListViewItem("1500");
            ListViewItem listViewItem12 = new ListViewItem("2000");
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
            txtId.KeyDown += txtId_KeyDown;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(46, 111);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(180, 23);
            txtNome.TabIndex = 2;
            txtNome.KeyDown += txtNome_KeyDown;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(46, 183);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(180, 23);
            txtValor.TabIndex = 3;
            txtValor.KeyDown += txtValor_KeyDown;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(46, 93);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(0, 15);
            lblNome.TabIndex = 4;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(46, 165);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(0, 15);
            lblValor.TabIndex = 5;
            // 
            // groupBoxTipo
            // 
            groupBoxTipo.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6 });
            groupBoxTipo.Location = new Point(268, 49);
            groupBoxTipo.Name = "groupBoxTipo";
            groupBoxTipo.Size = new Size(121, 157);
            groupBoxTipo.TabIndex = 6;
            groupBoxTipo.UseCompatibleStateImageBehavior = false;
            groupBoxTipo.View = View.List;
            groupBoxTipo.KeyDown += groupBoxTipo_KeyDown;
            // 
            // groupBoxMl
            // 
            groupBoxMl.Items.AddRange(new ListViewItem[] { listViewItem7, listViewItem8, listViewItem9, listViewItem10, listViewItem11, listViewItem12 });
            groupBoxMl.Location = new Point(405, 49);
            groupBoxMl.Name = "groupBoxMl";
            groupBoxMl.Size = new Size(121, 157);
            groupBoxMl.TabIndex = 7;
            groupBoxMl.UseCompatibleStateImageBehavior = false;
            groupBoxMl.View = View.List;
            groupBoxMl.KeyDown += groupBoxMl_KeyDown;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(268, 31);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(0, 15);
            lblTipo.TabIndex = 8;
            // 
            // lblMl
            // 
            lblMl.AutoSize = true;
            lblMl.Location = new Point(405, 31);
            lblMl.Name = "lblMl";
            lblMl.Size = new Size(0, 15);
            lblMl.TabIndex = 9;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.MediumBlue;
            btnFechar.ForeColor = SystemColors.Control;
            btnFechar.Location = new Point(416, 233);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(110, 33);
            btnFechar.TabIndex = 31;
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