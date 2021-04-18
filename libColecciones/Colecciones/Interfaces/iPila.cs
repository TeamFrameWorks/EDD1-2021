

namespace Servicios.Colecciones.Interfaces
{
    public interface iPila<Tipo>
    {
        bool Apilar(Tipo prmItem);
        bool Desapilar(ref Tipo prmItem);
        bool Revisar(ref Tipo prmItem);
    }
}
