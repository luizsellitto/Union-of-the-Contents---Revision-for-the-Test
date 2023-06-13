using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Union_of_the_Contents___Revision_for_the_Test
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_calc_Click(object sender, EventArgs e)
        {
            if (ValidaCampus())
            {
                IMC person = new IMC(Convert.ToDouble(mask_alt.Text), Convert.ToDouble(tx_peso));
                (double imc, string classificacao, string grau) = person.Imc();
                lb_imc.Text = $"O seu imc é igual a {imc}, a classificação é igual a {classificacao}" +
                    $"\n e o grau é igual a {grau}";
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            tx_nome.Text = string.Empty;
            tx_peso.Text = string.Empty;
            mask_alt.Text = string.Empty;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            string sexo;
            if (rb_fem.Checked == true)
            {
                sexo = rb_fem.Text;
            }
            else
            {
                sexo =rb_masc.Text;
            }
            MessageBox.Show($"O seu sexo é: {sexo}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itens = "";
            foreach (var item in ck_materias.CheckedItems)
            {
                itens += item.ToString() + "\n";
            }

            MessageBox.Show("Itens selecionados:\n" + itens);
        }

        private bool ValidaCampus()
        {
            
            bool verificar = true;
            if (tx_nome.Text == "") //ou String.Empty = string vazia
            {
                verificar = false;
                errorProvider1.SetError(tx_nome, "Campo obrigatório!");
            }
            if (tx_peso.Text == "")
            {
                verificar = false;
                errorProvider3.SetError(tx_peso, "Campo obrigatório!");
            }
            return verificar;

        }
    }
}
