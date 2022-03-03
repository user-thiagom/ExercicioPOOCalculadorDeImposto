using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOOCalculadorDeImposto.Entities
{
    public class PessoaJuridica : Contribuinte
    {
        public int NumeroDeFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroDeFuncionarios) : base(nome,rendaAnual)
        {
            NumeroDeFuncionarios = numeroDeFuncionarios;
        }

        public override double CalcularImposto()
        {
            double imposto = RendaAnual * 0.16;

            if (NumeroDeFuncionarios > 10)
                imposto = RendaAnual * 0.14;
            
            return imposto;
        }
    }
}
