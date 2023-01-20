using System;
namespace Avatar
{
	public class SkyPeople
	{
        private string Nome;
        private double Altura;

        public SkyPeople(string nome, double altura)
        {
            Nome = nome;
            Altura = altura;
            
        }
        public void Apresentar()
        {
            Console.WriteLine($" Olá! Sou o {Nome} e sou humano");
        }

        public void Caracteristicas()
        {
            Console.WriteLine($"{Nome} tem {Altura} metros de altura");
        }

        public void Falar()
        {
            Console.WriteLine(Nome + " falou");
        }
    }
}

