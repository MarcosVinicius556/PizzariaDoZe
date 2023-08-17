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
            btn_salvar = new Button();
            btn_edit = new Button();
            btn_deletar = new Button();
            btn_fechar = new Button();
            lblCadastroIngredientes = new Label();
            textId = new TextBox();
            lbl_id = new Label();
            textBox1 = new TextBox();
            lblNome = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_salvar
            // 
            btn_salvar.BackColor = Color.Green;
            btn_salvar.ForeColor = Color.White;
            btn_salvar.Image = (Image)resources.GetObject("btn_salvar.Image");
            btn_salvar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salvar.Location = new Point(25, 320);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(168, 70);
            btn_salvar.TabIndex = 9;
            btn_salvar.Text = "Salvar";
            btn_salvar.TextAlign = ContentAlignment.MiddleLeft;
            btn_salvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salvar.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(0, 0, 192);
            btn_edit.ForeColor = Color.White;
            btn_edit.Image = (Image)resources.GetObject("btn_edit.Image");
            btn_edit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_edit.Location = new Point(222, 320);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(168, 70);
            btn_edit.TabIndex = 10;
            btn_edit.Text = "Editar";
            btn_edit.TextAlign = ContentAlignment.MiddleLeft;
            btn_edit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_deletar
            // 
            btn_deletar.BackColor = Color.Maroon;
            btn_deletar.ForeColor = Color.White;
            btn_deletar.Image = (Image)resources.GetObject("btn_deletar.Image");
            btn_deletar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_deletar.Location = new Point(418, 320);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(168, 70);
            btn_deletar.TabIndex = 11;
            btn_deletar.Text = "Deletar";
            btn_deletar.TextAlign = ContentAlignment.MiddleLeft;
            btn_deletar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_deletar.UseVisualStyleBackColor = false;
            // 
            // btn_fechar
            // 
            btn_fechar.BackColor = Color.Black;
            btn_fechar.ForeColor = Color.White;
            btn_fechar.Image = (Image)resources.GetObject("btn_fechar.Image");
            btn_fechar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_fechar.Location = new Point(610, 320);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(168, 70);
            btn_fechar.TabIndex = 12;
            btn_fechar.Text = "Sair";
            btn_fechar.TextAlign = ContentAlignment.MiddleLeft;
            btn_fechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_fechar.UseVisualStyleBackColor = false;
            // 
            // lblCadastroIngredientes
            // 
            lblCadastroIngredientes.AutoSize = true;
            lblCadastroIngredientes.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastroIngredientes.Location = new Point(56, 39);
            lblCadastroIngredientes.Name = "lblCadastroIngredientes";
            lblCadastroIngredientes.Size = new Size(372, 45);
            lblCadastroIngredientes.TabIndex = 13;
            lblCadastroIngredientes.Text = "Cadastrar Ingredientes";
            // 
            // textId
            // 
            textId.Location = new Point(54, 46);
            textId.Name = "textId";
            textId.Size = new Size(107, 23);
            textId.TabIndex = 14;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.ForeColor = Color.White;
            lbl_id.Location = new Point(54, 15);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(21, 15);
            lbl_id.TabIndex = 15;
            lbl_id.Text = "ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(238, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 23);
            textBox1.TabIndex = 16;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(238, 15);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 17;
            lblNome.Text = "Nome:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(textId);
            panel1.Controls.Add(lbl_id);
            panel1.Location = new Point(25, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(753, 97);
            panel1.TabIndex = 18;
            // 
            // FormIngredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(lblCadastroIngredientes);
            Controls.Add(btn_fechar);
            Controls.Add(btn_deletar);
            Controls.Add(btn_edit);
            Controls.Add(btn_salvar);
            Name = "FormIngredientes";
            Text = "Ingredientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_salvar;
        private Button btn_edit;
        private Button btn_deletar;
        private Button btn_fechar;
        private Label lblCadastroIngredientes;
        private TextBox textId;
        private Label lbl_id;
        private TextBox textBox1;
        private Label lblNome;
        private Panel panel1;
    }
}