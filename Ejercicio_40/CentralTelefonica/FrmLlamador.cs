using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CentralTelefonica
{
    public partial class FrmLlamador : Form
    {
        public Centralita centralita;
        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }
        public Centralita Centralita
        {
            get { return centralita; }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "Nro Destino";
            txtNroOrigen.Text = "Nro Origen";
            cmbFranja.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if(cmbFranja.Enabled)
            {
                Provincial.Franja franja;
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franja);
                Provincial nuevaLlamada = new Provincial(txtNroOrigen.Text, franja, random.Next(0, 6), txtNroDestino.Text);
                try
                {
                    this.centralita += nuevaLlamada;
                }
                catch (CentralitaException ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Local nuevaLlamada = new Local(txtNroOrigen.Text, random.Next(0, 60), txtNroDestino.Text, ((float)random.Next(50, 560)) / 100);
                try
                {
                    this.centralita += nuevaLlamada;
                }
                catch (CentralitaException ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region PanelNumerico
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "1";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "2";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "3";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "4";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "5";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "6";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "7";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "8";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "9";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "0";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "0";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "*";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "*";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "#";                
            }
            else
                txtNroDestino.Text += "#";
        } 
        #endregion
    }
}
