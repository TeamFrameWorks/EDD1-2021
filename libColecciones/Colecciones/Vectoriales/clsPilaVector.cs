using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;

namespace Servicios.Colecciones.Vectoriales
{
    public class clsPilaVector<Tipo> : clsTADVectorial<Tipo>, iPila<Tipo>
    {
        #region Metodos
        #region Constructores
        /// <summary>
        /// Constructor no parametrizado el cual crea una nueva instancia con valores predeterminados
        /// </summary>
        public clsPilaVector()
        {
            
            
        }
        /// <summary>
        /// Constructor parametrizado el cual permite crear una nueva instancia estableciendo un valor para la capacidad
        /// </summary>
        /// <param name="prmCapacidad"></param>
        public clsPilaVector(int prmCapacidad) : base(prmCapacidad)
        {
            
        }
        #endregion
        /// <summary>
        /// Metodos CRUD por sus siglas en ingles Create Update Dalate
        /// </summary>
        /// <param name="prmItem"></param>
        /// <returns></returns>
        #region CRUD
        public bool Apilar(Tipo prmItem)
        {
            return InsertarPrimero(ref prmItem);
        }
        public bool Desapilar(ref Tipo prmItem)
        {
            //To do
            return false;
        }
        public bool Revisar(ref Tipo prmItem)
        {
            //To do
            return false;
        }
        #endregion
        #endregion
    }
}
