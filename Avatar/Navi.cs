using System;
namespace Avatar
{
	public class Navi
	{
		protected string Nome;
        protected double Altura;
		protected string Cor;
        protected string Lingua;
        protected string Rabo;

        public Navi(string nome, double altura, string cor, string lingua, string rabo)
        {
            Nome = nome;
            Altura = altura;
            Cor = cor;
            Lingua = lingua;
            Rabo = rabo;
        }

        public virtual void Apresentar()
        { 	
            Console.Write("Eu vejo você.");
		}

        public virtual void Caracteristicas()
        {
            Console.WriteLine($"{Nome} tem {Altura} metros de altura, pele {Cor}, fala {Lingua}, e seu rabo é {Rabo}");
        }
        public void Conectar()
        {
            Console.WriteLine(Nome + " conectou");
        }
    }
}

