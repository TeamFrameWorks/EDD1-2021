
namespace Servicios.Colecciones.Interfaces
{
    public interface iTADVectorial<Tipo> 
    {
        Tipo[] darItems();
        int darCapacidad();
        void ponerItems(Tipo[] prmItems);
    }
}
