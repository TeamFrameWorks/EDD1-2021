using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Nodos
{
    public class clsNodo<Tipo> : iNodo<Tipo>
    {
        #region atributos
        private Tipo atrItem = default(Tipo);
        #endregion
        #region Metodos
        public clsNodo() { }
        public clsNodo(Tipo prmItem) { }
        #region Accesor
        public Tipo darItem()
        {
            return default(Tipo);
        }
        #endregion
        #region Mutador
        public void ponerItem(Tipo prmCOntenido)
        {

        }
        #endregion
        #endregion
    }
}
