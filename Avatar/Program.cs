using Avatar;

Omaticaya omaticaya = new Omaticaya("Jake Sully", 2.6, "azul clara");
Metkayina metkayina = new Metkayina("Tonowari", 3, "azul esverdeado");
SkyPeople skyPeople = new SkyPeople();

omaticaya.Apresentar();
omaticaya.Caracteristicas();
omaticaya.Escalar();
Console.WriteLine("\n");
metkayina.Apresentar();
Console.WriteLine("\n");
skyPeople.Apresentar("Coronel Miles", 1.79);
skyPeople.Falar();
Console.ReadLine();