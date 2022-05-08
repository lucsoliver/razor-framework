using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend
{
    public class AbsPropriedadesTriangulo
    {
        public double L1 { get; set; }
        public double L2 { get; set; }
        public double L3 { get; set; }
        public String Lado1 { get; set; }
        public String Lado2 { get; set; }
        public String Lado3 { get; set; }
        public String Mensagem { get; set; }
        public String Resposta { get; set; } = "";
        
        public AbsPropriedadesTriangulo(double l1, double l2, double l3)
        {
            this.L1 = l1;
            this.L2 = l2;
            this.L3 = l3;
        }
        public AbsPropriedadesTriangulo(string l1, string l2, string l3)
        {
            this.Lado1 = l1;
            this.Lado2 = l2;
            this.Lado3 = l3;

            this.L1 = ConverterLado(Lado1);
            this.L2 = ConverterLado(Lado2);
            this.L3 = ConverterLado(Lado3);
        }

        private double ConverterLado(string lado) {
            double retorno;
            try
            {
                retorno=Convert.ToDouble(lado);
            }
            catch(Exception e)
            {
                this.Mensagem = "Dados Inválidos";
                this.Resposta = "Dados Inválidos";
                retorno = -1;
            }
            return retorno;
        }
    }
}
