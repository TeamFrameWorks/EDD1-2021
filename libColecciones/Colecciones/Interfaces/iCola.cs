

namespace Servicios.Colecciones.Interfaces
{
    public interface iCola<Tipo>
    {      
        bool Encolar(Tipo prmItem);
        bool Desencolar(ref Tipo prmItem);
        bool Revisar(ref Tipo prmItem);
    }
}
