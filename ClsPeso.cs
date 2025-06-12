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
        //Atributos
        private int estatura;
        private float peso;
        private float sancada;
        private float pasos;
        private float IMC;
        private string estado;
        private string recomentacion;
        //Constructor
        public ClsPeso()
        {
            Estatura = 0;
            Peso = 0;
            Sancada = 0;
            Pasos = 0;
            Estado = "";
            Recomendacion = "";
        }

        //propiedades
        public int Estatura
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

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Recomendacion
        {
            get { return recomentacion; }
            set { recomentacion = value; }
        }
        public float CalcularIMC()
        {
            float IMC;
            float estaturaMetros = estatura / 100.0f;  // Convertir cm a metros
            IMC = Peso / (estaturaMetros * estaturaMetros);
            return IMC;

        }
        public string CalcularPesoIdea()
        {
            CalcularIMC();

            if (IMC < 18.5)
            {
                Estado = "Bajo";
                Recomendacion = "No debes caminar.";
            }
            else if (IMC <= 24.9)
            {
                Estado = "Normal";
                Recomendacion = "Se recomienda caminar 4 km";
            }
            else if (IMC <= 29.9)
            {
                Estado = "Sobrepeso";
                Recomendacion = "Se recomienda caminar 6 km";
            }
            else
            {
                Estado = "Obesidad";
                Recomendacion = "Se recomienda caminar 10 km";
            }

            return Recomendacion;
        }
        public float CalcularKilometros()
        {
            float km;
            km = pasos * sancada / 1000;
            return km;
        }
        public float CalcularKmFaltantes()
        {
            float kmRecorridos = CalcularKilometros();
            float kmRecomendados = 0;

            if (estado == "Normal")
            {
                kmRecomendados = 4;
            }
            else if (estado == "Sobrepeso")
            {
                kmRecomendados = 6;
            }         
            else if (estado == "Obesidad")
            {
                kmRecomendados = 10;
            }
                
            else
            {
                kmRecomendados = 0;
            }
            float faltantes = kmRecomendados - kmRecorridos;

           
            return faltantes;
        }
        public string _Estado
        {
            get { return estado; }
        }


    }
}
