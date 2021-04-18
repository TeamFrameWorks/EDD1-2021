


namespace Servicios.Colecciones.Interfaces
{
    public interface iLista<Tipo>
    {
        bool Agregar(Tipo prmItem);
        bool Insertar(int prmIndice, Tipo prmItem);
        bool Remover(int prmIndice, ref Tipo prmItem);
        bool Modificar(int prmIndice, Tipo prmItem);
        bool Recuperar(int prmIndice, ref Tipo prmItem);
        bool Encontrar(Tipo prmItem, ref int prmIndice);
    }
}
