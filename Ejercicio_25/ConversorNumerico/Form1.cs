using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeNumeracion;

namespace ConversorNumerico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertirBin_Click(object sender, EventArgs e)
        {
            if (NumeroBinario.Validar(txtBinarioIn.Text))
                txtBinDecOut.Text = Conversor.BinarioDecimal(txtBinarioIn.Text).ToString();
            else
                txtBinarioIn.Focus();
        }

        private void btnConvertirDec_Click(object sender, EventArgs e)
        {
            double entrada;
            if (Double.TryParse(txtDecimalIn.Text, out entrada))
                txtDecBinOut.Text = Conversor.DecimalBinario(entrada).ToString();
        }

        private void txtBinIn_leave(object sender, EventArgs e)
        {
            if (!NumeroBinario.Validar(txtBinarioIn.Text))
                txtBinarioIn.Focus();
        }

        private void txtDecIn(object sender, EventArgs e)
        {
            double buffer;
            if (!Double.TryParse(txtDecimalIn.Text, out buffer))
                txtDecimalIn.Focus();
        }

        
        private void txtBinarioIn_Click(object sender, EventArgs e)
        {
            txtBinarioIn.SelectAll();
        }
    }
}
