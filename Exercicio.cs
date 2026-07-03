class Exercicio {

    public string Nome {  get; set; }
    public int Serie { get; set; }
    public int Repeticao { get; set; }
    public int Carga {  get; set; }

    public Exercicio(string Nome, int serie, int Repeticao, int Carga) {

        this.Nome = Nome;
        this.Serie = serie;
        this.Repeticao = Repeticao;
        this.Carga = Carga;

    }

    public void IniciarTreino() {

        {

            if (Carga <= 0) {
                Console.WriteLine($"Exercicio: {Nome} a serie é {Serie} de {Repeticao}, com essa carga so da barra!");
            }
            else if (Carga >= 100) {
                Console.WriteLine($"Exercicio: {Nome}, com essa carga {Carga}, vamos diminuir um pouco as series e repetições! ");
            }
            else {
                Console.WriteLine($"Exercicio: {Nome} a serie é {Serie} de {Repeticao}, com essa carga {Carga}");
            }
        }
    }

}


