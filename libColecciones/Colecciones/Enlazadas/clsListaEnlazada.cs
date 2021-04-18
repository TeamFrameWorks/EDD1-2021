using Servicios.Colecciones.Tads;
using Servicios.Colecciones.Interfaces;
using System;

namespace Servicios.Colecciones.Enlazadas
{
    public class clsListaEnlazada<Tipo> : clsTADEnlazado<Tipo>, iLista<Tipo>
    {
        #region Metodos
        #region Contructor
        public clsListaEnlazada() { }
        #endregion
        #region CRUDS
        public bool Agregar(Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool Encontrar(Tipo prmItem, ref int prmIndice)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(int prmIndice, Tipo prmItem)
        {
            return InsertarEn(prmIndice, ref prmItem);
        }

        public bool Modificar(int prmIndice, Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool Recuperar(int prmIndice, ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool Remover(int prmIndice, ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
