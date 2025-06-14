using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESO_IDEAL
{
    class ClsPeso
    {
        private float estatura;// en  cm
        private float peso;   // en kg
        private float sancada;// en cm
        private float pasos; // cantidad de pasos

        // Constructor
        public ClsPeso()
        {
            estatura = 0;
            peso = 0;
            sancada = 0;
            pasos = 0;
        }

        // Propiedades
        public float Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }

        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public float Sancada
        {
            get { return sancada; }
            set { sancada = value; }
        }

        public float Pasos
        {
            get { return pasos; }
            set { pasos = value; }
        }

        // Método para calcular el IMC
        public float CalcularIMC()
        {
            float estaturaMetros = estatura / 100.0f;
            float imc = peso / (estaturaMetros * estaturaMetros);
            return imc;
        }

        // Método para determinar el estado y recomendación según el IMC
        public string CalcularRecomendacion(out string estado)
        {
            float imc = CalcularIMC();
            string recomendacion;

            if (imc < 18.5f)
            {
                estado = "Bajo";
                recomendacion = "No debes caminar.";
            }
            else if (imc <= 24.9f)
            {
                estado = "Normal";
                recomendacion = "Se recomienda caminar 4 km.";
            }
            else if (imc <= 29.9f)
            {
                estado = "Sobrepeso";
                recomendacion = "Se recomienda caminar 6 km.";
            }
            else
            {
                estado = "Obesidad";
                recomendacion = "Se recomienda caminar 10 km.";
            }

            return recomendacion;
        }

        // Método para calcular los kilómetros recorridos
        public float CalcularKilometros()
        {
            float km = (pasos * sancada) / 100000f; // convertimos de cm a km
            return km;
        }

        // Método para calcular cuántos kilómetros faltan según el estado
        public float CalcularKmFaltantes()
        {
            float kmRecorridos = CalcularKilometros();
            string estado;
            CalcularRecomendacion(out estado);

            float kmRecomendados;

            if (estado == "Normal")
            {
                kmRecomendados = 4f;
            }
            else if (estado == "Sobrepeso")
            {
                kmRecomendados = 6f;
            }
            else if (estado == "Obesidad")
            {
                kmRecomendados = 10f;
            }
            else
            {
                kmRecomendados = 0f;
            }

            float kmFaltantes = kmRecomendados - kmRecorridos;

            if (kmFaltantes < 0)
            {
                kmFaltantes = 0;
            }

            return kmFaltantes;
        }
    }
}
    
