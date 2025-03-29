
using p1bpoo.MisClases;


//pilotos:

Chofer pilot1 = new Chofer("Vicente", 35, "A");
Chofer pilot2 = new Chofer("Lola", 28, "B");
Chofer pilot3 = new Chofer("Pedro", 45, "C");
Chofer pilot4 = new Chofer("Luis", 25, "M");
Chofer pilot5 = new Chofer("Maria", 14, "C");
Console.WriteLine("----------------------------------------------------------------------\n");
Console.WriteLine("----------------------------------------------------------------------\n");

Console.WriteLine("Moto: ");
Moto suzuki = new Moto(2021, "Negra", "Suzuki-120");
suzuki.InformacionVehiculo();
Console.WriteLine(" ");

Console.WriteLine(suzuki.AsignarPiloto(pilot4));
pilot4.MostrarInformación();
pilot4.MostrarValidacion();
Console.WriteLine(" ");

suzuki.Encender();
suzuki.acelerar(100);
suzuki.HacerCaballito();
suzuki.Frenar(20);
suzuki.acelerar(130);
suzuki.Frenar(50);
suzuki.Frenar(20);
suzuki.HacerCaballito();
suzuki.Apagar();

Console.WriteLine("----------------------------------------------------------------------\n");
Console.WriteLine("----------------------------------------------------------------------\n");

Console.WriteLine("Taxi: ");
Taxi retinto = new Taxi(2026, "Corinto", "Toyota");
retinto.InformacionVehiculo();
retinto.verCantidadPasajeros();
Console.WriteLine(" ");

Console.WriteLine(retinto.AsignarPiloto(pilot5));
pilot5.MostrarInformación();
pilot5.MostrarValidacion();
Console.WriteLine(" ");
Console.WriteLine(retinto.AsignarPiloto(pilot2));
pilot2.MostrarInformación();
pilot2.MostrarValidacion();
Console.WriteLine(" ");

retinto.Encender();
retinto.acelerar(100);
retinto.Frenar(20);
retinto.Apagar();
retinto.acelerar(180);
retinto.Frenar(95);
retinto.Apagar();


Console.WriteLine("----------------------------------------------------------------------\n");
Console.WriteLine("----------------------------------------------------------------------\n");
Console.WriteLine("Autobus:");
autoBus bus = new autoBus(2015, "Azul y Blanco", "Toyota");
bus.InformacionVehiculo();
bus.VerCantidadAsientos();
Console.WriteLine(" ");

Console.WriteLine(bus.AsignarPiloto(pilot1));
pilot1.MostrarInformación();
pilot1.MostrarValidacion();
Console.WriteLine(" ");

bus.Encender();
bus.acelerar(50);
bus.Frenar(20);
bus.acelerar(110);
bus.Frenar(50);
Console.WriteLine("MUY LOCO MANEJA VICENTE USHH");
bus.Apagar();









