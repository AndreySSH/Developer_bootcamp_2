public static class ArrayMath
{
    /// <summary>
    /// Вычисляет максимальную сумму из стоящих друг за другом m элементов
    /// </summary>
    /// <param name="array">Массив</param>
    /// <param name="m">число элементов для складывания</param>
    /// <returns></returns>
    public static int BadGetSum(this int[] array, int m = 3)
    {
        int max = 0;

        int size = array.Length;

        for (int i = 0; i <= size - m; i++)
        {
            int t = 0;
            for (int j = i; j < i + m ; j++) t += array[j];
            if (t > max) max = t;
        }

        return max;
    }

    public static int GoodGetSum(this int[] array, int m = 3)
    {
        int max = 0;

        int size = array.Length;

        for (int i = 0; i < m; i++)  max += array[i];
        int t = max;
        // System.Console.WriteLine($"i:{0} t:{t}");
        
        for (int i = 1; i <= size - m; i++)
        {
            t = t - array[i - 1] + array[i + m - 1];
            // System.Console.WriteLine($"i:{i} t:{t}");
            if(t > max) max = t;
        }

        return max;
    }
}