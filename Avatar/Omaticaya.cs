using System;
namespace Avatar
{
    public class Omaticaya : Navi
    {
        public Omaticaya(string nome, double altura, string cor, string lingua, string rabo) : base(nome, altura, cor, lingua, rabo)
        {

        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($" Sou o {Nome}, clã Omaticaya");
        }

        public void Escalar()
        {
            Console.WriteLine(Nome + " escalou");
        }
    }
}

