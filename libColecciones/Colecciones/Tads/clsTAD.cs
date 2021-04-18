using Servicios.Colecciones.Interfaces;
using System;

namespace Servicios.Colecciones.Tads
{
    public class clsTAD <Tipo> : iTAD<Tipo>
    {
        #region Atributos
        #region Propios       
        protected int atrLongitud;
        #endregion
        #endregion
        #region Metodos
        #region Constructor
        /// <summary>
        /// Crea una nueva instancia de TAD predeterminada
        /// </summary>
        public clsTAD() 
        { 
        }
        #endregion
        #region Accesores
        /// <summary>
        /// Método accesor que devuelve la longitud de una instancia de TAD
        /// </summary>
        /// <returns></returns>
        public int darLongitud()
        {
            return atrLongitud;
        }
        #endregion
        #region Consultores
        public bool EsValido(int prmIndice)
        {
            return (prmIndice >= 0 && prmIndice < atrLongitud);
        }
        #endregion
        #region CRUD
        #region Inserciones
        protected virtual bool InsertarPrimero(ref Tipo prmItem) 
        {
            atrLongitud++;
            return true;
        }
        protected virtual bool InsertarUltimo(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected  virtual bool InsertarEnMedio(int prmIndice, ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected bool InsertarEn(int prmIndice, ref Tipo prmItem)
        {
            if (prmIndice == 0) return InsertarPrimero(ref prmItem);
            if (prmIndice == atrLongitud) return InsertarUltimo(ref prmItem);
            if(EsValido(prmIndice)) return InsertarEnMedio(prmIndice, ref prmItem);
            return false;
        }
        #endregion
        #region Extractores
        protected virtual bool ExtraerPrimero( ref Tipo prmItem)
        {
            atrLongitud++;
            return true;
        }
        protected virtual bool ExtraerUltimo( ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected virtual bool ExtraerEnMedio(int prmIndice, ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected bool ExtraerEn(int prmIndice, ref Tipo prmItem)
        {
            if (prmIndice == 0) return ExtraerPrimero(ref prmItem);
            if (prmIndice == atrLongitud) return ExtraerUltimo(ref prmItem);
            if (EsValido(prmIndice)) return ExtraerEnMedio(prmIndice, ref prmItem);
            return false;
        }
        #endregion
        #region Modificadores
        protected virtual bool ModificarPrimero(Tipo prmItem)
        {
            atrLongitud++;
            return true;
        }
        protected virtual bool ModificarUltimo(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected virtual bool ModificarEnMedio(int prmIndice, Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected bool ModificarEn(int prmIndice, Tipo prmItem)
        {
            if (prmIndice == 0) return ExtraerPrimero(ref prmItem);
            if (prmIndice == atrLongitud) return ExtraerUltimo(ref prmItem);
            if (EsValido(prmIndice)) return ExtraerEnMedio(prmIndice, ref prmItem);
            return false;
        }
        #endregion
        #region Recuperadoes
        protected virtual bool RecuperarPrimero(ref Tipo prmItem)
        {
            atrLongitud++;
            return true;
        }
        protected virtual bool RecuperarUltimo(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected virtual bool RecuperarEnMedio(int prmIndice, ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected bool RecuperarEn(int prmIndice, ref Tipo prmItem)
        {
            if (prmIndice == 0) return RecuperarPrimero(ref prmItem);
            if (prmIndice == atrLongitud) return RecuperarUltimo(ref prmItem);
            if (EsValido(prmIndice)) return RecuperarEnMedio(prmIndice, ref prmItem);
            return false;
        }
        #endregion
        #endregion
        #endregion
    }
}
