using Servicios.Colecciones.Tads;
using Servicios.Colecciones.Interfaces;
using System;

namespace Servicios.Colecciones.DobleEnlazadas
{
    public class clsListaDobleEnlazada <Tipo> : clsTADDobleEnlazada<Tipo>, iLista<Tipo>
    {
        #region Metodos
        #region Constructores
        public clsListaDobleEnlazada() { }
        #endregion
        #region CRUDS

        public bool Agregar(Tipo prmItem)
        {
            throw new System.NotImplementedException();
        }

        public bool Encontrar(Tipo prmItem, ref int prmIndice)
        {
            throw new System.NotImplementedException();
        }

        public bool Insertar(int prmIndice, Tipo prmItem)
        {
            throw new NotImplementedException();
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
