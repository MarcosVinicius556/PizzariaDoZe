using PizzariaDoZe.src.controllers;
using PizzariaDoZe.src.views.enums;
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
        private DataGridView dataGridView;
        private FormPrincipalController controller;

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
            dataGridView = new DataGridView();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            panelSup = new Panel();
            buttonNovoRegistro = new Button();
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
            abrirToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            fecharToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStripPrincipal = new ContextMenuStrip(components);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panelSup.SuspendLayout();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUser).BeginInit();
            panelInf.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            contextMenuStripPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(211, 63);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(805, 493);
            dataGridView.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.ActiveBorder;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Image = (Image)resources.GetObject("buttonSearch.Image");
            buttonSearch.Location = new Point(670, 12);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(52, 39);
            buttonSearch.TabIndex = 1;
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(339, 12);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(325, 39);
            textBoxSearch.TabIndex = 0;
            // 
            // panelSup
            // 
            panelSup.BackColor = SystemColors.ControlDarkDark;
            panelSup.Controls.Add(buttonNovoRegistro);
            panelSup.Controls.Add(buttonSearch);
            panelSup.Controls.Add(textBoxSearch);
            panelSup.Location = new Point(211, 0);
            panelSup.Name = "panelSup";
            panelSup.Size = new Size(805, 66);
            panelSup.TabIndex = 1;
            // 
            // buttonNovoRegistro
            // 
            buttonNovoRegistro.BackColor = SystemColors.ActiveBorder;
            buttonNovoRegistro.FlatAppearance.BorderColor = Color.Black;
            buttonNovoRegistro.FlatStyle = FlatStyle.Flat;
            buttonNovoRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNovoRegistro.ForeColor = SystemColors.ButtonHighlight;
            buttonNovoRegistro.Image = (Image)resources.GetObject("buttonNovoRegistro.Image");
            buttonNovoRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            buttonNovoRegistro.Location = new Point(0, 10);
            buttonNovoRegistro.Name = "buttonNovoRegistro";
            buttonNovoRegistro.Size = new Size(104, 48);
            buttonNovoRegistro.TabIndex = 12;
            buttonNovoRegistro.Text = "Novo";
            buttonNovoRegistro.TextAlign = ContentAlignment.MiddleRight;
            buttonNovoRegistro.UseVisualStyleBackColor = false;
            buttonNovoRegistro.Click += buttonNovoRegistro_Click;
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
            // 
            // buttonRegisterOrders
            // 
            buttonRegisterOrders.BackColor = SystemColors.ActiveBorder;
            buttonRegisterOrders.FlatAppearance.BorderColor = Color.Black;
            buttonRegisterOrders.FlatStyle = FlatStyle.Flat;
            buttonRegisterOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegisterOrders.ForeColor = SystemColors.ButtonHighlight;
            buttonRegisterOrders.Image = (Image)resources.GetObject("buttonRegisterOrders.Image");
            buttonRegisterOrders.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRegisterOrders.Location = new Point(12, 492);
            buttonRegisterOrders.Name = "buttonRegisterOrders";
            buttonRegisterOrders.Size = new Size(188, 48);
            buttonRegisterOrders.TabIndex = 7;
            buttonRegisterOrders.Text = "Pedidos";
            buttonRegisterOrders.UseVisualStyleBackColor = false;
            buttonRegisterOrders.Click += ButtonRegisterOrders_Click;
            // 
            // RegisterProducts
            // 
            RegisterProducts.BackColor = SystemColors.ActiveBorder;
            RegisterProducts.FlatAppearance.BorderColor = Color.Black;
            RegisterProducts.FlatStyle = FlatStyle.Flat;
            RegisterProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterProducts.ForeColor = SystemColors.ButtonHighlight;
            RegisterProducts.Image = (Image)resources.GetObject("RegisterProducts.Image");
            RegisterProducts.ImageAlign = ContentAlignment.MiddleLeft;
            RegisterProducts.Location = new Point(12, 438);
            RegisterProducts.Name = "RegisterProducts";
            RegisterProducts.Size = new Size(188, 48);
            RegisterProducts.TabIndex = 6;
            RegisterProducts.Text = "Produtos";
            RegisterProducts.UseVisualStyleBackColor = false;
            RegisterProducts.Click += RegisterProducts_Click;
            // 
            // buttonPizzaValues
            // 
            buttonPizzaValues.BackColor = SystemColors.ActiveBorder;
            buttonPizzaValues.FlatAppearance.BorderColor = Color.Black;
            buttonPizzaValues.FlatStyle = FlatStyle.Flat;
            buttonPizzaValues.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPizzaValues.ForeColor = SystemColors.ButtonHighlight;
            buttonPizzaValues.Image = (Image)resources.GetObject("buttonPizzaValues.Image");
            buttonPizzaValues.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPizzaValues.Location = new Point(12, 384);
            buttonPizzaValues.Name = "buttonPizzaValues";
            buttonPizzaValues.Size = new Size(188, 48);
            buttonPizzaValues.TabIndex = 5;
            buttonPizzaValues.Text = "Valores";
            buttonPizzaValues.UseVisualStyleBackColor = false;
            buttonPizzaValues.Click += ButtonPizzaValues_Click;
            // 
            // buttonRegisterFlavors
            // 
            buttonRegisterFlavors.BackColor = SystemColors.ActiveBorder;
            buttonRegisterFlavors.FlatAppearance.BorderColor = Color.Black;
            buttonRegisterFlavors.FlatStyle = FlatStyle.Flat;
            buttonRegisterFlavors.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegisterFlavors.ForeColor = SystemColors.ButtonHighlight;
            buttonRegisterFlavors.Image = (Image)resources.GetObject("buttonRegisterFlavors.Image");
            buttonRegisterFlavors.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRegisterFlavors.Location = new Point(12, 330);
            buttonRegisterFlavors.Name = "buttonRegisterFlavors";
            buttonRegisterFlavors.Size = new Size(188, 48);
            buttonRegisterFlavors.TabIndex = 4;
            buttonRegisterFlavors.Text = "Sabores";
            buttonRegisterFlavors.UseVisualStyleBackColor = false;
            buttonRegisterFlavors.Click += ButtonRegisterFlavors_Click;
            // 
            // buttonRegisterIngredients
            // 
            buttonRegisterIngredients.BackColor = SystemColors.ActiveBorder;
            buttonRegisterIngredients.FlatAppearance.BorderColor = Color.Black;
            buttonRegisterIngredients.FlatStyle = FlatStyle.Flat;
            buttonRegisterIngredients.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegisterIngredients.ForeColor = SystemColors.ButtonHighlight;
            buttonRegisterIngredients.Image = (Image)resources.GetObject("buttonRegisterIngredients.Image");
            buttonRegisterIngredients.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRegisterIngredients.Location = new Point(12, 276);
            buttonRegisterIngredients.Name = "buttonRegisterIngredients";
            buttonRegisterIngredients.Size = new Size(188, 48);
            buttonRegisterIngredients.TabIndex = 3;
            buttonRegisterIngredients.Text = "Ingredientes";
            buttonRegisterIngredients.UseVisualStyleBackColor = false;
            buttonRegisterIngredients.Click += ButtonRegisterIngredients_Click;
            // 
            // buttonRegisterClient
            // 
            buttonRegisterClient.BackColor = SystemColors.ActiveBorder;
            buttonRegisterClient.FlatAppearance.BorderColor = Color.Black;
            buttonRegisterClient.FlatStyle = FlatStyle.Flat;
            buttonRegisterClient.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegisterClient.ForeColor = SystemColors.ButtonHighlight;
            buttonRegisterClient.Image = (Image)resources.GetObject("buttonRegisterClient.Image");
            buttonRegisterClient.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRegisterClient.Location = new Point(12, 222);
            buttonRegisterClient.Name = "buttonRegisterClient";
            buttonRegisterClient.Size = new Size(188, 48);
            buttonRegisterClient.TabIndex = 2;
            buttonRegisterClient.Text = "Clientes";
            buttonRegisterClient.UseVisualStyleBackColor = false;
            buttonRegisterClient.Click += ButtonRegisterClient_Click;
            // 
            // buttonRegisterEmployees
            // 
            buttonRegisterEmployees.BackColor = SystemColors.ActiveBorder;
            buttonRegisterEmployees.FlatAppearance.BorderColor = Color.Black;
            buttonRegisterEmployees.FlatStyle = FlatStyle.Flat;
            buttonRegisterEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegisterEmployees.ForeColor = SystemColors.ButtonHighlight;
            buttonRegisterEmployees.Image = (Image)resources.GetObject("buttonRegisterEmployees.Image");
            buttonRegisterEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRegisterEmployees.Location = new Point(12, 168);
            buttonRegisterEmployees.Name = "buttonRegisterEmployees";
            buttonRegisterEmployees.Size = new Size(188, 48);
            buttonRegisterEmployees.TabIndex = 1;
            buttonRegisterEmployees.Text = "Funcionários";
            buttonRegisterEmployees.UseVisualStyleBackColor = false;
            buttonRegisterEmployees.Click += Employees_Click;
            // 
            // buttonAdressRegister
            // 
            buttonAdressRegister.BackColor = SystemColors.ActiveBorder;
            buttonAdressRegister.FlatAppearance.BorderColor = Color.Black;
            buttonAdressRegister.FlatStyle = FlatStyle.Flat;
            buttonAdressRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdressRegister.ForeColor = SystemColors.ButtonHighlight;
            buttonAdressRegister.Image = (Image)resources.GetObject("buttonAdressRegister.Image");
            buttonAdressRegister.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdressRegister.Location = new Point(12, 114);
            buttonAdressRegister.Name = "buttonAdressRegister";
            buttonAdressRegister.Size = new Size(188, 48);
            buttonAdressRegister.TabIndex = 0;
            buttonAdressRegister.Text = "Endereço";
            buttonAdressRegister.UseVisualStyleBackColor = false;
            buttonAdressRegister.Click += AdressClick_Click;
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
            buttonOptions.BackColor = SystemColors.ActiveBorder;
            buttonOptions.FlatAppearance.BorderColor = Color.Black;
            buttonOptions.FlatStyle = FlatStyle.Flat;
            buttonOptions.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOptions.ForeColor = SystemColors.ButtonHighlight;
            buttonOptions.Image = (Image)resources.GetObject("buttonOptions.Image");
            buttonOptions.ImageAlign = ContentAlignment.MiddleLeft;
            buttonOptions.Location = new Point(12, 546);
            buttonOptions.Name = "buttonOptions";
            buttonOptions.Size = new Size(188, 39);
            buttonOptions.TabIndex = 11;
            buttonOptions.Text = "Configurações";
            buttonOptions.UseVisualStyleBackColor = false;
            buttonOptions.Click += buttonOptions_Click;
            // 
            // pictureUser
            // 
            pictureUser.BackColor = SystemColors.ActiveBorder;
            pictureUser.Image = (Image)resources.GetObject("pictureUser.Image");
            pictureUser.Location = new Point(12, 15);
            pictureUser.Margin = new Padding(3, 2, 3, 2);
            pictureUser.Name = "pictureUser";
            pictureUser.Size = new Size(188, 94);
            pictureUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUser.TabIndex = 10;
            pictureUser.TabStop = false;
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = SystemColors.ActiveBorder;
            buttonConfirm.FlatAppearance.BorderColor = Color.Black;
            buttonConfirm.FlatStyle = FlatStyle.Flat;
            buttonConfirm.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConfirm.ForeColor = SystemColors.ButtonFace;
            buttonConfirm.Image = (Image)resources.GetObject("buttonConfirm.Image");
            buttonConfirm.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConfirm.Location = new Point(685, 1);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(113, 35);
            buttonConfirm.TabIndex = 1;
            buttonConfirm.Text = "Confirmar";
            buttonConfirm.TextAlign = ContentAlignment.MiddleRight;
            buttonConfirm.UseVisualStyleBackColor = false;
            // 
            // buttonPrint
            // 
            buttonPrint.BackColor = SystemColors.ActiveBorder;
            buttonPrint.FlatAppearance.BorderColor = Color.Black;
            buttonPrint.FlatStyle = FlatStyle.Flat;
            buttonPrint.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrint.ForeColor = SystemColors.ButtonFace;
            buttonPrint.Image = (Image)resources.GetObject("buttonPrint.Image");
            buttonPrint.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPrint.Location = new Point(564, 1);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(104, 35);
            buttonPrint.TabIndex = 0;
            buttonPrint.Text = "Imprimir";
            buttonPrint.TextAlign = ContentAlignment.MiddleRight;
            buttonPrint.UseVisualStyleBackColor = false;
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
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.MouseDoubleClick += NotifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, sobreToolStripMenuItem, fecharToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(110, 70);
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(109, 22);
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
            Controls.Add(dataGridView);
            Controls.Add(panelSup);
            Controls.Add(panelLeft);
            Controls.Add(panelInf);
            Name = "FormPrincipal";
            Text = "Pizzaria do Zé App";
            FormClosing += FormPrincipal_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panelSup.ResumeLayout(false);
            panelSup.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUser).EndInit();
            panelInf.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStripPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void ButtonRegisterClient_Click(object sender, EventArgs e)
        {
            /* FormCadastroCliente form = new FormCadastroCliente();
            form.ShowDialog();
            */
            dataGridView.DataSource = controller.BuscarClientes();
            formSelected = FormSelected.CLIENTE;
        }

        private void ButtonRegisterOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Função ainda não implementada!");
            formSelected = FormSelected.PEDIDO;
        }

        private void RegisterProducts_Click(object sender, EventArgs e)
        {
            /* FormProdutos form = new FormProdutos();
            form.ShowDialog();
            */
            dataGridView.DataSource = controller.BuscarProdutos();
            formSelected = FormSelected.PRODUTO;
        }

        private void ButtonPizzaValues_Click(object sender, EventArgs e)
        {
            /*FormValores form = new FormValores();
            form.ShowDialog(); */
            dataGridView.DataSource = controller.BuscarValores();
            formSelected = FormSelected.VALOR;
        }

        private void ButtonRegisterFlavors_Click(object sender, EventArgs e)
        {
            /*FormSabores form = new FormSabores();
            form.ShowDialog();*/
            dataGridView.DataSource = controller.BuscarSabores();
            formSelected = FormSelected.SABOR;
        }

        private void ButtonRegisterIngredients_Click(object sender, EventArgs e)
        {
            /*FormIngredientes form = new FormIngredientes();
            form.ShowDialog();*/
            dataGridView.DataSource = controller.BuscarIngredientes();
            formSelected = FormSelected.INGREDIENTE;
        }

        private void AdressClick_Click(object sender, EventArgs e)
        {
            /*FormEndereco form = new FormEndereco();
            form.ShowDialog();*/
            dataGridView.DataSource = controller.BuscarEnderecos();
            formSelected = FormSelected.ENDERECO;
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            /*FormFuncionario form = new FormFuncionario();
            form.ShowDialog();*/
            dataGridView.DataSource = controller.BuscarFuncionarios();
            formSelected = FormSelected.FUNCIONARIO;
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
        private Button buttonNovoRegistro;
    }

    #endregion
}
