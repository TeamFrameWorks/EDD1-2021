using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Ordenamiento;
using Servicios.Colecciones.Vectoriales;

namespace uTestColecciones
{
    [TestClass]
    public class uTestOrdenamiento
    {

        #region Ordenamiento
        [TestMethod]
        public void UTestBurbuja()
        {
            int[] vecPrueba = new int[50000];
            for (int i = 0; i < vecPrueba.Length; i++)
            {
                vecPrueba[i] = vecPrueba.Length - i;
            }
            clsBrokerOrdenamiento.Burbuja(ref vecPrueba);
            bool varOrdenado = true;

            for (int i = 0; i < vecPrueba.Length - 1; i++)
            {
                if (vecPrueba[i + 1] < vecPrueba[i])
                {
                    varOrdenado = false;
                    break;
                }

            }
            Assert.AreEqual(true, varOrdenado);
        }
        [TestMethod]
        public void UTestBurbujaMejorado()
        {
            int[] vecPrueba = new int[50000];
            for (int i = 0; i < vecPrueba.Length; i++)
            {
                vecPrueba[i] = vecPrueba.Length - i;
            }
            clsBrokerOrdenamiento.BurbujaMejorado(ref vecPrueba);
            bool varOrdenado = true;

            for (int i = 0; i < vecPrueba.Length - 1; i++)
            {
                if (vecPrueba[i + 1] < vecPrueba[i])
                {
                    varOrdenado = false;
                    break;
                }

            }
            Assert.AreEqual(true, varOrdenado);
        }
        [TestMethod]
        public void UTestBurbujaBiDireccional()
        {
            int[] vecPrueba = new int[50000];
            for (int i = 0; i < vecPrueba.Length; i++)
            {
                vecPrueba[i] = vecPrueba.Length - i;
            }
            clsBrokerOrdenamiento.BurbujaBiDireccional(ref vecPrueba);
            bool varOrdenado = true;

            for (int i = 0; i < vecPrueba.Length - 1; i++)
            {
                if (vecPrueba[i + 1] < vecPrueba[i])
                {
                    varOrdenado = false;
                    break;
                }

            }
            Assert.AreEqual(true, varOrdenado);
        }
        [TestMethod]
        public void UTestInsercion()
        {
            int[] vecPrueba = new int[50000];
            for (int i = 0; i < vecPrueba.Length; i++)
            {
                vecPrueba[i] = vecPrueba.Length - i;
            }
            clsBrokerOrdenamiento.Insercion(ref vecPrueba);
            bool varOrdenado = true;

            for (int i = 0; i < vecPrueba.Length - 1; i++)
            {
                if (vecPrueba[i + 1] < vecPrueba[i])
                {
                    varOrdenado = false;
                    break;
                }

            }
            Assert.AreEqual(true, varOrdenado);
        }
        [TestMethod]
        public void UTestSeleccion()
        {
            int[] vecPrueba = new int[50000];
            for (int i = 0; i < vecPrueba.Length; i++)
            {
                vecPrueba[i] = vecPrueba.Length - i;
            }
            clsBrokerOrdenamiento.Seleccion(ref vecPrueba);
            bool varOrdenado = true;

            for (int i = 0; i < vecPrueba.Length - 1; i++)
            {
                if (vecPrueba[i + 1] < vecPrueba[i])
                {
                    varOrdenado = false;
                    break;
                }

            }
            Assert.AreEqual(true, varOrdenado);
        }
        [TestMethod]
        public void UTestQuickSort()
        {
            int[] vecPrueba = new int[50000];
            for (int i = 0; i < vecPrueba.Length; i++)
            {
                vecPrueba[i] = vecPrueba.Length - i;
            }
            clsBrokerOrdenamiento.QuickSort(ref vecPrueba, 0, vecPrueba.Length - 1);
            bool varOrdenado = true;

            for (int i = 0; i < vecPrueba.Length - 1; i++)
            {
                if (vecPrueba[i + 1] < vecPrueba[i])
                {
                    varOrdenado = false;
                    break;
                }

            }
            Assert.AreEqual(true, varOrdenado);
        }
        [TestMethod]
        public void UTestBuscarSecuencial()
        {
            int[] vecPrueba = new int[50000];
            for (int i = 0; i < vecPrueba.Length; i++)
            {
                vecPrueba[i] = vecPrueba.Length - i;
            }
            Assert.AreEqual(49999, clsBrokerOrdenamiento.buscarSecuencial(ref vecPrueba, 1));
            Assert.AreEqual(-1, clsBrokerOrdenamiento.buscarSecuencial(ref vecPrueba, 500001));


        }
        [TestMethod]
        public void UTestBuscarBinario()
        {
            int[] vecPrueba = new int[50000];
            for (int i = 0; i < vecPrueba.Length; i++)
            {
                vecPrueba[i] = vecPrueba.Length - i;
            }
            clsBrokerOrdenamiento.QuickSort(ref vecPrueba, 0, vecPrueba.Length - 1);
            Assert.AreEqual(49999, clsBrokerOrdenamiento.buscarBinario(ref vecPrueba, 0, vecPrueba.Length, 50000));
            Assert.AreEqual(-1, clsBrokerOrdenamiento.buscarBinario(ref vecPrueba, 0, vecPrueba.Length, 50001));


        }
        #endregion
        
    }
}
