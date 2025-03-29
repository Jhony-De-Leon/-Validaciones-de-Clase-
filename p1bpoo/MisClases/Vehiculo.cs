using p1bpoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }

        public int velocidad = 0;

        //Propiedades protegidas para sobrescribir:
        protected virtual int VelocidadMaxima { get; set; } 
        protected virtual int CapacidadTanque { get; set; } 
        protected virtual double ConsumoCombustible { get; set; } 



        //tipos de licencia
        protected List<string> tiposLicenciaAceptados = new List<string> { "A", "B", "C" };

        private Chofer piloto = null;
        private int estadoVehiculo = 0; // 0 = apagado, 1 = encendido, 2 = en movimiento

        //agregar metodo de asignar piloto
        public string AsignarPiloto(Chofer elPiloto)
        {
            if (elPiloto == null)
            {
                return "No se puede asignar un piloto nulo";
            }
            if (!tiposLicenciaAceptados.Contains(elPiloto.TipoLicencia))
            {
                return "El piloto no tiene la licencia adecuada para este vehiculo";
            }
            if (piloto != null)
            {
                return "El vehiculo ya tiene un piloto asignado";
            }
            piloto = elPiloto;
            return "Piloto asignado correctamente";
        }


        public virtual void Encender()
        {
            if (estadoVehiculo == 0)
            {
                estadoVehiculo = 1;
                Console.WriteLine("El vehículo se ha encendido.");
            }
            else
            {
                Console.WriteLine("El vehículo ya está encendido.");
            }
        }



        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color {0}:", this.Color);
            Console.WriteLine("Modelo {0}:", this.Modelo);
            Console.WriteLine("Año {0}", this.Year);
            Console.WriteLine("Velocidad Actual {0} KMS / H", velocidad);
            Console.WriteLine("Velocidad Maxima {0} KM / H", VelocidadMaxima);
            Console.WriteLine("Capacidad del Tanque {0} Litros", CapacidadTanque);
            Console.WriteLine("Consumo de Combustible {0} Litros por KM", ConsumoCombustible);
            Console.WriteLine(value: $"Piloto: {(piloto != null ? piloto : "No hay piloto asignado!!")}");

        }

        //Controlar el estado del vehículo
        public virtual void acelerar(int cuanto)
        {
            if (estadoVehiculo == 1)
            {
                if (velocidad + cuanto > VelocidadMaxima)
                {
                    Console.WriteLine("¡Alerta! No se puede superar la velocidad máxima de {0} km/h.", VelocidadMaxima);
                }
                else
                {
                    velocidad += cuanto;
                    Console.WriteLine("Vas a {0} KMS / Hora", velocidad);
                }
            }
            else
            {
                Console.WriteLine("No se puede acelerar si el carro está apagado");
            }
        }
        public virtual void Frenar(int cuanto)
        {
            if (estadoVehiculo == 2)
            {
                velocidad -= cuanto;
                if (velocidad <= 0)
                {
                    velocidad = 0;
                    estadoVehiculo = 1;
                    Console.WriteLine("El vehículo se ha detenido.");
                }
                else
                {
                    Console.WriteLine("Vas a {0} KMS / Hora", velocidad);
                }
            }
            else
            {
                Console.WriteLine("El vehículo no está en movimiento.");
            }
        }

        public virtual void Apagar()
        {
            if (estadoVehiculo == 0)
            {
                estadoVehiculo = 0; 
                Console.WriteLine("El vehículo ha sido apagado.");
            }
            else
            {
                Console.WriteLine("El vehículo ya esta apagado.");
            }
        }

        public virtual string TipoLicencia()
        {
            return "Licencia de vehículo estándar.";
        }
    }
}
