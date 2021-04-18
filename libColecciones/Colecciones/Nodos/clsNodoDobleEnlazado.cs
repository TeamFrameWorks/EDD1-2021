using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Nodos
{
    public class clsNodoDobleEnlazado<Tipo> : clsNodo<Tipo>, iNodoDobleEnlazado<Tipo>
    {
        #region Atributos
        #region Asociativos
        private clsNodoDobleEnlazado<Tipo> atrAnterior;
        private clsNodoDobleEnlazado<Tipo> atrSiguiente;
        #endregion
        #endregion
        #region Metodos
        #region Constructores
        public clsNodoDobleEnlazado() { }
        public clsNodoDobleEnlazado(Tipo prmItem):base(prmItem) { }
        #endregion
        #region Accesores
        public clsNodoDobleEnlazado<Tipo> darAnterior()
        {
            throw new NotImplementedException();
        }
        public clsNodoDobleEnlazado<Tipo> darSiguiente()
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
