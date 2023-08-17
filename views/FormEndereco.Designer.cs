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
        text_id = new TextBox();
        errorProvider1 = new ErrorProvider(components);
        toolTip1 = new ToolTip(components);
        lbl_id = new Label();
        text_cep = new TextBox();
        lbl_cep = new Label();
        lbl_titulo_endereco = new Label();
        panel_endereco = new Panel();
        lbl_bairro = new Label();
        text_bairro = new TextBox();
        comboBox1 = new ComboBox();
        label1 = new Label();
        lbl_cidade = new Label();
        box_cidade = new ComboBox();
        box_pais = new ComboBox();
        lbl_pais = new Label();
        lbl_logradouro = new Label();
        text_logradouro = new TextBox();
        btn_salvar = new Button();
        btn_edit = new Button();
        btn_deletar = new Button();
        btn_fechar = new Button();
        contextMenuStrip1 = new ContextMenuStrip(components);
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        panel_endereco.SuspendLayout();
        SuspendLayout();
        // 
        // text_id
        // 
        text_id.Location = new Point(28, 66);
        text_id.Name = "text_id";
        text_id.Size = new Size(127, 23);
        text_id.TabIndex = 1;
        toolTip1.SetToolTip(text_id, "Dados Incorretos");
        // 
        // errorProvider1
        // 
        errorProvider1.ContainerControl = this;
        // 
        // toolTip1
        // 
        toolTip1.IsBalloon = true;
        toolTip1.ToolTipIcon = ToolTipIcon.Warning;
        toolTip1.ToolTipTitle = "Goza burrinho";
        // 
        // lbl_id
        // 
        lbl_id.AutoSize = true;
        lbl_id.Location = new Point(28, 44);
        lbl_id.Name = "lbl_id";
        lbl_id.Size = new Size(23, 15);
        lbl_id.TabIndex = 3;
        lbl_id.Text = "ID:";
        // 
        // text_cep
        // 
        text_cep.Location = new Point(214, 66);
        text_cep.Name = "text_cep";
        text_cep.Size = new Size(191, 23);
        text_cep.TabIndex = 4;
        // 
        // lbl_cep
        // 
        lbl_cep.AutoSize = true;
        lbl_cep.Location = new Point(214, 44);
        lbl_cep.Name = "lbl_cep";
        lbl_cep.Size = new Size(30, 15);
        lbl_cep.TabIndex = 5;
        lbl_cep.Text = "CEP:";
        lbl_cep.Click += lbl_cep_Click;
        // 
        // lbl_titulo_endereco
        // 
        lbl_titulo_endereco.AutoSize = true;
        lbl_titulo_endereco.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
        lbl_titulo_endereco.Location = new Point(20, 20);
        lbl_titulo_endereco.Name = "lbl_titulo_endereco";
        lbl_titulo_endereco.Size = new Size(296, 37);
        lbl_titulo_endereco.TabIndex = 6;
        lbl_titulo_endereco.Text = "Cadastro de Endereço";
        // 
        // panel_endereco
        // 
        panel_endereco.BackColor = SystemColors.AppWorkspace;
        panel_endereco.Controls.Add(lbl_bairro);
        panel_endereco.Controls.Add(text_bairro);
        panel_endereco.Controls.Add(comboBox1);
        panel_endereco.Controls.Add(label1);
        panel_endereco.Controls.Add(lbl_cidade);
        panel_endereco.Controls.Add(box_cidade);
        panel_endereco.Controls.Add(box_pais);
        panel_endereco.Controls.Add(lbl_pais);
        panel_endereco.Controls.Add(lbl_logradouro);
        panel_endereco.Controls.Add(text_logradouro);
        panel_endereco.Controls.Add(text_cep);
        panel_endereco.Controls.Add(text_id);
        panel_endereco.Controls.Add(lbl_cep);
        panel_endereco.Controls.Add(lbl_id);
        panel_endereco.Location = new Point(12, 69);
        panel_endereco.Name = "panel_endereco";
        panel_endereco.Size = new Size(776, 273);
        panel_endereco.TabIndex = 7;
        // 
        // lbl_bairro
        // 
        lbl_bairro.AutoSize = true;
        lbl_bairro.Location = new Point(466, 180);
        lbl_bairro.Name = "lbl_bairro";
        lbl_bairro.Size = new Size(44, 15);
        lbl_bairro.TabIndex = 16;
        lbl_bairro.Text = "Bairro:";
        // 
        // text_bairro
        // 
        text_bairro.Location = new Point(466, 207);
        text_bairro.Name = "text_bairro";
        text_bairro.Size = new Size(257, 23);
        text_bairro.TabIndex = 15;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(466, 135);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(257, 23);
        comboBox1.TabIndex = 14;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(466, 103);
        label1.Name = "label1";
        label1.Size = new Size(25, 15);
        label1.TabIndex = 13;
        label1.Text = "UF:";
        // 
        // lbl_cidade
        // 
        lbl_cidade.AutoSize = true;
        lbl_cidade.Location = new Point(31, 189);
        lbl_cidade.Name = "lbl_cidade";
        lbl_cidade.Size = new Size(47, 15);
        lbl_cidade.TabIndex = 12;
        lbl_cidade.Text = "Cidade:";
        // 
        // box_cidade
        // 
        box_cidade.FormattingEnabled = true;
        box_cidade.Location = new Point(31, 207);
        box_cidade.Name = "box_cidade";
        box_cidade.Size = new Size(374, 23);
        box_cidade.TabIndex = 11;
        // 
        // box_pais
        // 
        box_pais.FormattingEnabled = true;
        box_pais.Location = new Point(31, 135);
        box_pais.Name = "box_pais";
        box_pais.Size = new Size(374, 23);
        box_pais.TabIndex = 10;
        box_pais.SelectedIndexChanged += lista_paises_SelectedIndexChanged;
        // 
        // lbl_pais
        // 
        lbl_pais.AutoSize = true;
        lbl_pais.Location = new Point(31, 103);
        lbl_pais.Name = "lbl_pais";
        lbl_pais.Size = new Size(31, 15);
        lbl_pais.TabIndex = 9;
        lbl_pais.Text = "País:";
        // 
        // lbl_logradouro
        // 
        lbl_logradouro.AutoSize = true;
        lbl_logradouro.Location = new Point(466, 44);
        lbl_logradouro.Name = "lbl_logradouro";
        lbl_logradouro.Size = new Size(74, 15);
        lbl_logradouro.TabIndex = 8;
        lbl_logradouro.Text = "Logradouro:";
        // 
        // text_logradouro
        // 
        text_logradouro.Location = new Point(466, 66);
        text_logradouro.Name = "text_logradouro";
        text_logradouro.Size = new Size(257, 23);
        text_logradouro.TabIndex = 6;
        // 
        // btn_salvar
        // 
        btn_salvar.BackColor = Color.Green;
        btn_salvar.ForeColor = Color.White;
        btn_salvar.Image = (Image)resources.GetObject("btn_salvar.Image");
        btn_salvar.ImageAlign = ContentAlignment.MiddleLeft;
        btn_salvar.Location = new Point(12, 356);
        btn_salvar.Name = "btn_salvar";
        btn_salvar.Size = new Size(168, 70);
        btn_salvar.TabIndex = 8;
        btn_salvar.Text = "Salvar";
        btn_salvar.TextAlign = ContentAlignment.MiddleLeft;
        btn_salvar.TextImageRelation = TextImageRelation.ImageBeforeText;
        btn_salvar.UseVisualStyleBackColor = false;
        btn_salvar.Click += btn_salvar_Click;
        // 
        // btn_edit
        // 
        btn_edit.BackColor = Color.FromArgb(0, 0, 192);
        btn_edit.ForeColor = Color.White;
        btn_edit.Image = (Image)resources.GetObject("btn_edit.Image");
        btn_edit.ImageAlign = ContentAlignment.MiddleLeft;
        btn_edit.Location = new Point(216, 356);
        btn_edit.Name = "btn_edit";
        btn_edit.Size = new Size(168, 70);
        btn_edit.TabIndex = 9;
        btn_edit.Text = "Editar";
        btn_edit.TextAlign = ContentAlignment.MiddleLeft;
        btn_edit.TextImageRelation = TextImageRelation.ImageBeforeText;
        btn_edit.UseVisualStyleBackColor = false;
        // 
        // btn_deletar
        // 
        btn_deletar.BackColor = Color.Maroon;
        btn_deletar.ForeColor = Color.White;
        btn_deletar.Image = (Image)resources.GetObject("btn_deletar.Image");
        btn_deletar.ImageAlign = ContentAlignment.MiddleLeft;
        btn_deletar.Location = new Point(416, 356);
        btn_deletar.Name = "btn_deletar";
        btn_deletar.Size = new Size(168, 70);
        btn_deletar.TabIndex = 10;
        btn_deletar.Text = "Deletar";
        btn_deletar.TextAlign = ContentAlignment.MiddleLeft;
        btn_deletar.TextImageRelation = TextImageRelation.ImageBeforeText;
        btn_deletar.UseVisualStyleBackColor = false;
        // 
        // btn_fechar
        // 
        btn_fechar.BackColor = Color.Black;
        btn_fechar.ForeColor = Color.White;
        btn_fechar.Image = (Image)resources.GetObject("btn_fechar.Image");
        btn_fechar.ImageAlign = ContentAlignment.MiddleLeft;
        btn_fechar.Location = new Point(620, 356);
        btn_fechar.Name = "btn_fechar";
        btn_fechar.Size = new Size(168, 70);
        btn_fechar.TabIndex = 11;
        btn_fechar.Text = "Sair";
        btn_fechar.TextAlign = ContentAlignment.MiddleLeft;
        btn_fechar.TextImageRelation = TextImageRelation.ImageBeforeText;
        btn_fechar.UseVisualStyleBackColor = false;
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new Size(61, 4);
        // 
        // form_endereco
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btn_fechar);
        Controls.Add(btn_deletar);
        Controls.Add(btn_edit);
        Controls.Add(btn_salvar);
        Controls.Add(panel_endereco);
        Controls.Add(lbl_titulo_endereco);
        Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "form_endereco";
        Text = "Endereço";
        Load += form_endereco_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
        panel_endereco.ResumeLayout(false);
        panel_endereco.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbl_cidade;
    private TextBox text_id;
    private Button btn_salvar;
    private ErrorProvider errorProvider1;
    private ToolTip toolTip1;
    private Label lbl_id;
    private TextBox text_cep;
    private Label lbl_titulo_endereco;
    private Label lbl_cep;
    private TextBox text_bairro;
    private Panel panel_endereco;
    private Label lbl_logradouro;
    private TextBox text_logradouro;
    private Label lbl_pais;
    private Button btn_deletar;
    private Button btn_edit;
    private Button btn_fechar;
    private ComboBox box_pais;
    private ComboBox box_cidade;
    private Label lbl_bairro;
    private ComboBox comboBox1;
    private Label label1;
    private ContextMenuStrip contextMenuStrip1;
}