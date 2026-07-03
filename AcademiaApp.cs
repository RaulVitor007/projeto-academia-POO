List<Exercicio> ListaDeExercicio = new();
string continuar = "s";

while (continuar.ToLower() == "s") 
{
    Console.WriteLine("----vamos cadastrar o treino!----");

    Console.Write("digite nome do exercicio: ");
    string Nome = Console.ReadLine();

    Console.Write("digite quantas serie: ");
    int Serie = int.Parse(Console.ReadLine());

    Console.Write("digite quantas repeticao: ");
    int Repeticao = int.Parse(Console.ReadLine());

    Console.Write("digite quantas carga: ");
    int Carga = int.Parse(Console.ReadLine());

    Exercicio novoExercicio = new Exercicio(Nome, Serie, Repeticao, Carga);
    ListaDeExercicio.Add(novoExercicio);

    Console.Write("\nDeseja cadastrar mais um exercício? (s/n): ");
    continuar = Console.ReadLine();
}

    Console.WriteLine("----Treino Completo----");

    foreach (Exercicio cada in ListaDeExercicio) 
    {
    cada.IniciarTreino();
    }
   

