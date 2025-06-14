using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PESO_IDEAL
{
    public partial class frmPeso_Ideal : Form
    {
        private ClsPeso Peso;
        public frmPeso_Ideal()
        {
            Peso = new ClsPeso();
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEstatura.Text) ||
                string.IsNullOrWhiteSpace(txtPeso.Text) ||
                string.IsNullOrWhiteSpace(txtDistancia.Text) ||
                string.IsNullOrWhiteSpace(txtPasos.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Peso.Estatura = float.Parse(txtEstatura.Text);
            Peso.Peso = float.Parse(txtPeso.Text);
            Peso.Sancada = float.Parse(txtDistancia.Text);
            Peso.Pasos = float.Parse(txtPasos.Text);

            // Calcular resultados
            float imc = Peso.CalcularIMC();
            string estado;
            string recomendacion = Peso.CalcularRecomendacion(out estado);
            float kmRecorridos = Peso.CalcularKilometros();
            float kmFaltantes = Peso.CalcularKmFaltantes();

            // Mostrar resultados
            txtIMC.Text = imc.ToString("0.00");
            txtEstado.Text = estado;
            txtRecomendado.Text = recomendacion;
            txtKm.Text = kmRecorridos.ToString("0.00") + " km";
            txtfaltante.Text = kmFaltantes.ToString("0.00") + " km";

            // Limpiar campos de entrada solamente
            txtEstatura.Clear();
            txtPeso.Clear();
            txtDistancia.Clear();
            txtPasos.Clear();
        }

        //Validaciones
        private void txtEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Permitir solo teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea letras, puntos, comas, símbolos, etc.
            }
        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.' && textBox.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void txtPasos_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.' && textBox.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '.' && textBox.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
    }

}

