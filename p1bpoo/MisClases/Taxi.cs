using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class Taxi : Vehiculo
    {
        private int cantidadPasajeros = 4;
        public Taxi(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "B" };
        }

        protected override int VelocidadMaxima { get; set; } = 180;
        protected override int CapacidadTanque { get; set; } = 50;
        protected override double ConsumoCombustible { get; set; } = 8.8;

        public void verCantidadPasajeros()
        {
            Console.WriteLine("Cantidad de pasajeros: {0}", cantidadPasajeros);
        }

        // Nuevo método para cambiar la cantidad de pasajeros
        public void cambiarCantidadPasajeros(int nuevaCantidad)
        {
            if (nuevaCantidad > 0 && nuevaCantidad <= 4)
            {
                cantidadPasajeros = nuevaCantidad;
                Console.WriteLine("Cantidad de pasajeros actualizada a: {0}", cantidadPasajeros);
            }
            else
            {
                Console.WriteLine("Cantidad de pasajeros no válida. Debe estar entre 1 y 4.");
            }
        }
       

        public override void acelerar(int cuanto)
        {
            if (velocidad + cuanto <= VelocidadMaxima)
            {
                velocidad += cuanto;
                Console.WriteLine("El Taxi ha acelerado a {0} km/h.", velocidad);
            }
            else
            {
                Console.WriteLine("No se puede exceder la velocidad máxima de {0} km/h.", VelocidadMaxima);
            }
        }

        public override void Frenar(int cuanto)
        {
            if (velocidad - cuanto >= 0)
            {
                velocidad -= cuanto;
                Console.WriteLine("El Taxi ha frenado a {0} km/h.", velocidad);
            }
            else
            {
                Console.WriteLine("No se puede frenar más, el Taxi está detenido.");
            }
        }

        public override string TipoLicencia()
        {
            return "Licencia tipo B requerida para conducir este taxi.";
        }

    }
}
