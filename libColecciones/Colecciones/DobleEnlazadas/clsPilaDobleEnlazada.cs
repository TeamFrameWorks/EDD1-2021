using Servicios.Colecciones.Tads;
using Servicios.Colecciones.Interfaces;
using System;

namespace Servicios.Colecciones.DobleEnlazadas
{
    public class clsPilaDobleEnlazada<Tipo> : clsTADDobleEnlazada<Tipo>, iPila<Tipo>
    {
        #region Metodos
        #region Constructores
        public clsPilaDobleEnlazada() { }
        #endregion
        #region CRUDS
        public bool Apilar(Tipo prmItem)
        {
            return InsertarPrimero(ref prmItem);
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
