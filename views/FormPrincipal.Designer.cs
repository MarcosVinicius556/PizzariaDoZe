using System.Configuration;

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
            buttonOptions = new Button();
            pictureUser = new PictureBox();
            buttonConfirm = new Button();
            buttonPrint = new Button();
            panelInf = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            panelSup.SuspendLayout();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUser).BeginInit();
            panelInf.SuspendLayout();
            SuspendLayout();
            // 
            // ColumnId
            // 
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Width = 200;
            ColumnId.Tag = Properties.Resources.ResourceManager.GetString("Id");
            // 
            // ColumnDescription
            // 
            ColumnDescription.MinimumWidth = 6;
            ColumnDescription.Name = "ColumnDescription";
            ColumnDescription.ReadOnly = true;
            ColumnDescription.Width = 350;
            ColumnDescription.Tag = Properties.Resources.ResourceManager.GetString("Descrição");
            // 
            // ColumnValue
            // 
            ColumnValue.MinimumWidth = 6;
            ColumnValue.Name = "ColumnValue";
            ColumnValue.ReadOnly = true;
            ColumnValue.Width = 200;
            ColumnValue.Tag = Properties.Resources.ResourceManager.GetString("Preço");
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnDescription, ColumnValue });
            dataGridViewOrders.Location = new Point(211, 66);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.RowTemplate.Height = 25;
            dataGridViewOrders.Size = new Size(805, 490);
            dataGridViewOrders.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(727, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 41);
            buttonSearch.TabIndex = 1;
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Text = Properties.Resources.ResourceManager.GetString("Buscar");
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(396, 5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(325, 39);
            textBoxSearch.TabIndex = 0;
            // 
            // panelSup
            // 
            panelSup.BackColor = SystemColors.ControlDarkDark;
            panelSup.Controls.Add(buttonSearch);
            panelSup.Controls.Add(textBoxSearch);
            panelSup.Location = new Point(211, 0);
            panelSup.Name = "panelSup";
            panelSup.Size = new Size(805, 66);
            panelSup.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = SystemColors.ControlDarkDark;
            lblUserName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.ForeColor = SystemColors.ControlLightLight;
            lblUserName.Location = new Point(95, 15);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(0, 25);
            lblUserName.TabIndex = 9;
            lblUserName.Text = Properties.Resources.ResourceManager.GetString("Username");
            // 
            // buttonRegisterOrders
            // 
            buttonRegisterOrders.Location = new Point(12, 492);
            buttonRegisterOrders.Name = "buttonRegisterOrders";
            buttonRegisterOrders.Size = new Size(188, 48);
            buttonRegisterOrders.TabIndex = 7;
            buttonRegisterOrders.UseVisualStyleBackColor = true;
            buttonRegisterOrders.Click += ButtonRegisterOrders_Click;
            buttonRegisterOrders.Text = Properties.Resources.ResourceManager.GetString("Pedidos");
            // 
            // RegisterProducts
            // 
            RegisterProducts.Location = new Point(12, 438);
            RegisterProducts.Name = "RegisterProducts";
            RegisterProducts.Size = new Size(188, 48);
            RegisterProducts.TabIndex = 6;
            RegisterProducts.UseVisualStyleBackColor = true;
            RegisterProducts.Click += RegisterProducts_Click;
            RegisterProducts.Text = Properties.Resources.ResourceManager.GetString("Produtos");
            // 
            // buttonPizzaValues
            // 
            buttonPizzaValues.Location = new Point(12, 384);
            buttonPizzaValues.Name = "buttonPizzaValues";
            buttonPizzaValues.Size = new Size(188, 48);
            buttonPizzaValues.TabIndex = 5;
            buttonPizzaValues.UseVisualStyleBackColor = true;
            buttonPizzaValues.Click += ButtonPizzaValues_Click;
            buttonPizzaValues.Text = Properties.Resources.ResourceManager.GetString("Valores Pizza");
            // 
            // buttonRegisterFlavors
            // 
            buttonRegisterFlavors.Location = new Point(12, 330);
            buttonRegisterFlavors.Name = "buttonRegisterFlavors";
            buttonRegisterFlavors.Size = new Size(188, 48);
            buttonRegisterFlavors.TabIndex = 4;
            buttonRegisterFlavors.UseVisualStyleBackColor = true;
            buttonRegisterFlavors.Click += ButtonRegisterFlavors_Click;
            buttonRegisterFlavors.Text = Properties.Resources.ResourceManager.GetString("Sabores");
            // 
            // buttonRegisterIngredients
            // 
            buttonRegisterIngredients.Location = new Point(12, 276);
            buttonRegisterIngredients.Name = "buttonRegisterIngredients";
            buttonRegisterIngredients.Size = new Size(188, 48);
            buttonRegisterIngredients.TabIndex = 3;
            buttonRegisterIngredients.UseVisualStyleBackColor = true;
            buttonRegisterIngredients.Click += ButtonRegisterIngredients_Click;
            buttonRegisterIngredients.Text = Properties.Resources.ResourceManager.GetString("Ingredientes");
            // 
            // buttonRegisterClient
            // 
            buttonRegisterClient.Location = new Point(12, 222);
            buttonRegisterClient.Name = "buttonRegisterClient";
            buttonRegisterClient.Size = new Size(188, 48);
            buttonRegisterClient.TabIndex = 2;
            buttonRegisterClient.UseVisualStyleBackColor = true;
            buttonRegisterClient.Click += ButtonRegisterClient_Click;
            buttonRegisterClient.Text = Properties.Resources.ResourceManager.GetString("Cadastro Cliente");
            // 
            // buttonRegisterEmployees
            // 
            buttonRegisterEmployees.Location = new Point(12, 168);
            buttonRegisterEmployees.Name = "buttonRegisterEmployees";
            buttonRegisterEmployees.Size = new Size(188, 48);
            buttonRegisterEmployees.TabIndex = 1;
            buttonRegisterEmployees.UseVisualStyleBackColor = true;
            buttonRegisterEmployees.Click += Employees_Click;
            buttonRegisterEmployees.Text = Properties.Resources.ResourceManager.GetString("Funcionários");
            // 
            // buttonAdressRegister
            // 
            buttonAdressRegister.Location = new Point(12, 114);
            buttonAdressRegister.Name = "buttonAdressRegister";
            buttonAdressRegister.Size = new Size(188, 48);
            buttonAdressRegister.TabIndex = 0;
            buttonAdressRegister.UseVisualStyleBackColor = true;
            buttonAdressRegister.Click += AdressClick_Click;
            buttonAdressRegister.Text = Properties.Resources.ResourceManager.GetString("Cadastro de Endereço");
            // 
            // panelLeft
            // 
            panelLeft.BackColor = SystemColors.ControlDarkDark;
            panelLeft.Controls.Add(buttonOptions);
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
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(213, 594);
            panelLeft.TabIndex = 0;
            // 
            // buttonOptions
            // 
            buttonOptions.Location = new Point(12, 546);
            buttonOptions.Name = "buttonOptions";
            buttonOptions.Size = new Size(96, 39);
            buttonOptions.TabIndex = 11;
            buttonOptions.UseVisualStyleBackColor = true;
            buttonOptions.Click += buttonOptions_Click;
            buttonOptions.Text = Properties.Resources.ResourceManager.GetString("Opções");
            // 
            // pictureUser
            // 
            pictureUser.Image = (Image)resources.GetObject("pictureUser.Image");
            pictureUser.Location = new Point(18, 18);
            pictureUser.Margin = new Padding(3, 2, 3, 2);
            pictureUser.Name = "pictureUser";
            pictureUser.Size = new Size(78, 58);
            pictureUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUser.TabIndex = 10;
            pictureUser.TabStop = false;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(712, 6);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(86, 26);
            buttonConfirm.TabIndex = 1;
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Text = "Confirm";
            // 
            // buttonPrint
            // 
            buttonPrint.Location = new Point(620, 6);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(86, 26);
            buttonPrint.TabIndex = 0;
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Text = Properties.Resources.ResourceManager.GetString("Imprimir");
            // 
            // panelInf
            // 
            panelInf.BackColor = SystemColors.ControlDarkDark;
            panelInf.Controls.Add(buttonConfirm);
            panelInf.Controls.Add(buttonPrint);
            panelInf.Location = new Point(211, 556);
            panelInf.Name = "panelInf";
            panelInf.Size = new Size(805, 38);
            panelInf.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 594);
            Controls.Add(dataGridViewOrders);
            Controls.Add(panelSup);
            Controls.Add(panelLeft);
            Controls.Add(panelInf);
            Name = "FormPrincipal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            panelSup.ResumeLayout(false);
            panelSup.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUser).EndInit();
            panelInf.ResumeLayout(false);
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
        private Button buttonOptions;
    }

    #endregion
}
