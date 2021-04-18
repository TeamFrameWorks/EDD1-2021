using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Interfaces
{
    public interface iTADDobleEnlazado<Tipo>
    {
        clsNodoDobleEnlazado<Tipo> darPrimero();
        clsNodoDobleEnlazado<Tipo> darUltimo();
    }
}
