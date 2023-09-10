namespace PizzariaDoZe.views
{
    partial class FormConfiguracoes
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
            label1 = new Label();
            comboBoxIdioma = new ComboBox();
            SalvarIdioma = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(68, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 0;
            label1.Text = "Seleção de idioma";
            // 
            // comboBoxIdioma
            // 
            comboBoxIdioma.FormattingEnabled = true;
            comboBoxIdioma.ImeMode = ImeMode.Katakana;
            comboBoxIdioma.Items.AddRange(new object[] { "en-US", "es", "pt-BR" });
            comboBoxIdioma.Location = new Point(12, 50);
            comboBoxIdioma.Name = "comboBoxIdioma";
            comboBoxIdioma.Size = new Size(278, 23);
            comboBoxIdioma.TabIndex = 1;
            // 
            // SalvarIdioma
            // 
            SalvarIdioma.Location = new Point(12, 102);
            SalvarIdioma.Name = "SalvarIdioma";
            SalvarIdioma.Size = new Size(75, 23);
            SalvarIdioma.TabIndex = 2;
            SalvarIdioma.Text = "Salvar Idioma";
            SalvarIdioma.UseVisualStyleBackColor = true;
            SalvarIdioma.Click += SalvarIdioma_Click;
            // 
            // FormConfiguracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 137);
            Controls.Add(SalvarIdioma);
            Controls.Add(comboBoxIdioma);
            Controls.Add(label1);
            Name = "FormConfiguracoes";
            Text = "FormConfiguracoes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxIdioma;
        private Button SalvarIdioma;
    }
}