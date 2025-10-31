using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidacionFormularioC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtNombre.TextChanged += TxtNombre_TextChanged;
            txtEdad.TextChanged += TxtEdad_TextChanged;
            btnValidar.Click += BtnValidar_Click;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Validación de Formulario";
        }


        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

            if (txtNombre.Text.Length > 0 && txtNombre.Text.Length < 3)
            {
                this.Text = "El nombre parece muy corto...";
            }
            else
            {
                this.Text = "Validación de Formulario";
            }
        }

        private void TxtEdad_TextChanged(object sender, EventArgs e)
        {
 
            if (!int.TryParse(txtEdad.Text, out _) && txtEdad.Text.Length > 0)
            {
                MessageBox.Show("Por favor ingresa solo números en la edad.",
                    "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEdad.Clear();
            }
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string edadTexto = txtEdad.Text.Trim();

            // Validar que ambos campos estén llenos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(edadTexto))
            {
                MessageBox.Show("Por favor llena todos los campos.",
                    "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que la edad sea numérica y >= 18
            if (!int.TryParse(edadTexto, out int edad))
            {
                MessageBox.Show("La edad debe ser un número válido.",
                    "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (edad < 18)
            {
                MessageBox.Show("Debes ser mayor de edad para continuar.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Si todo está correcto
            MessageBox.Show($"Bienvenido {nombre}, acceso permitido.",
                "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}