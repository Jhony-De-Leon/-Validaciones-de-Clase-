using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class autoBus : Vehiculo
    {
        private int cantidadAsientos = 80;

        public autoBus(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "A" };
        }

        protected override int VelocidadMaxima { get; set; } = 100;
        protected override int CapacidadTanque { get; set; } = 100;
        protected override double ConsumoCombustible { get; set; } = 6.45;

        public void VerCantidadAsientos()
        {
            Console.WriteLine("Cantidad de asientos: {0}", cantidadAsientos);
        }

        
        public override void acelerar(int cuanto)
        {
            if (velocidad + cuanto <= VelocidadMaxima)
            {
                velocidad += cuanto;
                Console.WriteLine("El autobús ha acelerado a {0} km/h.", velocidad);
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
                Console.WriteLine("El autobús ha frenado a {0} km/h.", velocidad);
            }
            else
            {
                Console.WriteLine("No se puede frenar más, el autobús está detenido.");
            }
        }

        

        public override string TipoLicencia()
        {
            return "Licencia tipo A requerida para conducir este autobús.";
        }
    }
}
