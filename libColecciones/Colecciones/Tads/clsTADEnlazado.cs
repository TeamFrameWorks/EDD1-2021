using Servicios.Colecciones.Nodos;
using Servicios.Colecciones.Interfaces;
using System;
namespace Servicios.Colecciones.Tads
{
    public class clsTADEnlazado<Tipo>: clsTAD<Tipo>, iTADEnlazada<Tipo>
    {
        #region Atributos
        #region Asociativo
        private clsNodoEnlazado<Tipo> atrPrimero = null;
        private clsNodoEnlazado<Tipo> atrUltimo = null;
        #endregion
        #endregion
        #region Metodos
        #region Constructor
        public clsTADEnlazado() { }
        #endregion
        #region Accesor
        public clsNodoEnlazado<Tipo> darPrimero()
        {
            throw new NotImplementedException();
        }
        public clsNodoEnlazado<Tipo> darUltimo()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region CRUD
        #region Inserciones
        protected override bool InsertarPrimero(ref Tipo prmItem)
        {
            atrLongitud++;
            return true;
        }
        protected override bool InsertarUltimo(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected override bool InsertarEnMedio(int prmIndice, ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Extractores
        protected override bool ExtraerPrimero(ref Tipo prmItem)
        {
            atrLongitud++;
            return true;
        }
        protected override bool ExtraerUltimo(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected override bool ExtraerEnMedio(int prmIndice, ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Modificadores
        protected override bool ModificarPrimero(Tipo prmItem)
        {
            atrLongitud++;
            return true;
        }
        protected override bool ModificarUltimo(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected override bool ModificarEnMedio(int prmIndice, Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Recuperadoes
        protected override bool RecuperarPrimero(ref Tipo prmItem)
        {
            atrLongitud++;
            return true;
        }
        protected override bool RecuperarUltimo(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected override bool RecuperarEnMedio(int prmIndice, ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
        #endregion
    }
}
