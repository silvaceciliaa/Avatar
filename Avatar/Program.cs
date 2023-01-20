using Avatar;

Omaticaya omaticaya = new Omaticaya("Jake Sully", 2.6, "azul clara");
Metkayina metkayina = new Metkayina("Tonowari", 3, "azul esverdeado");
SkyPeople skyPeople = new SkyPeople("Coronel Miles", 1.79);

omaticaya.Apresentar();
omaticaya.Caracteristicas();
omaticaya.Escalar();
Console.WriteLine("\n");
metkayina.Apresentar();
Console.WriteLine("\n");
skyPeople.Apresentar();
skyPeople.Falar();
Console.ReadLine();