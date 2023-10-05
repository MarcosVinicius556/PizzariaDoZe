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
            btnSalvar.Location = new Point(25, 320);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(168, 70);
            btnSalvar.TabIndex = 9;
            btnSalvar.TextAlign = ContentAlignment.MiddleLeft;
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(0, 0, 192);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(222, 320);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(168, 70);
            btnEditar.TabIndex = 10;
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
            btnDeletar.Location = new Point(418, 320);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(168, 70);
            btnDeletar.TabIndex = 11;
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
            btnFechar.Location = new Point(610, 320);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(168, 70);
            btnFechar.TabIndex = 12;
            btnFechar.TextAlign = ContentAlignment.MiddleLeft;
            btnFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // lblCadastroIngredientes
            // 
            lblCadastroIngredientes.AutoSize = true;
            lblCadastroIngredientes.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastroIngredientes.Location = new Point(56, 39);
            lblCadastroIngredientes.Name = "lblCadastroIngredientes";
            lblCadastroIngredientes.Size = new Size(0, 45);
            lblCadastroIngredientes.TabIndex = 13;
            // 
            // textId
            // 
            textId.Location = new Point(54, 46);
            textId.Name = "textId";
            textId.Size = new Size(107, 23);
            textId.TabIndex = 14;
            textId.KeyDown += TabEvent;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.White;
            lblId.Location = new Point(54, 15);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 15;
            lblId.Text = "ID:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(238, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(258, 23);
            txtNome.TabIndex = 16;
            txtNome.KeyDown += TabEvent;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(238, 15);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(0, 15);
            lblNome.TabIndex = 17;
            // 
            // panelIngredientes
            // 
            panelIngredientes.BackColor = Color.FromArgb(64, 64, 64);
            panelIngredientes.Controls.Add(txtNome);
            panelIngredientes.Controls.Add(lblNome);
            panelIngredientes.Controls.Add(textId);
            panelIngredientes.Controls.Add(lblId);
            panelIngredientes.Location = new Point(25, 138);
            panelIngredientes.Name = "panelIngredientes";
            panelIngredientes.Size = new Size(753, 97);
            panelIngredientes.TabIndex = 18;
            // 
            // FormIngredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelIngredientes);
            Controls.Add(lblCadastroIngredientes);
            Controls.Add(btnFechar);
            Controls.Add(btnDeletar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Name = "FormIngredientes";
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