using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace La_codifica_di_huffman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalizza_Click(object sender, EventArgs e)
        {
            dgvTab.Rows.Clear();
            lstRis.Items.Clear();
            int indice = -1, z = 0;

            string[] car = new string[txtParola.Text.Length];
            double[] occ = new double[txtParola.Text.Length];
           
            lstRis.Items.Add("Caratteri totali = " + Convert.ToString(txtParola.Text.Length));
            
            //Analizza parola
            for (int i = 0; i < txtParola.Text.Length; i++)
            {
                //controlla il carattere nell'array
                for (int c = 0; c < txtParola.Text.Length; c++)
                {
                    if (txtParola.Text.Substring(i, 1) == car[c])
                    {
                        indice = c;
                        break;
                    }
                    else
                        indice = -1;
                }
                if (indice != -1)
                {
                    occ[indice] += 1;
                    //Mostra nella tabella
                    dgvTab["occor", indice].Value = occ[indice];
                    dgvTab["occ_car", indice].Value = occ[indice] / txtParola.Text.Length;
                }
                else
                {                    
                    car[i] = txtParola.Text.Substring(i, 1);
                    occ[i] += 1;
                    dgvTab.Rows.Add(1);
                    //Mostra nella tabella
                    dgvTab["car", z].Value = car[i];
                    dgvTab["occor", z].Value = occ[i];
                    dgvTab["occ_car", z].Value = occ[i] / txtParola.Text.Length;
                    z++;
                }
            }
            dgvTab.Sort(dgvTab.Columns["occor"], ListSortDirection.Descending);
        }
    }
}