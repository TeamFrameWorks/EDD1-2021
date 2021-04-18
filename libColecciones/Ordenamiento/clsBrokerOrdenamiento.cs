using System;
namespace Servicios.Ordenamiento
{
    public static class clsBrokerOrdenamiento
    {
         #region Metodos
        /// <summary>
        /// Mejor caso O(n)
        /// Caso promedio O(n^2)
        /// Peor caso O(n^2)
        /// Implementa el Ordenamiento por el Método de la Burbuja Simple Original según el criterio Ascendente. Se implementa este método 
        /// como referencia para comparar su desempeño contra servicios de ordenamiento de la Librería ofrecidos por la clase TAD Y TAD vectorial, que si gestionan
        /// excepciones, mensajería y criterio de ordenamiento
        /// Referencia: https://juncotic.com/ordenamiento-de-burbuja-algoritmos-de-ordenamiento/
        /// </summary>
        /// <param name="prmVector"></param>
        public static void Burbuja(ref int[] prmVector)
        {
            int varPosExterior, varPosInterior, varElementoTemporal;
            for ( varPosExterior = 1; varPosExterior < prmVector.Length; varPosExterior++)
            {
                for (varPosInterior = 0; varPosInterior < prmVector.Length - varPosExterior; varPosInterior++)
                {
                    if(prmVector[varPosInterior] > prmVector[varPosInterior +1])
                    {
                        varElementoTemporal = prmVector[varPosInterior];
                        prmVector[varPosInterior] = prmVector[varPosInterior + 1];
                        prmVector[varPosInterior + 1] = varElementoTemporal;
                    }
                }
            }
        }
        /// <summary>
        /// Mejor caso O(n)
        /// Caso promedio O(n^2)
        /// Peor caso O(n^2)
        /// Implementa el Ordenamiento por el Método de la BurbujaMejorado Simple Original según el criterio Ascendente. Se implementa este método 
        /// como referencia para comparar su desempeño contra servicios de ordenamiento de la Librería ofrecidos por la clase TAD Y TAD vectorial, que si gestionan
        /// excepciones, mensajería y criterio de ordenamiento
        /// </summary>
        /// <param name="prmVector"></param>
        public static void BurbujaMejorado(ref int[] prmVector)
        {
            int varPosExterior, varPosInterior, varElementoTemporal;
            bool varHuboIntercambio;
            varPosExterior = 1;
            varHuboIntercambio = true;
            while ((varPosExterior < prmVector.Length) && varHuboIntercambio == true)
            {
                varPosExterior = varPosExterior + 1;
                varHuboIntercambio = false;
                for (varPosInterior = 0; varPosInterior <= prmVector.Length - varPosExterior; varPosInterior++)
                {
                    if (prmVector[varPosInterior] > prmVector[varPosInterior + 1])
                    {
                        varElementoTemporal = prmVector[varPosInterior];
                        prmVector[varPosInterior] = prmVector[varPosInterior + 1];
                        prmVector[varPosInterior + 1] = varElementoTemporal;
                        varHuboIntercambio = true;
                    }
                }
            }
        }
        /// <summary>
        /// Mejor caso: O(n)
        /// Caso promedio: O(n^2)
        /// Peor caso: O(n^2)
        /// Implementa el Ordenamiento por el Método de la BurbujaBiDireccional Simple Original según el criterio Ascendente. Se implementa este método 
        /// como referencia para comparar su desempeño contra servicios de ordenamiento de la Librería ofrecidos por la clase TAD Y TAD vectorial, que si gestionan
        /// excepciones, mensajería y criterio de ordenamiento
        /// Referencia: https://juncotic.com/ordenamiento-de-burbuja-bidireccional-algoritmos-de-ordenamiento/
        /// </summary>
        /// <param name="prmVector"></param>
        public static void BurbujaBiDireccional(ref int[] prmVector)
        {
            bool varHuboIntercambios;
            int varPos, varElementoTemporal;
            do
            {
                varHuboIntercambios = false;
                for (varPos = 0; varPos <= prmVector.Length - 2; varPos++)
                {
                    if (prmVector[varPos] > prmVector[varPos + 1])
                    {
                        varElementoTemporal = prmVector[varPos];
                        prmVector[varPos] = prmVector[varPos + 1];
                        prmVector[varPos + 1] = varElementoTemporal;
                        varHuboIntercambios = true;
                    }
                }
                if (varHuboIntercambios == false)
                {
                    break;
                }
                varHuboIntercambios = false;
                for (varPos = prmVector.Length -2; varPos >= 0; varPos--)
                {
                    if (prmVector[varPos] > prmVector[varPos + 1])
                    {
                        varElementoTemporal = prmVector[varPos];
                        prmVector[varPos] = prmVector[varPos + 1];
                        prmVector[varPos + 1] = varElementoTemporal;
                        varHuboIntercambios = true;
                    }
                }
            } while (varHuboIntercambios == true);
        }
        /// <summary>
        /// Mejor caso O(n^2)
        /// Caso promedio O(n^2)
        /// Peor caso O(n^2)
        /// Implementa el Ordenamiento por el Método de la BurbujaBiDireccional Simple Original según el criterio Ascendente. Se implementa este método 
        /// como referencia para comparar su desempeño contra servicios de ordenamiento de la Librería ofrecidos por la clase TAD Y TAD vectorial, que si gestionan
        /// excepciones, mensajería y criterio de ordenamiento
        /// Referencia: https://bitcu.co/metodos-de-ordenamiento/#:~:text=La%20complejidad%20en%20este%20caso,orden%20O(n2)
        /// </summary>
        /// <param name="prmVector"></param>
        public static void Insercion(ref int[] prmVector)
        {
            int varPosExterior, varPosInterior, varElementoInsertado;
            for(varPosExterior = 1; varPosExterior < prmVector.Length; varPosExterior++)
            {
                varElementoInsertado = prmVector[varPosExterior];
                varPosInterior = varPosExterior - 1;
                while (varPosInterior >= 0 && (prmVector[varPosInterior]!= varElementoInsertado) &&(prmVector[varPosInterior]> varElementoInsertado))
                {
                    prmVector[varPosInterior+1] = prmVector[varPosInterior];
                    varPosInterior = varPosInterior - 1;
                }
                prmVector[varPosInterior+1] = varElementoInsertado;
            }
        }

        /// <summary>
        /// Mejor caso O(n^2)
        /// Caso promedio O(n^2)
        /// Peor caso O(n^2)
        /// Implementa el Ordenamiento por el Método de Selección Original según Criterio Ascendente.Se implementa 
        /// este método como referencia para comparar su desempeño contra los servicios de ordenamiento de la Librería ofrecidos por la clase TAD y TAD vectorial, que sí gestionan
        /// excepciones, mensajería y criterio de ordenamiento.
        /// Referencia: https://bitcu.co/metodos-de-ordenamiento/#:~:text=La%20complejidad%20en%20este%20caso,orden%20O(n2)
        /// </summary>
        /// <param name="prmVector"></param>
        public static void Seleccion(ref int[] prmVector)
        {
            int varPosExterior, varPosInterior, varPosDelMinimo, varElementoTemporal;
            for(varPosExterior = 0; varPosExterior < prmVector.Length; varPosExterior++)
            {
                varPosDelMinimo = varPosExterior;
                for (varPosInterior = varPosExterior +1; varPosInterior < prmVector.Length; varPosInterior++)
                {
                    if(prmVector[varPosInterior] < prmVector[varPosDelMinimo])
                    {
                        varPosDelMinimo = varPosInterior;
                    }
                }
                if(varPosDelMinimo != varPosExterior)
                {
                    varElementoTemporal = prmVector[varPosDelMinimo];
                    prmVector[varPosDelMinimo] = prmVector[varPosExterior];
                    prmVector[varPosExterior] = varElementoTemporal;
                }
            }
        }
        /// <summary>
        /// Mejor caso O(log n)
        /// Caso promedio O(n * log n)
        /// Peor caso O(n^2)
        /// Implementa el Ordenamiento por el Método de QuickSort Original según Criterio Ascendente.Se implementa 
        /// este método como referencia para comparar su desempeño contra los servicios de ordenamiento de la Librería ofrecidos por la clase TAD y TAD vectorial, que sí gestionan
        /// excepciones, mensajería y criterio de ordenamiento.
        /// Referencia: https://bitcu.co/metodos-de-ordenamiento/#:~:text=La%20complejidad%20en%20este%20caso,orden%20O(n2)
        /// </summary>
        /// <param name="prmVector"></param>
        /// <param name="prmPosDelPrimero"></param>
        /// <param name="prmPosDelUltimo"></param>
        public static void QuickSort(ref int[] prmVector, int prmPosDelPrimero, int prmPosDelUltimo)
        {
            int varPosIzquierdo, varPosDerecho, varElementoPivote, varElementoTemporal;
            varElementoPivote = prmVector[(prmPosDelPrimero + prmPosDelUltimo) / 2];
            varPosIzquierdo = prmPosDelPrimero;
            varPosDerecho = prmPosDelUltimo;
            while (varPosIzquierdo <= varPosDerecho && (prmPosDelUltimo - prmPosDelPrimero) > 0)
            {
                while (prmVector[varPosIzquierdo] < varElementoPivote)
                {
                    varPosIzquierdo = varPosIzquierdo + 1;
                }
                while (prmVector[varPosDerecho] > varElementoPivote)
                {
                    varPosDerecho = varPosDerecho - 1;
                }
                if(varPosIzquierdo <= varPosDerecho)
                {
                    varElementoTemporal = prmVector[varPosIzquierdo];
                    prmVector[varPosIzquierdo] = prmVector[varPosDerecho];
                    prmVector[varPosDerecho] = varElementoTemporal;
                    varPosIzquierdo = varPosIzquierdo + 1;
                    varPosDerecho = varPosDerecho - 1;
                }
            }
            if(prmPosDelPrimero < varPosDerecho)
            {
                QuickSort(ref prmVector, prmPosDelPrimero, varPosDerecho);
            }
            if(varPosIzquierdo < prmPosDelUltimo)
            {
                QuickSort(ref prmVector, varPosIzquierdo, prmPosDelUltimo);
            }
        }
        /// <summary>
        /// Método que busca un item dentro de un vector
        /// </summary>
        /// <param name="prmVector"></param>
        /// <param name="prmItem"></param>
        /// <returns></returns>
        public static int buscarSecuencial(ref int[] prmVector, int prmItem)
        {           
            int varPosicion = 0;           
            while (varPosicion < prmVector.Length)
            {
                if(prmVector[varPosicion]== prmItem)
                {
                    return varPosicion;
                }                                    
                else                
                    varPosicion++;                
            }
            return -1;
        }
        public static int buscarBinario(ref int[] prmVector, int prmTopeInferior, int prmTopeSuperior, int prmItem)
        {            
            int varPosicionCentro;            
            if (prmTopeInferior >= prmTopeSuperior)
                return -1;
            else
            {
                varPosicionCentro = (prmTopeSuperior + prmTopeInferior) / 2;
                if (prmVector[varPosicionCentro] < prmItem)
                    return buscarBinario(ref prmVector, varPosicionCentro + 1, prmTopeSuperior, prmItem);
                else
                {
                    if (prmVector[varPosicionCentro] > prmItem)
                        return buscarBinario(ref prmVector, prmTopeInferior, varPosicionCentro - 1, prmItem);
                    else
                    {
                        return varPosicionCentro;
                    }
                }
            }                                           
        }
        #endregion
    }
}
