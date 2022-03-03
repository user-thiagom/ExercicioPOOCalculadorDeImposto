using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOOCalculadorDeImposto.Entities
{
    public class PessoaFisica : Contribuinte
    {
        public double GastosComSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude) : base(nome,rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public override double CalcularImposto()
        {
            double valorDeAbatimentoEmSaude = 0.0;
            double imposto = 0.0;

            switch (RendaAnual)
            {
                case < 20000.00:
                    if (GastosComSaude > 0.0)
                        valorDeAbatimentoEmSaude = GastosComSaude * 0.5;
                    imposto = (RendaAnual * 0.15) - valorDeAbatimentoEmSaude;
                    return imposto;
                case >= 20000.00:
                    if (GastosComSaude > 0.0)
                        valorDeAbatimentoEmSaude = GastosComSaude * 0.5;
                    imposto = (RendaAnual * 0.25) - valorDeAbatimentoEmSaude;
                    return imposto;
                default:
                    return 0.0;
            }
        }
    }
}
