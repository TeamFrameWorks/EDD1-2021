using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;
using System;

namespace Servicios.Colecciones.Tads
{
    public class clsTADDobleEnlazada<Tipo> : clsTAD<Tipo>, iTADDobleEnlazado<Tipo>
    {
        #region Atributos
        #region Asociativos
        private clsNodoDobleEnlazado<Tipo> atrPrimero;
        private clsNodoDobleEnlazado<Tipo> atrUltimo;
        #endregion
        #endregion
        #region Metodos
        #region Constructores
        public clsTADDobleEnlazada() { }
        #endregion
        #region Accesores
        public clsNodoDobleEnlazado<Tipo> darPrimero()
        {
            throw new NotImplementedException();
        }
        public clsNodoDobleEnlazado<Tipo> darUltimo()
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
