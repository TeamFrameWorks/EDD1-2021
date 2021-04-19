using Servicios.Colecciones.Interfaces;
using System;


namespace Servicios.Colecciones.Tads
{
    public class clsTADVectorial<Tipo> : clsTAD<Tipo> , iTADVectorial<Tipo> 
    {
        #region Atributos
        #region Propios
        private int atrCapacidad = -1;
        private Tipo[] atrItems ;
        #endregion
        #endregion
        #region Metodos
        #region Constructor
        /// <summary>
        /// Crea una nueva instancia predeterminada de TADVectorial
        /// </summary>
        public clsTADVectorial()
        {
            atrCapacidad = 100;
            atrItems = new Tipo[100];
        }
        /// <summary>
        /// Crea una nueva instancia asignando una capacidad máxima
        /// </summary>
        /// <param name="prmCapacidad"></param>
        public clsTADVectorial(int prmCapacidad)
        {
            atrCapacidad = prmCapacidad;
            atrItems = new Tipo[atrCapacidad];        
        }
        #endregion
        #region Accesores
        /// <summary>
        /// Devuelve una copia del atrivuto "Items" de una instancia TADVectorial
        /// </summary>
        /// <returns></returns>
        public Tipo[] darItems()
        {
            return atrItems;
        }
        /// <summary>
        /// Método accesor que retorna el atributo array Items 
        /// </summary>
        /// <returns></returns>
        public int darCapacidad()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Mutadores
        /// <summary>
        /// Método mutador que permite poner Items dentro del TADVectorial
        /// </summary>
        /// <param name="prmItems"></param>
        public void ponerItems(Tipo[] prmItems)
        {
            //TO do
        }
        #endregion
        #region CRUD
        #region Inserciones
        protected override bool InsertarPrimero(ref Tipo prmItem)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
