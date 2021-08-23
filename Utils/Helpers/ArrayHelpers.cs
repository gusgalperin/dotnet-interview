using System.Collections.Generic;

namespace Utils
{
    public static class ArrayHelpers
    {
        /*
         * Recibe dos arrays, ambos con datos de tipo numérico,ambos ordenados en forma ascendente,
         * y sin repetidos dentro de cada array (puede haber repetidos entre un array y otro).
         * Devuelve un nuevo array, que contiene todos los datos de ambos arrays, también ordenados en forma ascendente,
         * y también sin repetidos
         *
         * Ejemplo
         * Input: array1 = [1, 5, 8, 10], array2 = [2, 3, 8, 11]
         * Output:[1, 2, 3, 5, 8, 10, 11]
         *
         * Observación
         * Si se te ocurrió una solución que requiere poder ordenar un array o usar funciones de LINQ o similares,
         * pensá en otra forma de hacerlo
         */

        public static int[] CombinarDosArrays(int[] first, int[] second)
        {
            var resultado = new List<int>();

            return resultado.ToArray();
        }

        /*
         * Igual que la función anterior, solo que ésta recibe un array de arrays de números ordenados en forma ascendente y sin repetidos,
         * y devuelve un nuevo array, con la combinación de todos los números de todos los arrays recibidos,
         * también ordenados en forma ascendente, y también sin repetidos.
         *
         * Ejemplo
         * Input: arrays = [[1, 3, 10],[2, 3, 15, 16],[4],[6, 7, 13]]
         * Output:[1, 2, 3, 4, 6, 7, 10, 13, 15, 16]
         *
         * Nota
         * Asumir que solo habra valores en las posiciones [0][0...n]
         */

        public static int[] CombinarNArrays(int[][] arrays)
        {
            var resultado = new List<int>();

            return resultado.ToArray();
        }
    }
}