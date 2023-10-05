using System.Configuration;
using System.Windows.Forms;

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
            components = new System.ComponentModel.Container();
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
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStripPrincipal = new ContextMenuStrip(components);
            abrirToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            fecharToolStripMenuItem = new ToolStripMenuItem();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            funcionáriosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            ingredientesToolStripMenuItem = new ToolStripMenuItem();
            saboresToolStripMenuItem = new ToolStripMenuItem();
            valoresPizzaToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            panelSup.SuspendLayout();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUser).BeginInit();
            panelInf.SuspendLayout();
            contextMenuStripPrincipal.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
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
            dataGridViewOrders.Location = new Point(211, 63);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.RowTemplate.Height = 25;
            dataGridViewOrders.Size = new Size(805, 493);
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
            pictureUser.Location = new Point(17, 51);
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
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
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
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.MouseDoubleClick += NotifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, sobreToolStripMenuItem, fecharToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 92);
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(180, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += AbrirToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(109, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += SobreToolStripMenuItem_Click;
            // 
            // fecharToolStripMenuItem
            // 
            fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            fecharToolStripMenuItem.Size = new Size(109, 22);
            fecharToolStripMenuItem.Text = "Fechar";
            fecharToolStripMenuItem.Click += FecharToolStripMenuItem_Click;
            // 
            // contextMenuStripPrincipal
            // 
            contextMenuStripPrincipal.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, funcionáriosToolStripMenuItem, clientesToolStripMenuItem, ingredientesToolStripMenuItem, saboresToolStripMenuItem, valoresPizzaToolStripMenuItem, produtosToolStripMenuItem, toolStripSeparator1, configuraçõesToolStripMenuItem, toolStripSeparator2, sairToolStripMenuItem });
            contextMenuStripPrincipal.Name = "contextMenuStrip1";
            contextMenuStripPrincipal.Size = new Size(152, 214);
            contextMenuStripPrincipal.Opening += contextMenuStripPrincipal_Opening;
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(151, 22);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // funcionáriosToolStripMenuItem
            // 
            funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            funcionáriosToolStripMenuItem.Size = new Size(151, 22);
            funcionáriosToolStripMenuItem.Text = "Funcionários";
            funcionáriosToolStripMenuItem.Click += funcionáriosToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(151, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // ingredientesToolStripMenuItem
            // 
            ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            ingredientesToolStripMenuItem.Size = new Size(151, 22);
            ingredientesToolStripMenuItem.Text = "Ingredientes";
            ingredientesToolStripMenuItem.Click += ingredientesToolStripMenuItem_Click;
            // 
            // saboresToolStripMenuItem
            // 
            saboresToolStripMenuItem.Name = "saboresToolStripMenuItem";
            saboresToolStripMenuItem.Size = new Size(151, 22);
            saboresToolStripMenuItem.Text = "Sabores";
            saboresToolStripMenuItem.Click += saboresToolStripMenuItem_Click;
            // 
            // valoresPizzaToolStripMenuItem
            // 
            valoresPizzaToolStripMenuItem.Name = "valoresPizzaToolStripMenuItem";
            valoresPizzaToolStripMenuItem.Size = new Size(151, 22);
            valoresPizzaToolStripMenuItem.Text = "Valores Pizza";
            valoresPizzaToolStripMenuItem.Click += valoresPizzaToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(151, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(148, 6);
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(151, 22);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            configuraçõesToolStripMenuItem.Click += configToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(148, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(151, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;

            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 594);
            ContextMenuStrip = contextMenuStripPrincipal;
            Controls.Add(dataGridViewOrders);
            Controls.Add(panelSup);
            Controls.Add(panelLeft);
            Controls.Add(panelInf);
            Name = "FormPrincipal";
            Text = "Form1";
            FormClosing += FormPrincipal_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            panelSup.ResumeLayout(false);
            panelSup.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUser).EndInit();
            panelInf.ResumeLayout(false);
            contextMenuStripPrincipal.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
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
        private ContextMenuStrip contextMenuStripPrincipal;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem ingredientesToolStripMenuItem;
        private ToolStripMenuItem saboresToolStripMenuItem;
        private ToolStripMenuItem valoresPizzaToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem fecharToolStripMenuItem;
    }

    #endregion
}
