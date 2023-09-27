using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.views
{
    public partial class FormConfiguracoes : Form
    {
        public FormConfiguracoes()
        {
            InitializeComponent();


            //seleciona no comboBox o idioma/cultura atual
            comboBoxIdioma.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
        }
        /// <summary>
        ///  Ao ser chamado no click do botão salvar da tela de configurações, 
        ///  altera o arquivo .dll responsável por definir o idioma para a aplicação
        /// </summary>
        private void SalvarIdioma_Click(object sender, EventArgs e)
        {
            //abre o arquivo local como leitura/escrita e salva as alterações em ProjetoPastelariaDoZe_2023.dll.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", comboBoxIdioma.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            //atualiza a cultura corrente
            Program.AjustaIdiomaRegiao();
            Close();
            _ = MessageBox.Show("Idioma/região alterada com sucesso!");
        }

        private void comboBoxIdioma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Impede que o caractere "Enter" seja inserido no TextBox
                e.SuppressKeyPress = true;

                // Simula o pressionamento da tecla "Tab" para mover o foco para o próximo controle
                SendKeys.Send("{Tab}");
            }
        }

        private void SalvarIdioma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Impede que o caractere "Enter" seja inserido no TextBox
                e.SuppressKeyPress = true;



            }
        }
    }
}
