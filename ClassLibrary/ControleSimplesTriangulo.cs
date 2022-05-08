using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend
{
    public class ControleSimplesTriangulo : AbsPropriedadesTriangulo
    {
        private ValidacaoTriangulo validacao;
        private VerificarTriangulos triangulos;

        public ControleSimplesTriangulo(string l1, string l2, string l3)
            : base(l1, l2, l3) {
            this.Verificar();
    }
        private void Verificar()
         {
            validacao = new ValidacaoTriangulo(Lado1, Lado2, Lado3);
            if (validacao.Resposta.Length > 0)
                this.Resposta = validacao.Resposta;
            else
            {
            triangulos = new VerificarTriangulos(L1, L2, L3);
            this.Resposta = triangulos.Resposta;
            }  
        }
    }
}
