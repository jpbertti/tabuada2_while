using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuada2_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lsbResultado.Items.Clear();
            txtNumero.Clear();
            txtNumero.Focus();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lsbResultado.Items.Clear(); //limpar

            int valor = int.Parse(txtNumero.Text);
            int i = 1;
            while (i <= 100)
            {
                lsbResultado.Items.Add($"{valor} x {i} = {valor * i}");
                i++;
            }
        }


    }
}
