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

        private void frmPeso_Ideal_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            Peso.Estatura = int.Parse(txtEstatura.Text);  // en centímetros
            Peso.Peso = float.Parse(txtPeso.Text);         // en kg
            Peso.Sancada = float.Parse(txtDistancia.Text); // en metros
            Peso.Pasos = float.Parse(txtPasos.Text);       // cantidad de pasos


            Peso.CalcularPesoIdea();

            float kilometros = Peso.CalcularKilometros();
            float faltante = Peso.CalcularKmFaltantes();
            float IMC = Peso.CalcularIMC();


            txtIMC.Text = "" + IMC;
            txtEstado.Text = "" + Peso.Estado;
            txtRecomendado.Text = "" + Peso.Recomendacion;
            txtKm.Text = "" + kilometros.ToString("0.00") + " km";
            txtFaltante.Text = "" + faltante + "km";

            txtEstatura.Clear();
            txtPeso.Clear();
            txtDistancia.Clear();
            txtPasos.Clear();
            txtFaltante.Clear();
        }

   
    }
}
