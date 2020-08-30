using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCrearPersona
{
    public partial class FormPersona : Form
    {
        private Persona persona;
        public event DelegadoString EventoString;
        public FormPersona()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            if(persona == null)
            {
                persona = new Persona(textBoxNombre.Text, textBoxApellido.Text);
                buttonCrear.Text = "Actualizar";
                this.EventoString("Persona creada");
            }
            else
            {
                persona.Apellido = textBoxApellido.Text;
                persona.Nombre = textBoxNombre.Text;
                this.EventoString("Persona Modificada");
            }
        }
        public void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio + "\n" + persona.Mostrar());
        }

        private void FormPersona_Load(object sender, EventArgs e)
        {
            this.EventoString += NotificarCambio;
        }
    }
}
