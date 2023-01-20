using System;
namespace Avatar
{
    public class Omaticaya : Navi
    {
        public Omaticaya(string nome, double altura, string cor) : base(nome, altura, cor)
        {

        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Sou o {Nome}, clã Omaticaya");
        }

        public void Escalar()
        {
            Console.WriteLine(Nome + " escalou");
        }
    }
}

