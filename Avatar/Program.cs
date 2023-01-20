using Avatar;

Omaticaya omaticaya = new Omaticaya("Jake Sully", 2.6, "azul clara","Na'vi", "longo e fino");
Omaticaya omaticaya2 = new Omaticaya("Neytiri Sully", 2.3, "azul clara", "Na'vi", "longo e fino");
Metkayina metkayina = new Metkayina("Tonowari", 3, "azul esverdeada", "Na'vi", "curto e grosso", "Na´vi em sinais");
SkyPeople skyPeople = new SkyPeople("Coronel Miles", 1.79);

omaticaya.Apresentar();
omaticaya.Caracteristicas();
omaticaya.Escalar();
Console.WriteLine("\n");
omaticaya2.Apresentar();
omaticaya2.Caracteristicas();
omaticaya2.Conectar();
omaticaya.Conectar();
Console.WriteLine("\n");
metkayina.Apresentar();
metkayina.Caracteristicas();
metkayina.Mergulhar();
Console.WriteLine("\n");
skyPeople.Apresentar();
skyPeople.Falar();
Console.ReadLine();