using p1bpoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class Chofer : Ipiloto 
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string TipoLicencia { get; set; }

        string Ipiloto.Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int Ipiloto.Edad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string Ipiloto.TipoLicencia { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Chofer(string name, int edadPiloto, string tipo)
        {
           Nombre = name;
           Edad = edadPiloto;
           TipoLicencia = tipo;
        }

        public bool ValidarLicencia()
        {
            switch(TipoLicencia.ToUpper())
            {
                case "A":
                    return Edad >= 23;
                case "B":
                    return Edad >= 21;
                case "C":
                    return Edad >= 16;
                case "M":
                    return Edad >= 16;  
                default:
                    return false;

            }
        }

        public void MostrarValidacion()
        {
            if (ValidarLicencia())
            {
                Console.WriteLine($"{Nombre} tiene la edad necesaria para obtener la licencia tipo {TipoLicencia} y conducir este vehiculo.");


            }
            else
            {
                Console.WriteLine($"{Nombre} lamentablemete no tiene la edad necesaria  para obtener la licencia {TipoLicencia}.");

            }

        }

        public void MostrarInformación()
        {
            Console.WriteLine("Nombre: {0}", this.Nombre);
            Console.WriteLine("edad: {0}", this.Edad);
            Console.WriteLine("Licencia Tipo: {0}", this.TipoLicencia);
        }
    }
}
