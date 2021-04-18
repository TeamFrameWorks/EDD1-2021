using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Ordenamiento;
using Servicios.Colecciones.Vectoriales;

namespace uTestColecciones
{
    [TestClass]
    public class uTestPilaVector
    {

        #region Vectoriales
        #region iPilaVector
        private clsPilaVector<int> miPila;    
        
        #region Constructor
        [TestMethod]
        public void uTestConstructorNoParametrizado()
        {
            #region Configurar y Probar
            miPila = new clsPilaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(100, miPila.darCapacidad());
            Assert.AreEqual(100, miPila.darItems().Length);
            Assert.AreEqual(0, miPila.darLongitud());
            #endregion
        }
        [TestMethod]
        public void uTestConstructorParametrizado()
        {
            #region Configurar y Probar
            miPila = new clsPilaVector<int>(20);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(20, miPila.darCapacidad());
            Assert.AreEqual(20, miPila.darItems().Length);
            Assert.AreEqual(0, miPila.darLongitud());
            #endregion
        }
        #endregion
        #region Accesores
        [TestMethod]
        public void testDarLongitud()
        {
            #region Configurar
            miPila = new clsPilaVector<int>();
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(0, miPila.darLongitud());
            #endregion
        }
        #endregion
        #region CRUDS
        [TestMethod]
        public void uTestApilar()
        {
            #region Configurar
            miPila = new clsPilaVector<int>();
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(true, miPila.Apilar(2905));
            Assert.AreEqual(true, miPila.Apilar(2909));
            Assert.AreEqual(2, miPila.darLongitud());
            Assert.AreEqual(2909, miPila.darItems()[0]);
            Assert.AreEqual(2905, miPila.darItems()[1]);            
            #endregion

        }
        [TestMethod]
        public void uTestDesapilar() 
        {
          
        }
        #endregion
        #endregion
        #endregion
    }
}
