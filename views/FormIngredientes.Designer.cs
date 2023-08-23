namespace PizzariaDoZe.views
{
    partial class FormIngredientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngredientes));
            btnSalvar = new Button();
            btnEditar = new Button();
            btnDeletar = new Button();
            btnFechar = new Button();
            lblCadastroIngredientes = new Label();
            textId = new TextBox();
            lblId = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            panelIngredientes = new Panel();
            panelIngredientes.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Green;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(29, 427);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(192, 93);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleLeft;
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(0, 0, 192);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(254, 427);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(192, 93);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleLeft;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.Maroon;
            btnDeletar.ForeColor = Color.White;
            btnDeletar.Image = (Image)resources.GetObject("btnDeletar.Image");
            btnDeletar.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeletar.Location = new Point(478, 427);
            btnDeletar.Margin = new Padding(3, 4, 3, 4);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(192, 93);
            btnDeletar.TabIndex = 11;
            btnDeletar.Text = "Deletar";
            btnDeletar.TextAlign = ContentAlignment.MiddleLeft;
            btnDeletar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeletar.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Black;
            btnFechar.ForeColor = Color.White;
            btnFechar.Image = (Image)resources.GetObject("btnFechar.Image");
            btnFechar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFechar.Location = new Point(697, 427);
            btnFechar.Margin = new Padding(3, 4, 3, 4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(192, 93);
            btnFechar.TabIndex = 12;
            btnFechar.Text = "Fechar";
            btnFechar.TextAlign = ContentAlignment.MiddleLeft;
            btnFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // lblCadastroIngredientes
            // 
            lblCadastroIngredientes.AutoSize = true;
            lblCadastroIngredientes.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastroIngredientes.Location = new Point(64, 52);
            lblCadastroIngredientes.Name = "lblCadastroIngredientes";
            lblCadastroIngredientes.Size = new Size(473, 57);
            lblCadastroIngredientes.TabIndex = 13;
            lblCadastroIngredientes.Text = "Cadastrar Ingredientes";
            // 
            // textId
            // 
            textId.Location = new Point(62, 61);
            textId.Margin = new Padding(3, 4, 3, 4);
            textId.Name = "textId";
            textId.Size = new Size(122, 27);
            textId.TabIndex = 14;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.White;
            lblId.Location = new Point(62, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 20);
            lblId.TabIndex = 15;
            lblId.Text = "ID:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(272, 61);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(294, 27);
            txtNome.TabIndex = 16;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(272, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 17;
            lblNome.Text = "Nome:";
            // 
            // panelIngredientes
            // 
            panelIngredientes.BackColor = Color.FromArgb(64, 64, 64);
            panelIngredientes.Controls.Add(txtNome);
            panelIngredientes.Controls.Add(lblNome);
            panelIngredientes.Controls.Add(textId);
            panelIngredientes.Controls.Add(lblId);
            panelIngredientes.Location = new Point(29, 184);
            panelIngredientes.Margin = new Padding(3, 4, 3, 4);
            panelIngredientes.Name = "panelIngredientes";
            panelIngredientes.Size = new Size(861, 129);
            panelIngredientes.TabIndex = 18;
            // 
            // FormIngredientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panelIngredientes);
            Controls.Add(lblCadastroIngredientes);
            Controls.Add(btnFechar);
            Controls.Add(btnDeletar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormIngredientes";
            Text = "Ingredientes";
            panelIngredientes.ResumeLayout(false);
            panelIngredientes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Button btnEditar;
        private Button btnDeletar;
        private Button btnFechar;
        private Label lblCadastroIngredientes;
        private TextBox textId;
        private Label lblId;
        private TextBox txtNome;
        private Label lblNome;
        private Panel panelIngredientes;
    }
}