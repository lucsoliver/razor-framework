using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend
{
    public class ValidacaoTriangulo : AbsPropriedadesTriangulo
    {
        public ValidacaoTriangulo(string l1, string l2, string l3)
            :base(l1,l2,l3)
        {
            if (Resposta == "")
                this.Validar();
        }

        private void Validar() {
            if ((L1 + L2 <= L3)
                || ((L1 + L3 <= L2)
                || ((L2 + L3 <= L1))
                )
                )
                this.Resposta = "Não é um trianbulo";

        }
    }
}
