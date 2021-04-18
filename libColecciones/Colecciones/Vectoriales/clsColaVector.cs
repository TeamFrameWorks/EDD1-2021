
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;

namespace Servicios.Colecciones.Vectoriales
{
    public class clsColaVector<Tipo> : clsTADVectorial<Tipo>, iCola<Tipo>
    {
        #region Metodos
        #region Constructores
        /// <summary>
        /// Constructor sin parametros con una capacidad predeterminada
        /// </summary>
        public clsColaVector()
        {

        }
        /// <summary>
        /// Constructor parametrizado que premite establecer la capacidad de la Cola
        /// </summary>
        /// <param name="prmCapacidad"></param>
        public clsColaVector(int prmCapacidad) : base(prmCapacidad)
        {

        }
        #endregion
        /// <summary>
        /// Metodos CRUD por sus siglas en ingles Create Update Dalate
        /// </summary>
        /// <param name="prmItem"></param>
        /// <returns></returns>
        #region CRUDS
        public bool Encolar(Tipo prmItem)
        {
            return InsertarUltimo(ref prmItem);
        }
        public bool Desencolar(ref Tipo prmItem)
        {
            //To-Do
            return false;
        }
        public bool Revisar(ref Tipo prmItem)
        {
            //To-Do
            return false;
        }
        #endregion
        #endregion
    }
}
