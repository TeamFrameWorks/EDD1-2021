using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Interfaces
{
    interface iNodoDobleEnlazado <Tipo>
    {
        clsNodoDobleEnlazado<Tipo> darSiguiente();
        clsNodoDobleEnlazado<Tipo> darAnterior();
    }
}
