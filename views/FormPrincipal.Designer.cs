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
        
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)getDataGridViewOrders()).BeginInit();
            SuspendLayout();

            /* 
             * FormPrincipal
             */
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 594);
            Controls.Add(getDataGridViewOrders());
            Controls.Add(getPanelSup());
            Controls.Add(getPanelLeft());
            Controls.Add(getPanelInf());
            Name = "FormPrincipal";
            Text = "FormPrincipal";

           
            ((System.ComponentModel.ISupportInitialize)getDataGridViewOrders()).EndInit();
            ResumeLayout(false);
        }

        /**
         * Os métodos abaixo servem para instanciar os 
         * compoentes e garantir que os mesmo só sejam 
         * instanciados uma unica vez 
         **/
        private Panel getPanelLeft()
        {
            if (panelLeft == null)
            {
                panelLeft = new Panel();
                panelLeft.SuspendLayout();
                panelLeft.BackColor = SystemColors.ControlDarkDark;
                panelLeft.Controls.Add(getLabelUserName());
                panelLeft.Controls.Add(getPanelUserImg());
                panelLeft.Controls.Add(getButtonRegisterOrders());
                panelLeft.Controls.Add(getButtonRegisterProducts());
                panelLeft.Controls.Add(getButtonPizzaValues());
                panelLeft.Controls.Add(getButtonRegisterFlavors());
                panelLeft.Controls.Add(getButtonRegisterIngredients());
                panelLeft.Controls.Add(getButtonRegisterClient());
                panelLeft.Controls.Add(getButtonRegisterEmployees());
                panelLeft.Controls.Add(getButtonAdressRegister());
                panelLeft.Location = new Point(0, 0);
                panelLeft.Name = "panelLeft";
                panelLeft.Size = new Size(213, 594);
                panelLeft.TabIndex = 0;
                panelLeft.ResumeLayout(false);
                panelLeft.PerformLayout();
            }
            return panelLeft;
        }

        private Panel getPanelSup()
        {
            if(panelSup == null)
            {
                panelSup = new Panel();
                panelSup.SuspendLayout();
                panelSup.BackColor = SystemColors.ControlDarkDark;
                panelSup.Controls.Add(getButtonSearch());
                panelSup.Controls.Add(getTextBoxSearch());
                panelSup.Location = new Point(211, 0);
                panelSup.Name = "panelSup";
                panelSup.Size = new Size(805, 66);
                panelSup.TabIndex = 1;
                panelSup.ResumeLayout(false);
                panelSup.PerformLayout();

            }
            return panelSup;
        }

        private Panel getPanelUserImg()
        {
            if(panelUserImg == null)
            {
                panelUserImg = new Panel();
                panelUserImg.BackColor = SystemColors.Control;
                panelUserImg.Location = new Point(10, 10);
                panelUserImg.Name = "panelUserImg";
                panelUserImg.Size = new Size(50, 50);
                panelUserImg.TabIndex = 8;
                panelUserImg.Paint += panel3_Paint;
            }
            return panelUserImg;
        }

        private Button getButtonRegisterOrders()
        {
            if(buttonRegisterOrders == null)
            {
                buttonRegisterOrders = new Button();
                buttonRegisterOrders.Location = new Point(12, 492);
                buttonRegisterOrders.Name = "buttonRegisterOrders";
                buttonRegisterOrders.Size = new Size(188, 48);
                buttonRegisterOrders.TabIndex = 7;
                buttonRegisterOrders.Text = "Pedidos";
                buttonRegisterOrders.UseVisualStyleBackColor = true;
            }
            return buttonRegisterOrders;
        }

        private Button getButtonRegisterProducts()
        {
            if(RegisterProducts == null)
            {
                RegisterProducts = new Button();
                RegisterProducts.Location = new Point(12, 438);
                RegisterProducts.Name = "RegisterProducts";
                RegisterProducts.Size = new Size(188, 48);
                RegisterProducts.TabIndex = 6;
                RegisterProducts.Text = "Produtos";
                RegisterProducts.UseVisualStyleBackColor = true;
            }
            return RegisterProducts;
        }

        private Button getButtonPizzaValues()
        {
            if (buttonPizzaValues == null)
            {
                buttonPizzaValues = new Button();
                buttonPizzaValues.Location = new Point(12, 384);
                buttonPizzaValues.Name = "buttonPizzaValues";
                buttonPizzaValues.Size = new Size(188, 48);
                buttonPizzaValues.TabIndex = 5;
                buttonPizzaValues.Text = "Valores Pizza";
                buttonPizzaValues.UseVisualStyleBackColor = true;
            }
            return buttonPizzaValues;
        }

        private Button getButtonRegisterFlavors()
        {
            if(buttonRegisterFlavors == null)
            {
                buttonRegisterFlavors = new Button();
                buttonRegisterFlavors.Location = new Point(12, 330);
                buttonRegisterFlavors.Name = "buttonRegisterFlavors";
                buttonRegisterFlavors.Size = new Size(188, 48);
                buttonRegisterFlavors.TabIndex = 4;
                buttonRegisterFlavors.Text = "Sabores";
                buttonRegisterFlavors.UseVisualStyleBackColor = true;
            }
            return buttonRegisterFlavors;
        }

        private Button getButtonRegisterIngredients()
        {
            if (buttonRegisterIngredients == null)
            {
                buttonRegisterIngredients = new Button();
                buttonRegisterIngredients.Location = new Point(12, 276);
                buttonRegisterIngredients.Name = "buttonRegisterIngredients";
                buttonRegisterIngredients.Size = new Size(188, 48);
                buttonRegisterIngredients.TabIndex = 3;
                buttonRegisterIngredients.Text = "Ingredientes";
                buttonRegisterIngredients.UseVisualStyleBackColor = true;
            }
            return buttonRegisterIngredients;
        }

        private Button getButtonRegisterClient()
        {
            if (buttonRegisterClient == null)
            {
                buttonRegisterClient = new Button();
                buttonRegisterClient.Location = new Point(12, 222);
                buttonRegisterClient.Name = "buttonRegisterClient";
                buttonRegisterClient.Size = new Size(188, 48);
                buttonRegisterClient.TabIndex = 2;
                buttonRegisterClient.Text = "Clientes";
                buttonRegisterClient.UseVisualStyleBackColor = true;
            }
            return buttonRegisterClient;
        }

        private Button getButtonRegisterEmployees()
        {
            if (buttonRegisterEmployees == null)
            {
                buttonRegisterEmployees = new Button();
                buttonRegisterEmployees.Location = new Point(12, 168);
                buttonRegisterEmployees.Name = "buttonRegisterEmployees";
                buttonRegisterEmployees.Size = new Size(188, 48);
                buttonRegisterEmployees.TabIndex = 1;
                buttonRegisterEmployees.Text = "Funcionários";
                buttonRegisterEmployees.UseVisualStyleBackColor = true;
            }
            return buttonRegisterEmployees;
        }

        private Button getButtonAdressRegister()
        {
            if (buttonAdressRegister == null)
            {
                buttonAdressRegister = new Button();
                buttonAdressRegister.Location = new Point(12, 114);
                buttonAdressRegister.Name = "buttonAdressRegister";
                buttonAdressRegister.Size = new Size(188, 48);
                buttonAdressRegister.TabIndex = 0;
                buttonAdressRegister.Text = "Endereço";
                buttonAdressRegister.UseVisualStyleBackColor = true;
            }
            return buttonAdressRegister;
        }
        private Label getLabelUserName()
        {
            if(labelUserName == null)
            {
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
            }
            return labelUserName;
        }

        private Button getButtonSearch()
        {
            if (buttonSearch == null)
            {
                buttonSearch = new Button();
                buttonSearch.Location = new Point(727, 3);
                buttonSearch.Name = "buttonSearch";
                buttonSearch.Size = new Size(75, 41);
                buttonSearch.TabIndex = 1;
                buttonSearch.Text = "Buscar";
                buttonSearch.UseVisualStyleBackColor = true;
            }
            return buttonSearch;
        }

        private TextBox getTextBoxSearch()
        {
            if(textBoxSearch == null)
            {
                textBoxSearch = new TextBox();
                textBoxSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
                textBoxSearch.Location = new Point(396, 5);
                textBoxSearch.Name = "textBoxSearch";
                textBoxSearch.Size = new Size(325, 39);
                textBoxSearch.TabIndex = 0;
            }
            return textBoxSearch;
        }

        private Panel getPanelInf()
        {
            if(panelInf == null)
            {
                panelInf = new Panel();
                panelInf.SuspendLayout();
                panelInf.BackColor = SystemColors.ControlDarkDark;
                panelInf.Controls.Add(getButtonConfirm());
                panelInf.Controls.Add(getButtonPrint());
                panelInf.Location = new Point(211, 556);
                panelInf.Name = "panelInf";
                panelInf.Size = new Size(805, 38);
                panelInf.TabIndex = 2;
                panelInf.ResumeLayout(false);
            }
            return panelInf;
        }

        private Button getButtonConfirm()
        {
            if (buttonConfirm == null)
            {
                buttonConfirm = new Button();
                buttonConfirm.Location = new Point(712, 6);
                buttonConfirm.Name = "buttonConfirm";
                buttonConfirm.Size = new Size(86, 26);
                buttonConfirm.TabIndex = 1;
                buttonConfirm.Text = "Finalizar";
                buttonConfirm.UseVisualStyleBackColor = true;
            }
            return buttonConfirm;
        }

        private Button getButtonPrint()
        {
            if (buttonPrint == null)
            {
                buttonPrint = new Button();
                buttonPrint.Location = new Point(620, 6);
                buttonPrint.Name = "buttonPrint";
                buttonPrint.Size = new Size(86, 26);
                buttonPrint.TabIndex = 0;
                buttonPrint.Text = "Imprimir";
                buttonPrint.UseVisualStyleBackColor = true;
            }
            return buttonPrint;
        }

        private DataGridView getDataGridViewOrders()
        {
            if(dataGridViewOrders == null)
            {
                dataGridViewOrders = new DataGridView();
                dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dataGridViewOrders.Columns.AddRange(new DataGridViewColumn[] { 
                                                            getColumnId(),
                                                            getColumnDescription(),
                                                            getColumnValue() });
                dataGridViewOrders.Location = new Point(211, 66);
                dataGridViewOrders.Name = "dataGridViewOrders";
                dataGridViewOrders.RowTemplate.Height = 25;
                dataGridViewOrders.Size = new Size(805, 490);
                dataGridViewOrders.TabIndex = 3;
            }
            return dataGridViewOrders;
        }

        private DataGridViewTextBoxColumn getColumnId()
        {
            if(ColumnId == null)
            {
                ColumnId = new DataGridViewTextBoxColumn();
                ColumnId.HeaderText = "Código";
                ColumnId.Name = "ColumnId";
                ColumnId.ReadOnly = true;
                ColumnId.Width = 200;
            }
            return ColumnId;
        }

        private DataGridViewTextBoxColumn getColumnDescription()
        {
            if (ColumnDescription == null)
            {
                ColumnDescription = new DataGridViewTextBoxColumn();
                ColumnDescription.HeaderText = "Descrição";
                ColumnDescription.Name = "ColumnDescription";
                ColumnDescription.ReadOnly = true;
                ColumnDescription.Width = 350;
            }
            return ColumnDescription;
        }

        private DataGridViewTextBoxColumn getColumnValue()
        {
            if (ColumnValue == null)
            {
                ColumnValue = new DataGridViewTextBoxColumn();
                ColumnValue.HeaderText = "Valor";
                ColumnValue.Name = "ColumnValue";
                ColumnValue.ReadOnly = true;
                ColumnValue.Width = 200;
            }
            return ColumnValue;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    }

}