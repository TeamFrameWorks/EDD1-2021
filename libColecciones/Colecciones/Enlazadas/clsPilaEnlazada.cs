using Servicios.Colecciones.Tads;
using Servicios.Colecciones.Interfaces;
using System;

namespace Servicios.Colecciones.Enlazadas
{
    public class clsPilaEnlazada<Tipo> : clsTADEnlazado<Tipo>, iPila<Tipo>
    {
        #region Metodos
        #region Constructor
        public clsPilaEnlazada() { }
        #endregion
        #region CRUDS
        public bool Apilar(Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool Desapilar(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool Revisar(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
