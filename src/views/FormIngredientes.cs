using PizzariaDoZe.src.controllers;
using PizzariaDoZe.src.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PizzariaDoZe.views;

public partial class FormIngredientes : Form
{
    private FormIngredientesController controller = new FormIngredientesController();
    public FormIngredientes()
    {
        InitializeComponent();
    }

    private void TabEvent(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            // Impede que o caractere "Enter" seja inserido no TextBox
            e.SuppressKeyPress = true;

            // Simula o pressionamento da tecla "Tab" para mover o foco para o pr�ximo controle
            SendKeys.Send("{Tab}");
        }
    }

    /* Outros métodos */
    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (keyData == (Keys.Escape))
        {
            Close();
            return true;
        }
        return base.ProcessCmdKey(ref msg, keyData);
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        controller.LoadAll();
        controller.LoadById(textId.Text);
        controller.Save(txtNome.Text);
        controller.Update(textId.Text, txtNome.Text);
        controller.DeleteById(textId.Text);
    }
}
