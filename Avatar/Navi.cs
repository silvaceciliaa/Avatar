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

        public Navi(string nome, double altura, string cor)
        {
            Nome = nome;
            Altura = altura;
            Cor = cor;
        }

        public virtual void Apresentar()
        { 	
            Console.Write("Eu vejo você.");
		}

        public virtual void Caracteristicas()
        {
            Console.WriteLine($"{Nome} tem {Altura} metros de altura, pele {Cor}");
        }
        public void Conectar()
        {
            Console.WriteLine(Nome + "conectou");
        }
    }
}

