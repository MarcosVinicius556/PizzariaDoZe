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
            btnEntrar.BackColor = Color.ForestGreen;
            btnEntrar.Location = new Point(176, 139);
            btnEntrar.Margin = new Padding(2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(156, 43);
            btnEntrar.TabIndex = 0;
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(146, 34);
            txtLogin.Margin = new Padding(2);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(224, 23);
            txtLogin.TabIndex = 1;
            txtLogin.KeyDown += txtLogin_KeyDown;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(146, 92);
            txtSenha.Margin = new Padding(2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(224, 23);
            txtSenha.TabIndex = 2;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(146, 7);
            lblLogin.Margin = new Padding(2, 0, 2, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 15);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "Login:";
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
            panelLogin.Size = new Size(522, 201);
            panelLogin.TabIndex = 5;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(560, 270);
            Controls.Add(panelLogin);
            Margin = new Padding(2);
            Name = "FormLogin";
            Text = "Login";
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