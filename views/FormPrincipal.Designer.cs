namespace PizzariaDoZe.views
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelLeft;
        private Panel panelSup;
        private Panel panelUserImg;
        private Button buttonRegisterOrders;
        private Button RegisterProducts;
        private Button buttonPizzaValues;
        private Button buttonRegisterFlavors;
        private Button buttonRegisterIngredients;
        private Button buttonRegisterClient;
        private Button buttonRegisterEmployees;
        private Button buttonAdressRegister;
        private Label labelUserName;
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
            components = new System.ComponentModel.Container();
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 594);
            Text = "Form1";
            // GRID
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnId.HeaderText = "Código";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Width = 200;
            ColumnDescription = new DataGridViewTextBoxColumn();
            ColumnDescription.HeaderText = "Descrição";
            ColumnDescription.Name = "ColumnDescription";
            ColumnDescription.ReadOnly = true;
            ColumnDescription.Width = 350;
            ColumnValue = new DataGridViewTextBoxColumn();
            ColumnValue.HeaderText = "Valor";
            ColumnValue.Name = "ColumnValue";
            ColumnValue.ReadOnly = true;
            ColumnValue.Width = 200;
            dataGridViewOrders = new DataGridView();
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnDescription, ColumnValue });
            dataGridViewOrders.Location = new Point(211, 66);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowTemplate.Height = 25;
            dataGridViewOrders.Size = new Size(805, 490);
            dataGridViewOrders.TabIndex = 3;
            Controls.Add(dataGridViewOrders);
            // PanelSuperior
            buttonSearch = new Button();
            buttonSearch.Location = new Point(727, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 41);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Buscar";
            buttonSearch.UseVisualStyleBackColor = true;
            textBoxSearch = new TextBox();
            textBoxSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(396, 5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(325, 39);
            textBoxSearch.TabIndex = 0;
            panelSup = new Panel();
            panelSup.SuspendLayout();
            panelSup.BackColor = SystemColors.ControlDarkDark;
            panelSup.Controls.Add(buttonSearch);
            panelSup.Controls.Add(textBoxSearch);
            panelSup.Location = new Point(211, 0);
            panelSup.Name = "panelSup";
            panelSup.Size = new Size(805, 66);
            panelSup.TabIndex = 1;
            panelSup.ResumeLayout(false);
            panelSup.PerformLayout();
            Controls.Add(panelSup);
            // PanelLeft
            labelUserName = new Label();
            labelUserName.AutoSize = true;
            labelUserName.BackColor = SystemColors.ControlDarkDark;
            labelUserName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserName.ForeColor = SystemColors.ControlLightLight;
            labelUserName.Location = new Point(95, 15);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(97, 25);
            labelUserName.TabIndex = 9;
            labelUserName.Text = "Username";
            panelUserImg = new Panel();
            panelUserImg.BackColor = SystemColors.Control;
            panelUserImg.Location = new Point(10, 10);
            panelUserImg.Name = "panelUserImg";
            panelUserImg.Size = new Size(50, 50);
            panelUserImg.TabIndex = 8;
            buttonRegisterOrders = new Button();
            buttonRegisterOrders.Location = new Point(12, 492);
            buttonRegisterOrders.Name = "buttonRegisterOrders";
            buttonRegisterOrders.Size = new Size(188, 48);
            buttonRegisterOrders.TabIndex = 7;
            buttonRegisterOrders.Text = "Pedidos";
            buttonRegisterOrders.UseVisualStyleBackColor = true;
            buttonRegisterOrders.Click += ButtonRegisterOrders_Click;

            RegisterProducts = new Button();
            RegisterProducts.Location = new Point(12, 438);
            RegisterProducts.Name = "RegisterProducts";
            RegisterProducts.Size = new Size(188, 48);
            RegisterProducts.TabIndex = 6;
            RegisterProducts.Text = "Produtos";
            RegisterProducts.UseVisualStyleBackColor = true;
            RegisterProducts.Click += RegisterProducts_Click;

            buttonPizzaValues = new Button();
            buttonPizzaValues.Location = new Point(12, 384);
            buttonPizzaValues.Name = "buttonPizzaValues";
            buttonPizzaValues.Size = new Size(188, 48);
            buttonPizzaValues.TabIndex = 5;
            buttonPizzaValues.Text = "Valores Pizza";
            buttonPizzaValues.UseVisualStyleBackColor = true;
            buttonPizzaValues.Click += ButtonPizzaValues_Click;

            buttonRegisterFlavors = new Button();
            buttonRegisterFlavors.Location = new Point(12, 330);
            buttonRegisterFlavors.Name = "buttonRegisterFlavors";
            buttonRegisterFlavors.Size = new Size(188, 48);
            buttonRegisterFlavors.TabIndex = 4;
            buttonRegisterFlavors.Text = "Sabores";
            buttonRegisterFlavors.UseVisualStyleBackColor = true;
            buttonRegisterFlavors.Click += ButtonRegisterFlavors_Click;
            
            buttonRegisterIngredients = new Button();
            buttonRegisterIngredients.Location = new Point(12, 276);
            buttonRegisterIngredients.Name = "buttonRegisterIngredients";
            buttonRegisterIngredients.Size = new Size(188, 48);
            buttonRegisterIngredients.TabIndex = 3;
            buttonRegisterIngredients.Text = "Ingredientes";
            buttonRegisterIngredients.UseVisualStyleBackColor = true;
            buttonRegisterIngredients.Click += ButtonRegisterIngredients_Click;

            buttonRegisterClient = new Button();
            buttonRegisterClient.Location = new Point(12, 222);
            buttonRegisterClient.Name = "buttonRegisterClient";
            buttonRegisterClient.Size = new Size(188, 48);
            buttonRegisterClient.TabIndex = 2;
            buttonRegisterClient.Text = "Clientes";
            buttonRegisterClient.UseVisualStyleBackColor = true;
            buttonRegisterClient.Click += ButtonRegisterClient_Click;

            buttonRegisterEmployees = new Button();
            buttonRegisterEmployees.Location = new Point(12, 168);
            buttonRegisterEmployees.Name = "buttonRegisterEmployees";
            buttonRegisterEmployees.Size = new Size(188, 48);
            buttonRegisterEmployees.TabIndex = 1;
            buttonRegisterEmployees.Text = "Funcionários";
            buttonRegisterEmployees.UseVisualStyleBackColor = true;
            buttonRegisterEmployees.Click += Employees_Click;

            buttonAdressRegister = new Button();
            buttonAdressRegister.Location = new Point(12, 114);
            buttonAdressRegister.Name = "buttonAdressRegister";
            buttonAdressRegister.Size = new Size(188, 48);
            buttonAdressRegister.TabIndex = 0;
            buttonAdressRegister.Text = "Endereço";
            buttonAdressRegister.UseVisualStyleBackColor = true;
            buttonAdressRegister.Click += AdressClick_Click;


            panelLeft = new Panel();
            panelLeft.SuspendLayout();
            panelLeft.BackColor = SystemColors.ControlDarkDark;
            panelLeft.Controls.Add(labelUserName);
            panelLeft.Controls.Add(panelUserImg);
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
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            Controls.Add(panelLeft);
            // PanelBottom
            buttonConfirm = new Button();
            buttonConfirm.Location = new Point(712, 6);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(86, 26);
            buttonConfirm.TabIndex = 1;
            buttonConfirm.Text = "Finalizar";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonPrint = new Button();
            buttonPrint.Location = new Point(620, 6);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(86, 26);
            buttonPrint.TabIndex = 0;
            buttonPrint.Text = "Imprimir";
            buttonPrint.UseVisualStyleBackColor = true;
            panelInf = new Panel();
            panelInf.SuspendLayout();
            panelInf.BackColor = SystemColors.ControlDarkDark;
            panelInf.Controls.Add(buttonConfirm);
            panelInf.Controls.Add(buttonPrint);
            panelInf.Location = new Point(211, 556);
            panelInf.Name = "panelInf";
            panelInf.Size = new Size(805, 38);
            panelInf.TabIndex = 2;
            panelInf.ResumeLayout(false);
            Controls.Add(panelInf);
        }

        private void ButtonRegisterClient_Click(object sender, EventArgs e)
        {
            //FormPedido form = new FormPedido();
            //form.showDialog();
        }

        private void ButtonRegisterOrders_Click(object sender, EventArgs e)
        {
            //FormPedido form = new FormPedido();
            //form.showDialog();
        }

        private void RegisterProducts_Click(object sender, EventArgs e)
        {
            //FormProducts form = new FormProducts();
            //form.showDialog();
        }

        private void ButtonPizzaValues_Click(object sender, EventArgs e)
        {
            //FormPizzaValues form = new FormPizzaValues();
            //form.showDialog();
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

    }

        #endregion
}
