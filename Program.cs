using ExercicioPOOCalculadorDeImposto.Entities;

List<Contribuinte> contribuintes = new List<Contribuinte>();

Console.Write("Insira o numero de contribuintes: ");
int numeroDeContribuintes = int.Parse(Console.ReadLine());

for (int i = 1; i <= numeroDeContribuintes; i++)
{
    Console.WriteLine($"\nDados do Contribuinte {i}");
    Console.Write("Pessoa Física ou Juridica (f/j)? ");
    char tipoContribuinte = char.Parse(Console.ReadLine());

    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Renda Anual: ");
    double rendaAnual = double.Parse(Console.ReadLine());

    Contribuinte contribuinte;

    switch (tipoContribuinte)
    {
        case 'f':
            Console.Write("Gastos com saúde: ");
            double gastosComSaude = double.Parse(Console.ReadLine());
            contribuinte = new PessoaFisica(nome,rendaAnual,gastosComSaude);
            contribuintes.Add(contribuinte);
            break;
        case 'j':
            Console.Write("Numero de funcionários: ");
            int numeroDeFuncionarios = int.Parse(Console.ReadLine());
            contribuinte = new PessoaJuridica(nome,rendaAnual,numeroDeFuncionarios);
            contribuintes.Add(contribuinte);
            break;
        default:
            break;
    }
}

double impostosColetados = 0.0;

Console.WriteLine("\nIMPOSTOS PAGOS");
foreach (Contribuinte con in contribuintes)
{
    Console.WriteLine(con);
    impostosColetados += con.CalcularImposto();
}
Console.WriteLine($"\nImpostos coletados: {impostosColetados}");