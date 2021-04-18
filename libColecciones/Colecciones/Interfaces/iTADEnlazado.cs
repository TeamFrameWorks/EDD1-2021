using Servicios.Colecciones.Nodos;
namespace Servicios.Colecciones.Interfaces
{
    interface iTADEnlazada<Tipo>
    {
        clsNodoEnlazado<Tipo> darPrimero();
        clsNodoEnlazado<Tipo> darUltimo();
    }
}
