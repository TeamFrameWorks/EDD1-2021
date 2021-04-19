using Servicios.Colecciones.Tads;
using Servicios.Colecciones.Interfaces;
using System;

namespace Servicios.Colecciones.DobleEnlazadas
{
    public class clsColaDobleEnlazada <Tipo>: clsTADDobleEnlazada<Tipo>, iCola<Tipo>
    {
        #region Metodos
        #region Constructores
        public clsColaDobleEnlazada() { }
        #endregion
        #region CRUDS
        public bool Desencolar(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool Encolar(Tipo prmItem)
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
