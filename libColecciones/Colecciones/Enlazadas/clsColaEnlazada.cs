using Servicios.Colecciones.Tads;
using Servicios.Colecciones.Interfaces;
using System;

namespace Servicios.Colecciones.Enlazadas
{
    class clsColaEnlazada<Tipo> : clsTADEnlazado<Tipo>, iCola<Tipo>
    {
        #region Metodos
        #region Constructor
        public clsColaEnlazada(){}
        #endregion
        #region CRUDS
        public bool Desencolar(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool Encolar(Tipo prmItem)
        {
            return InsertarUltimo(ref prmItem);
        }

        public bool Revisar(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
