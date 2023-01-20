using System;
namespace Avatar
{
	public class SkyPeople
	{
        private string Nome;
        private double Altura;

        public void Apresentar(string nome, double altura)
        {
            Nome = nome;
            Altura = altura;
            Console.WriteLine($"Olá! Sou o {Nome} e tenho {Altura} metros de Altura");
        }

        public void Falar()
        {
            Console.WriteLine(Nome + " Falou");
        }
    }
}

