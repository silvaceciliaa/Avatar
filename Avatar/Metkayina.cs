using System;
namespace Avatar
{
    public class Metkayina : Navi
    {
        protected string SegundaLingua;

        public Metkayina(string nome, double altura, string cor) : base(nome, altura, cor)
        {

        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Sou o {Nome} e tenho {Altura} metros de altura, clã Metkayina");
        }
    }
}

