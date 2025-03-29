using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.Interfaces
{
    public interface Ipiloto
    {
        string Nombre { get; set; }
        int Edad { get; set; }
        string TipoLicencia { get; set; }

        void MostrarInformación();
    }


}
