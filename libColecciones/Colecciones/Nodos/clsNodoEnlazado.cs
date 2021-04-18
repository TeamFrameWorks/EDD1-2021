using Servicios.Colecciones.Interfaces;
using System;
namespace Servicios.Colecciones.Nodos
{
    public class clsNodoEnlazado<Tipo> : clsNodo<Tipo>, iNodoEnlazado<Tipo>
    {
        #region Atributos
        #region Asociativos
        private clsNodoEnlazado<Tipo> atrSiguiente;
        #endregion
        #endregion
        #region Metodos
        #region Constructores
        public clsNodoEnlazado() { }
        public clsNodoEnlazado(Tipo prmItem): base(prmItem) { }
        #endregion
        #region accesor
        public clsNodoEnlazado<Tipo> darSiguiente()
        {
            throw new NotImplementedException();
        }
        #endregion

        #endregion
    }
}
