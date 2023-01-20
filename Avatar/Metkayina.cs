using System;
namespace Avatar
{
    public class Metkayina : Navi
    {
        private string SegundaLingua;

        public Metkayina(string nome, double altura, string cor, string lingua, string rabo, string segundaLingua) : base(nome, altura, cor, lingua, rabo)
        {
            SegundaLingua = segundaLingua;
        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($" Sou o {Nome}, clã Metkayina");
        }

        public override void Caracteristicas()
        {
            base.Caracteristicas();
            Console.WriteLine($"Metkayina tem {SegundaLingua} como segunda língua");
        }
    }
}

