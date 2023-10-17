namespace PizzariaDoZe.views
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            btnEntrar = new Button();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            lblLogin = new Label();
            lblSenha = new Label();
            panelLogin = new Panel();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.ActiveBorder;
            btnEntrar.FlatAppearance.BorderColor = Color.Black;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.ForeColor = SystemColors.ButtonHighlight;
            btnEntrar.Image = (Image)resources.GetObject("btnEntrar.Image");
            btnEntrar.ImageAlign = ContentAlignment.MiddleRight;
            btnEntrar.Location = new Point(173, 158);
            btnEntrar.Margin = new Padding(2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(170, 45);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextAlign = ContentAlignment.MiddleLeft;
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtLogin.Location = new Point(121, 49);
            txtLogin.Margin = new Padding(2);
            txtLogin.MaximumSize = new Size(300, 300);
            txtLogin.MinimumSize = new Size(50, 35);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(280, 35);
            txtLogin.TabIndex = 1;
            txtLogin.KeyDown += TabEvent;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSenha.Location = new Point(121, 103);
            txtSenha.Margin = new Padding(2);
            txtSenha.MaximumSize = new Size(300, 300);
            txtSenha.MinimumSize = new Size(0, 35);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(280, 35);
            txtSenha.TabIndex = 2;
            txtSenha.KeyDown += TabEvent;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(146, 7);
            lblLogin.Margin = new Padding(2, 0, 2, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(0, 15);
            lblLogin.TabIndex = 3;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(146, 67);
            lblSenha.Margin = new Padding(2, 0, 2, 0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(0, 15);
            lblSenha.TabIndex = 4;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = SystemColors.ControlDarkDark;
            panelLogin.Controls.Add(txtLogin);
            panelLogin.Controls.Add(btnEntrar);
            panelLogin.Controls.Add(lblSenha);
            panelLogin.Controls.Add(txtSenha);
            panelLogin.Controls.Add(lblLogin);
            panelLogin.Location = new Point(19, 20);
            panelLogin.Margin = new Padding(2);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(522, 239);
            panelLogin.TabIndex = 5;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(560, 270);
            Controls.Add(panelLogin);
            Margin = new Padding(2);
            Name = "FormLogin";
            Text = "Login";
            Load += FormLogin_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEntrar;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label lblLogin;
        private Label lblSenha;
        private Panel panelLogin;
    }
}