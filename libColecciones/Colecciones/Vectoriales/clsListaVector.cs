using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;


namespace Servicios.Colecciones.Vectoriales
{
    public class clsListaVector<Tipo> : clsTADVectorial<Tipo>, iLista<Tipo>
    {
        #region Metodos
        #region Contructores
        /// <summary>
        /// Constructor no parametrizado el cual crea una nueva instancia con valores oredeterminados
        /// </summary>
        public clsListaVector()
        {

        }
        /// <summary>
        /// Constructor parametrizado el cual permite crear una nueva instancia estableciendo un valor para la capacidad
        /// </summary>
        /// <param name="prmCapacidad"></param>
        public clsListaVector(int prmCapacidad): base(prmCapacidad)
        {
            
        }
        #endregion
        /// <summary>
        /// Metodos CRUD por sus siglas en ingles Create Update Dalate
        /// </summary>
        /// <param name="prmItem"></param>
        /// <returns></returns>
        #region CRUDS
        public bool Agregar(Tipo prmItem)
        {
            //To-do
            return false;
        }
        public bool Insertar(int prmIndice,Tipo prmItem)
        {
            return InsertarEn(prmIndice, ref prmItem);
        }
        public bool Remover(int prmIndice, ref Tipo prmItem)
        {
            //To-do
            return false;
        }
        public bool Modificar(int prmIndice, Tipo prmItem)
        {
            //To-do
            return false;
        }
        public bool Recuperar(int prmIndice, ref Tipo prmItem)
        {
            //To-do
            return false;
        }
        public bool Encontrar(Tipo prmItem, ref int prmIndice)
        {
            //To-do
            return false;
        }

        #endregion
        #endregion
    }
}
