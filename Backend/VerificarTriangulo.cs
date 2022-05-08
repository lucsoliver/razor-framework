using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend
{
    public class VerificarTriangulos : AbsPropriedadesTriangulo
    {
        public VerificarTriangulos(double l1, double l2, double l3)
            : base(l1, l2, l3)
        {
            this.Verificar();
        }

        private void Verificar()
        {
            if ((this.L1 == this.L2) && (this.L1 == this.L3))
                this.Resposta = "Equilatero";
            else if ((this.L1 == this.L2) || (this.L1 == this.L3)
                || (this.L2 == this.L3))
                this.Resposta = "Isoceles";
            else
                this.Resposta = "Escaleno";
        }
    }
}
