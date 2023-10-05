namespace PizzariaDoZe.views;

partial class FormEndereco
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEndereco));
        txtId = new TextBox();
        errorProvider1 = new ErrorProvider(components);
        toolTip1 = new ToolTip(components);
        lblId = new Label();
        txtCep = new TextBox();
        lblCep = new Label();
        lblTituloEndereco = new Label();
        panelEndereco = new Panel();
        lblBairro = new Label();
        txtBairro = new TextBox();
        dropBoxUf = new ComboBox();
        lblUf = new Label();
        lblCidade = new Label();
        dropBoxCidade = new ComboBox();
        dropBoxPais = new ComboBox();
        lblPais = new Label();
        lblLogradouro = new Label();
        txtLogradouro = new TextBox();
        btnSalvar = new Button();
        btnEditar = new Button();
        btnDeletar = new Button();
        btnFechar = new Button();
        contextMenuStrip1 = new ContextMenuStrip(components);
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        panelEndereco.SuspendLayout();
        SuspendLayout();
        // 
        // txtId
        // 
        txtId.Location = new Point(28, 66);
        txtId.Name = "txtId";
        txtId.Size = new Size(127, 27);
        txtId.TabIndex = 1;
        txtId.KeyDown += TabEvent;
        toolTip1.SetToolTip(txtId, "Dados Incorretos");
        // 
        // errorProvider1
        // 
        errorProvider1.ContainerControl = this;
        // 
        // lblId
        // 
        lblId.AutoSize = true;
        lblId.Location = new Point(28, 44);
        lblId.Name = "lblId";
        lblId.Size = new Size(29, 20);
        lblId.TabIndex = 3;
        lblId.Text = "ID:";
        // 
        // txtCep
        // 
        txtCep.Location = new Point(214, 66);
        txtCep.Name = "txtCep";
        txtCep.Size = new Size(191, 27);
        txtCep.TabIndex = 4;
        txtCep.KeyDown += TabEvent;
        // 
        // lblCep
        // 
        lblCep.AutoSize = true;
        lblCep.Location = new Point(214, 44);
        lblCep.Name = "lblCep";
        lblCep.Size = new Size(39, 20);
        lblCep.TabIndex = 5;
        lblCep.Text = Properties.Resources.ResourceManager.GetString("CEP");
        lblCep.Click += lbl_cep_Click;
        // 
        // lblTituloEndereco
        // 
        lblTituloEndereco.AutoSize = true;
        lblTituloEndereco.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
        lblTituloEndereco.Location = new Point(20, 20);
        lblTituloEndereco.Name = "lblTituloEndereco";
        lblTituloEndereco.Size = new Size(365, 46);
        lblTituloEndereco.TabIndex = 6;
        lblTituloEndereco.Text = Properties.Resources.ResourceManager.GetString("Cadastro de Endereço");
        // 
        // panelEndereco
        // 
        panelEndereco.BackColor = SystemColors.AppWorkspace;
        panelEndereco.Controls.Add(lblBairro);
        panelEndereco.Controls.Add(txtBairro);
        panelEndereco.Controls.Add(dropBoxUf);
        panelEndereco.Controls.Add(lblUf);
        panelEndereco.Controls.Add(lblCidade);
        panelEndereco.Controls.Add(dropBoxCidade);
        panelEndereco.Controls.Add(dropBoxPais);
        panelEndereco.Controls.Add(lblPais);
        panelEndereco.Controls.Add(lblLogradouro);
        panelEndereco.Controls.Add(txtLogradouro);
        panelEndereco.Controls.Add(txtCep);
        panelEndereco.Controls.Add(txtId);
        panelEndereco.Controls.Add(lblCep);
        panelEndereco.Controls.Add(lblId);
        panelEndereco.Location = new Point(12, 69);
        panelEndereco.Name = "panelEndereco";
        panelEndereco.Size = new Size(776, 273);
        panelEndereco.TabIndex = 7;
        // 
        // lblBairro
        // 
        lblBairro.AutoSize = true;
        lblBairro.Location = new Point(466, 180);
        lblBairro.Name = "lblBairro";
        lblBairro.Size = new Size(56, 20);
        lblBairro.TabIndex = 16;
        lblBairro.Text = Properties.Resources.ResourceManager.GetString("Bairro");
        // 
        // txtBairro
        // 
        txtBairro.Location = new Point(466, 207);
        txtBairro.Name = "txtBairro";
        txtBairro.Size = new Size(257, 27);
        txtBairro.TabIndex = 15;
        txtBairro.KeyDown += TabEvent;
        // 
        // dropBoxUf
        // 
        dropBoxUf.FormattingEnabled = true;
        dropBoxUf.Location = new Point(466, 135);
        dropBoxUf.Name = "dropBoxUf";
        dropBoxUf.Size = new Size(257, 28);
        dropBoxUf.TabIndex = 14;
        dropBoxUf.KeyDown += TabEvent;
        // 
        // lblUf
        // 
        lblUf.AutoSize = true;
        lblUf.Location = new Point(466, 103);
        lblUf.Name = "lblUf";
        lblUf.Size = new Size(32, 20);
        lblUf.TabIndex = 13;
        lblUf.Text = Properties.Resources.ResourceManager.GetString("UF");
        // 
        // lblCidade
        // 
        lblCidade.AutoSize = true;
        lblCidade.Location = new Point(31, 189);
        lblCidade.Name = "lblCidade";
        lblCidade.Size = new Size(60, 20);
        lblCidade.TabIndex = 12;
        lblCidade.Text = Properties.Resources.ResourceManager.GetString("Cidade");
        // 
        // dropBoxCidade
        // 
        dropBoxCidade.FormattingEnabled = true;
        dropBoxCidade.Location = new Point(31, 207);
        dropBoxCidade.Name = "dropBoxCidade";
        dropBoxCidade.Size = new Size(374, 28);
        dropBoxCidade.TabIndex = 11;
        dropBoxCidade.KeyDown += TabEvent;
        // 
        // dropBoxPais
        // 
        dropBoxPais.FormattingEnabled = true;
        dropBoxPais.Location = new Point(31, 135);
        dropBoxPais.Name = "dropBoxPais";
        dropBoxPais.Size = new Size(374, 28);
        dropBoxPais.TabIndex = 10;
        dropBoxPais.SelectedIndexChanged += lista_paises_SelectedIndexChanged;
        dropBoxPais.KeyDown += TabEvent;
        // 
        // lblPais
        // 
        lblPais.AutoSize = true;
        lblPais.Location = new Point(31, 103);
        lblPais.Name = "lblPais";
        lblPais.Size = new Size(41, 20);
        lblPais.TabIndex = 9;
        lblPais.Text = Properties.Resources.ResourceManager.GetString("Pais");
        // 
        // lblLogradouro
        // 
        lblLogradouro.AutoSize = true;
        lblLogradouro.Location = new Point(466, 44);
        lblLogradouro.Name = "lblLogradouro";
        lblLogradouro.Size = new Size(95, 20);
        lblLogradouro.TabIndex = 8;
        lblLogradouro.Text = Properties.Resources.ResourceManager.GetString("Logradouro");
        // 
        // txtLogradouro
        // 
        txtLogradouro.Location = new Point(466, 66);
        txtLogradouro.Name = "txtLogradouro";
        txtLogradouro.Size = new Size(257, 27);
        txtLogradouro.TabIndex = 6;
        txtLogradouro.KeyDown += TabEvent;
        // 
        // btnSalvar
        // 
        btnSalvar.BackColor = Color.Green;
        btnSalvar.ForeColor = Color.White;
        btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
        btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
        btnSalvar.Location = new Point(12, 356);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(168, 70);
        btnSalvar.TabIndex = 8;
        btnSalvar.Text = Properties.Resources.ResourceManager.GetString("Salvar");
        btnSalvar.TextAlign = ContentAlignment.MiddleLeft;
        btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnSalvar.UseVisualStyleBackColor = false;
        btnSalvar.Click += btn_salvar_Click;
        // 
        // btnEditar
        // 
        btnEditar.BackColor = Color.FromArgb(0, 0, 192);
        btnEditar.ForeColor = Color.White;
        btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
        btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
        btnEditar.Location = new Point(216, 356);
        btnEditar.Name = "btnEditar";
        btnEditar.Size = new Size(168, 70);
        btnEditar.TabIndex = 9;
        btnEditar.Text = Properties.Resources.ResourceManager.GetString("Editar");
        btnEditar.TextAlign = ContentAlignment.MiddleLeft;
        btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnEditar.UseVisualStyleBackColor = false;
        // 
        // btnDeletar
        // 
        btnDeletar.BackColor = Color.Maroon;
        btnDeletar.ForeColor = Color.White;
        btnDeletar.Image = (Image)resources.GetObject("btnDeletar.Image");
        btnDeletar.ImageAlign = ContentAlignment.MiddleLeft;
        btnDeletar.Location = new Point(416, 356);
        btnDeletar.Name = "btnDeletar";
        btnDeletar.Size = new Size(168, 70);
        btnDeletar.TabIndex = 10;
        btnDeletar.Text = Properties.Resources.ResourceManager.GetString("Excluir");
        btnDeletar.TextAlign = ContentAlignment.MiddleLeft;
        btnDeletar.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnDeletar.UseVisualStyleBackColor = false;
        // 
        // btnFechar
        // 
        btnFechar.BackColor = Color.Black;
        btnFechar.ForeColor = Color.White;
        btnFechar.Image = (Image)resources.GetObject("btnFechar.Image");
        btnFechar.ImageAlign = ContentAlignment.MiddleLeft;
        btnFechar.Location = new Point(620, 356);
        btnFechar.Name = "btnFechar";
        btnFechar.Size = new Size(168, 70);
        btnFechar.TabIndex = 11;
        btnFechar.Text = Properties.Resources.ResourceManager.GetString("Fechar");
        btnFechar.TextAlign = ContentAlignment.MiddleLeft;
        btnFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnFechar.UseVisualStyleBackColor = false;
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.ImageScalingSize = new Size(20, 20);
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new Size(61, 4);
        // 
        // FormEndereco
        // 
        AutoScaleDimensions = new SizeF(9F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnFechar);
        Controls.Add(btnDeletar);
        Controls.Add(btnEditar);
        Controls.Add(btnSalvar);
        Controls.Add(panelEndereco);
        Controls.Add(lblTituloEndereco);
        Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "FormEndereco";
        Text = Properties.Resources.ResourceManager.GetString("Endereço");
        Load += form_endereco_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
        panelEndereco.ResumeLayout(false);
        panelEndereco.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblCidade;
    private TextBox txtId;
    private Button btnSalvar;
    private ErrorProvider errorProvider1;
    private ToolTip toolTip1;
    private Label lblId;
    private TextBox txtCep;
    private Label lblTituloEndereco;
    private Label lblCep;
    private TextBox txtBairro;
    private Panel panelEndereco;
    private Label lblLogradouro;
    private TextBox txtLogradouro;
    private Label lblPais;
    private Button btnDeletar;
    private Button btnEditar;
    private Button btnFechar;
    private ComboBox dropBoxPais;
    private ComboBox dropBoxCidade;
    private Label lblBairro;
    private ComboBox dropBoxUf;
    private Label lblUf;
    private ContextMenuStrip contextMenuStrip1;
}