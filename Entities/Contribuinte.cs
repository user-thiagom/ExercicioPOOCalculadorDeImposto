using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOOCalculadorDeImposto.Entities
{
    public abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        protected Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalcularImposto();

        public override string ToString()
        {
            return $"{Nome}: R$ {CalcularImposto()}";
        }
    }
}
