using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5_n_ºRA6322036
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Jogador obj;
        Jogador[] v = new Jogador[5];
        int i = 0;

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            if (i < 5)
            {
                obj = new Jogador();
                obj.Nome = txt_Nome.Text;
                obj.Peso = Convert.ToDouble(txt_Peso.Text);
                obj.Altura = Convert.ToDouble(txt_Altura.Text);
                obj.Idade = Convert.ToInt32(txt_Idade.Text);
                obj.Numero = Convert.ToInt32(txt_Numero.Text);
                obj.Time = txt_Time.Text;
                v[i] = obj;
                i++;

                txt_Altura.Text = "";
                txt_Idade.Text = "";
                txt_Nome.Text = "";
                txt_Numero.Text = "";
                txt_Peso.Text = "";
                txt_Time.Text = "";

                MessageBox.Show("Gravado com sucesso! ", "Aula5-n ºRA6322036", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Não é possivel gravar! ", "Aula5-n ºRA6322036", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 5; j++)
            {
                if (v[j].Nome.Equals(txt_Nome.Text))
                {
                    txt_Peso.Text = v[j].Peso.ToString();
                    txt_Altura.Text = v[j].Altura.ToString();
                    txt_Idade.Text = v[j].Idade.ToString();
                    txt_Numero.Text = v[j].Numero.ToString();
                    txt_Time.Text = v[j].Time;
                    j = 4;
                }
                else
                {
                    if (j == 4) MessageBox.Show("Time não encontrado! ", "Aula5-n ºRA6322036", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }

        }
    }
}
