namespace PizzariaDoZe.views
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelLeft;
        private Panel panelSup;
        private Button buttonRegisterOrders;
        private Button RegisterProducts;
        private Button buttonPizzaValues;
        private Button buttonRegisterFlavors;
        private Button buttonRegisterIngredients;
        private Button buttonRegisterClient;
        private Button buttonRegisterEmployees;
        private Button buttonAdressRegister;
        private Label lblUserName;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Panel panelInf;
        private Button buttonConfirm;
        private Button buttonPrint;
        private DataGridView dataGridViewOrders;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnDescription;
        private DataGridViewTextBoxColumn ColumnValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnDescription = new DataGridViewTextBoxColumn();
            ColumnValue = new DataGridViewTextBoxColumn();
            dataGridViewOrders = new DataGridView();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            panelSup = new Panel();
            lblUserName = new Label();
            buttonRegisterOrders = new Button();
            RegisterProducts = new Button();
            buttonPizzaValues = new Button();
            buttonRegisterFlavors = new Button();
            buttonRegisterIngredients = new Button();
            buttonRegisterClient = new Button();
            buttonRegisterEmployees = new Button();
            buttonAdressRegister = new Button();
            panelLeft = new Panel();
            buttonConfirm = new Button();
            buttonPrint = new Button();
            panelInf = new Panel();
            pictureUser = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            panelSup.SuspendLayout();
            panelLeft.SuspendLayout();
            panelInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUser).BeginInit();
            SuspendLayout();
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = Properties.Resources.ResourceManager.GetString("Código");
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Width = 200;
            // 
            // ColumnDescription
            // 
            ColumnDescription.HeaderText = Properties.Resources.ResourceManager.GetString("Descrição");
            ColumnDescription.MinimumWidth = 6;
            ColumnDescription.Name = "ColumnDescription";
            ColumnDescription.ReadOnly = true;
            ColumnDescription.Width = 350;
            // 
            // ColumnValue
            // 
            ColumnValue.HeaderText = Properties.Resources.ResourceManager.GetString("Valor");
            ColumnValue.MinimumWidth = 6;
            ColumnValue.Name = "ColumnValue";
            ColumnValue.ReadOnly = true;
            ColumnValue.Width = 200;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnDescription, ColumnValue });
            dataGridViewOrders.Location = new Point(241, 88);
            dataGridViewOrders.Margin = new Padding(3, 4, 3, 4);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.RowTemplate.Height = 25;
            dataGridViewOrders.Size = new Size(920, 653);
            dataGridViewOrders.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(831, 4);
            buttonSearch.Margin = new Padding(3, 4, 3, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(86, 55);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = Properties.Resources.ResourceManager.GetString("Buscar");
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(453, 7);
            textBoxSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(371, 47);
            textBoxSearch.TabIndex = 0;
            // 
            // panelSup
            // 
            panelSup.BackColor = SystemColors.ControlDarkDark;
            panelSup.Controls.Add(buttonSearch);
            panelSup.Controls.Add(textBoxSearch);
            panelSup.Location = new Point(241, 0);
            panelSup.Margin = new Padding(3, 4, 3, 4);
            panelSup.Name = "panelSup";
            panelSup.Size = new Size(920, 88);
            panelSup.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = SystemColors.ControlDarkDark;
            lblUserName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.ForeColor = SystemColors.ControlLightLight;
            lblUserName.Location = new Point(109, 20);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(121, 32);
            lblUserName.TabIndex = 9;
            lblUserName.Text = Properties.Resources.ResourceManager.GetString("Username");
            // 
            // buttonRegisterOrders
            // 
            buttonRegisterOrders.Location = new Point(14, 656);
            buttonRegisterOrders.Margin = new Padding(3, 4, 3, 4);
            buttonRegisterOrders.Name = "buttonRegisterOrders";
            buttonRegisterOrders.Size = new Size(215, 64);
            buttonRegisterOrders.TabIndex = 7;
            buttonRegisterOrders.Text = "Pedidos";
            buttonRegisterOrders.UseVisualStyleBackColor = true;
            buttonRegisterOrders.Click += ButtonRegisterOrders_Click;
            // 
            // RegisterProducts
            // 
            RegisterProducts.Location = new Point(14, 584);
            RegisterProducts.Margin = new Padding(3, 4, 3, 4);
            RegisterProducts.Name = "RegisterProducts";
            RegisterProducts.Size = new Size(215, 64);
            RegisterProducts.TabIndex = 6;
            RegisterProducts.Text = "Produtos";
            RegisterProducts.UseVisualStyleBackColor = true;
            RegisterProducts.Click += RegisterProducts_Click;
            // 
            // buttonPizzaValues
            // 
            buttonPizzaValues.Location = new Point(14, 512);
            buttonPizzaValues.Margin = new Padding(3, 4, 3, 4);
            buttonPizzaValues.Name = "buttonPizzaValues";
            buttonPizzaValues.Size = new Size(215, 64);
            buttonPizzaValues.TabIndex = 5;
            buttonPizzaValues.Text = "Valores Pizza";
            buttonPizzaValues.UseVisualStyleBackColor = true;
            buttonPizzaValues.Click += ButtonPizzaValues_Click;
            // 
            // buttonRegisterFlavors
            // 
            buttonRegisterFlavors.Location = new Point(14, 440);
            buttonRegisterFlavors.Margin = new Padding(3, 4, 3, 4);
            buttonRegisterFlavors.Name = "buttonRegisterFlavors";
            buttonRegisterFlavors.Size = new Size(215, 64);
            buttonRegisterFlavors.TabIndex = 4;
            buttonRegisterFlavors.Text = "Sabores";
            buttonRegisterFlavors.UseVisualStyleBackColor = true;
            buttonRegisterFlavors.Click += ButtonRegisterFlavors_Click;
            // 
            // buttonRegisterIngredients
            // 
            buttonRegisterIngredients.Location = new Point(14, 368);
            buttonRegisterIngredients.Margin = new Padding(3, 4, 3, 4);
            buttonRegisterIngredients.Name = "buttonRegisterIngredients";
            buttonRegisterIngredients.Size = new Size(215, 64);
            buttonRegisterIngredients.TabIndex = 3;
            buttonRegisterIngredients.Text = "Ingredientes";
            buttonRegisterIngredients.UseVisualStyleBackColor = true;
            buttonRegisterIngredients.Click += ButtonRegisterIngredients_Click;
            // 
            // buttonRegisterClient
            // 
            buttonRegisterClient.Location = new Point(14, 296);
            buttonRegisterClient.Margin = new Padding(3, 4, 3, 4);
            buttonRegisterClient.Name = "buttonRegisterClient";
            buttonRegisterClient.Size = new Size(215, 64);
            buttonRegisterClient.TabIndex = 2;
            buttonRegisterClient.Text = "Clientes";
            buttonRegisterClient.UseVisualStyleBackColor = true;
            buttonRegisterClient.Click += ButtonRegisterClient_Click;
            // 
            // buttonRegisterEmployees
            // 
            buttonRegisterEmployees.Location = new Point(14, 224);
            buttonRegisterEmployees.Margin = new Padding(3, 4, 3, 4);
            buttonRegisterEmployees.Name = "buttonRegisterEmployees";
            buttonRegisterEmployees.Size = new Size(215, 64);
            buttonRegisterEmployees.TabIndex = 1;
            buttonRegisterEmployees.Text = "Funcionários";
            buttonRegisterEmployees.UseVisualStyleBackColor = true;
            buttonRegisterEmployees.Click += Employees_Click;
            // 
            // buttonAdressRegister
            // 
            buttonAdressRegister.Location = new Point(14, 152);
            buttonAdressRegister.Margin = new Padding(3, 4, 3, 4);
            buttonAdressRegister.Name = "buttonAdressRegister";
            buttonAdressRegister.Size = new Size(215, 64);
            buttonAdressRegister.TabIndex = 0;
            buttonAdressRegister.Text = "Endereço";
            buttonAdressRegister.UseVisualStyleBackColor = true;
            buttonAdressRegister.Click += AdressClick_Click;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = SystemColors.ControlDarkDark;
            panelLeft.Controls.Add(pictureUser);
            panelLeft.Controls.Add(lblUserName);
            panelLeft.Controls.Add(buttonRegisterOrders);
            panelLeft.Controls.Add(RegisterProducts);
            panelLeft.Controls.Add(buttonPizzaValues);
            panelLeft.Controls.Add(buttonRegisterFlavors);
            panelLeft.Controls.Add(buttonRegisterIngredients);
            panelLeft.Controls.Add(buttonRegisterClient);
            panelLeft.Controls.Add(buttonRegisterEmployees);
            panelLeft.Controls.Add(buttonAdressRegister);
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(3, 4, 3, 4);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(243, 792);
            panelLeft.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(814, 8);
            buttonConfirm.Margin = new Padding(3, 4, 3, 4);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(98, 35);
            buttonConfirm.TabIndex = 1;
            buttonConfirm.Text = "Finalizar";
            buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonPrint
            // 
            buttonPrint.Location = new Point(709, 8);
            buttonPrint.Margin = new Padding(3, 4, 3, 4);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(98, 35);
            buttonPrint.TabIndex = 0;
            buttonPrint.Text = "Imprimir";
            buttonPrint.UseVisualStyleBackColor = true;
            // 
            // panelInf
            // 
            panelInf.BackColor = SystemColors.ControlDarkDark;
            panelInf.Controls.Add(buttonConfirm);
            panelInf.Controls.Add(buttonPrint);
            panelInf.Location = new Point(241, 741);
            panelInf.Margin = new Padding(3, 4, 3, 4);
            panelInf.Name = "panelInf";
            panelInf.Size = new Size(920, 51);
            panelInf.TabIndex = 2;
            // 
            // pictureUser
            // 
            pictureUser.Image = (Image)resources.GetObject("pictureUser.Image");
            pictureUser.Location = new Point(20, 24);
            pictureUser.Name = "pictureUser";
            pictureUser.Size = new Size(89, 77);
            pictureUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUser.TabIndex = 10;
            pictureUser.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 792);
            Controls.Add(dataGridViewOrders);
            Controls.Add(panelSup);
            Controls.Add(panelLeft);
            Controls.Add(panelInf);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPrincipal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            panelSup.ResumeLayout(false);
            panelSup.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelInf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureUser).EndInit();
            ResumeLayout(false);
        }

        private void ButtonRegisterClient_Click(object sender, EventArgs e)
        {
            FormCadastroCliente form = new FormCadastroCliente();
            form.ShowDialog();
        }

        private void ButtonRegisterOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Função ainda não implementada!");
        }

        private void RegisterProducts_Click(object sender, EventArgs e)
        {
            FormProdutos form = new FormProdutos();
            form.ShowDialog();
        }

        private void ButtonPizzaValues_Click(object sender, EventArgs e)
        {
            FormValores form = new FormValores();
            form.ShowDialog();
        }

        private void ButtonRegisterFlavors_Click(object sender, EventArgs e)
        {
            FormSabores form = new FormSabores();
            form.ShowDialog();
        }

        private void ButtonRegisterIngredients_Click(object sender, EventArgs e)
        {
            FormIngredientes form = new FormIngredientes();
            form.ShowDialog();
        }

        private void AdressClick_Click(object sender, EventArgs e)
        {
            FormEndereco form = new FormEndereco();
            form.ShowDialog();
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            FormFuncionario form = new FormFuncionario();
            form.ShowDialog();
        }

        private PictureBox pictureUser;
    }

    #endregion
}
